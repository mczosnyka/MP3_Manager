using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLitePCL;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace MP3Manager
{
    public static class DatabaseHelper
    {
        private const string DatabaseFileName = "AlbumDatabase.db";


        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={DatabaseFileName};Version=3;");
        }

        public static void CreateDatabaseIfNotExists()
        {
            if (!File.Exists(DatabaseFileName))
            {
                // Jeśli baza danych nie istnieje, utwórz ją
                SQLiteConnection.CreateFile(DatabaseFileName);

                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Utwórz tabelę albums, jeśli nie istnieje
                    string createTableSql = "CREATE TABLE IF NOT EXISTS albums (" +
                                            "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                            "nazwa TEXT NOT NULL," +
                                            "autor TEXT NOT NULL," +
                                            "rok_wydania INTEGER NOT NULL," +
                                            "data_dodania DATE NOT NULL" +
                                            ");";

                    using (var command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void DeleteFromDataBase(string name, string artist)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string deletion = "DELETE FROM albums WHERE nazwa=@name and autor=@artist";
                using (var command = new SQLiteCommand(deletion, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@artist", artist);
                    command.ExecuteNonQuery();
                }
            }
        }


        public static bool AddToDatabase(string name, string artist, int releaseYear, string addDate)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                string addAlbums = "INSERT INTO albums (nazwa, autor, rok_wydania, data_dodania) VALUES (@name, @artist, @releaseYear, @addDate)";
                string checkUnique = "SELECT nazwa, autor FROM albums WHERE nazwa = @name;";
                string uniquetestName = String.Empty;
                string uniquetestArtist = String.Empty;
                using (var command = new SQLiteCommand(checkUnique, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            uniquetestName = reader.GetString(0);
                            uniquetestArtist = reader.GetString(1);
                            if(uniquetestArtist == artist && uniquetestName == name)
                            {
                                return false;
                            }
                        }
                    }

                }
                {
                    using (var command = new SQLiteCommand(addAlbums, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@artist", artist);
                        command.Parameters.AddWithValue("@releaseYear", releaseYear);
                        command.Parameters.AddWithValue("@addDate", addDate);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
        }

        public static List<Album> SelectFromDatabase(string name, string artist, int releaseYear, string month, string year, int filter)
        {
            List<Album> readAlbums = new List<Album>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string selector;

                if(releaseYear == 0)
                {
                    if(year == "0")
                    {
                        if(month == "0")
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist";
                        }
                        else
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND STRFTIME('%m', data_dodania)=@month";
                        }
                    }
                    else
                    {
                        if (month == "0")
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND STRFTIME('%Y', data_dodania)=@year";
                        }
                        else
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND STRFTIME('%m', data_dodania)=@month AND STRFTIME('%Y', data_dodania)=@year";
                        }
                    }
                }
                else
                {
                    if (year == "0")
                    {
                        if (month == "0")
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND rok_wydania=@releaseyear";
                        }
                        else
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND STRFTIME('%m', data_dodania)=@month AND rok_wydania=@releaseyear";
                        }
                    }
                    else
                    {
                        if (month == "0")
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND EXTRACT(YEAR FROM data_dodania)=@year AND rok_wydania=@releaseyear";
                        }
                        else
                        {
                            selector = "SELECT * FROM albums WHERE nazwa LIKE @name AND autor LIKE @artist AND STRFTIME('%m', data_dodania)=@month AND STRFTIME('%Y', data_dodania)=@year AND rok_wydania=@releaseyear";
                        }
                    }
                }
                if(filter == 1)
                {
                    selector += " ORDER BY nazwa ASC";
                }
                else if (filter == 2)
                {
                    selector += " ORDER BY nazwa DESC";
                }

                else if (filter == 3)
                {
                    selector += " ORDER BY autor ASC";
                }

                else if (filter == 4)
                {
                    selector += " ORDER BY autor DESC";
                }
                else if (filter == 5)
                {
                    selector += " ORDER BY data_dodania ASC";
                }
                else if (filter == 6)
                {
                    selector += " ORDER BY data_dodania DESC";
                }
                else if (filter == 7)
                {
                    selector += " ORDER BY rok_wydania DESC";
                }
                else if (filter == 8)
                {
                    selector += " ORDER BY rok_wydania ASC";
                }


                {
                    using (var command = new SQLiteCommand(selector, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@artist", artist);
                        command.Parameters.AddWithValue("@releaseyear", releaseYear);
                        command.Parameters.AddWithValue("@month", month);
                        command.Parameters.AddWithValue("@year", year);

                        
                        using (var reader = command.ExecuteReader())
                        {

                            while(reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nm = reader.GetString(1);
                                string ar = reader.GetString(2);
                                int ry = reader.GetInt32(3);
                                string ad = reader.GetString(4);
                                Album alb = new Album(nm, ar, ry, ad);
                                readAlbums.Add(alb);
                            }

                        }
                    }

                }
            }
            return readAlbums;
        }
    }
    }

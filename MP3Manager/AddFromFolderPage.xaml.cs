using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MP3Manager
{
    /// <summary>
    /// Logika interakcji dla klasy AddFromFolderPage.xaml
    /// </summary>
    public partial class AddFromFolderPage : Page
    {
        public AddFromFolderPage()
        {
            InitializeComponent();
            AddingDate.SelectedDate = DateTime.Today;
            int currentYear = DateTime.Now.Year;
        }

        private void ChangePage_MainWindow(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
               Path.Text = string.Empty;
                DateTime? addingdate = DateTime.Today;
                mainWindow.Content = mainWindow.addPage;
            }
        }

        private void AddDesiredAlbums(object sender, RoutedEventArgs e)
        {
            var directories = Directory.GetDirectories(Path.Text);
            DateTime addingDate = (DateTime)AddingDate.SelectedDate;
            string formattedDate = addingDate.ToString("yyyy-MM-dd");
            if (directories.Length > 0)
            {
                directories = directories.ToArray();
            }
            else
            {
                ErrorPopup.IsOpen = true;
                return;
            }
            for (int i = 0; i < directories.Length; i++)
            {
                directories[i] = directories[i].Replace(Path.Text, "");
                directories[i] = directories[i].Replace("\\", "");
                int indexOfArtistSubstring = directories[i].IndexOf(" - ");
                int indexOfAlbumSubstring = directories[i].IndexOf(" (2");
                if(indexOfAlbumSubstring == -1)
                {
                    indexOfAlbumSubstring = directories[i].IndexOf(" (1");
                }
                if (indexOfArtistSubstring != -1 && indexOfAlbumSubstring != -1)
                {
                    string artist = directories[i].Substring(0, indexOfArtistSubstring);
                    string album = directories[i].Substring(indexOfArtistSubstring + 3, indexOfAlbumSubstring - indexOfArtistSubstring - 3);
                    int releaseYear = int.Parse(directories[i].Substring(indexOfAlbumSubstring + 2, 4));
                    bool success = DatabaseHelper.AddToDatabase(album, artist, releaseYear, formattedDate);
                    if (!success)
                    {
                        UniqErrorPopup.IsOpen = true;
                        break;
                    }
                }
                else
                {
                    ErrorPopup.IsOpen = true;
                    break;
                }



            }
            SuccessPopUp.IsOpen = true;
            Path.Text = String.Empty;
            AddingDate.SelectedDate = DateTime.Now;
            

        }
        private void ErrorOK_Click(object sender, RoutedEventArgs e)
        {
            ErrorPopup.IsOpen = false;
        }
        private void UniqErrorOK_Click(object sender, RoutedEventArgs e)
        {
            AddingDate.SelectedDate = DateTime.Today;
            UniqErrorPopup.IsOpen = false;
        }
        private void SuccessPopUpOK_Click(object sender, RoutedEventArgs e)
        {
            SuccessPopUp.IsOpen = false;
        }
    }
}

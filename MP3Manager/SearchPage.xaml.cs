using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();

            int currentYear = DateTime.Now.Year;

            for (int year = currentYear; year >= 2014; year--)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = year.ToString();
                Years.Items.Add(item);
            }

            for (int year = currentYear; year >= 1900; year--)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = year.ToString();
                ReleaseYears.Items.Add(item);
            }
        }

        private void ChangePage_MainWindow(object sender, RoutedEventArgs e) {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                AlbumName.Text = string.Empty;
                ArtistName.Text = string.Empty;
                Month_Any.IsSelected = true;
                Year_Any.IsSelected = true;
                ReleaseYear_Any.IsSelected = true;
                mainWindow.Content = mainWindow.mainPage;
            }
        }

        private void SearchForAlbum(object sender, RoutedEventArgs e)
        {
            string albumName = "%" + AlbumName.Text + "%";
            string artistName = "%" + ArtistName.Text + "%";
            ComboBoxItem releaseYear_ = (ComboBoxItem)ReleaseYears.SelectedItem;
            string strreleaseYear = releaseYear_.Content.ToString();
            int releaseYear = 0;
            if(strreleaseYear != "Dowolny")
            {
                releaseYear = int.Parse(strreleaseYear);
            }
            ComboBoxItem strmonth_ = (ComboBoxItem)Months.SelectedItem;
            string strmonth = strmonth_.Content.ToString();
            MonthsENUM selectedMonth = (MonthsENUM)Enum.Parse(typeof(MonthsENUM), strmonth);
            int temp = (int)selectedMonth;
            string monthValue;
            if(temp<10 && temp > 0)
            {
                monthValue = "0";
                monthValue += temp.ToString();
            }
            else
            {
                monthValue = temp.ToString();
            }
            ComboBoxItem Year_ = (ComboBoxItem)Years.SelectedItem;
            string strYear = Year_.Content.ToString();
            if (strYear == "Dowolny")
            {
                strYear = "0";
            }
            List<Album> searchResults = DatabaseHelper.SelectFromDatabase(albumName, artistName, releaseYear, monthValue, strYear, 0);
            if (Window.GetWindow(this) is MainWindow mainWindow && searchResults.Count>0)
            {
                AlbumName.Text = string.Empty;
                ArtistName.Text = string.Empty;
                Month_Any.IsSelected = true;
                Year_Any.IsSelected = true;
                ReleaseYear_Any.IsSelected = true;
                ResultsPage resultsPage = new ResultsPage(searchResults, albumName, artistName, releaseYear, monthValue, strYear, 0);
                mainWindow.Content = resultsPage;
            }
            else
            {
                AlbumName.Text = string.Empty;
                ArtistName.Text = string.Empty;
                Month_Any.IsSelected = true;
                Year_Any.IsSelected = true;
                ReleaseYear_Any.IsSelected = true;
                ErrorPopup.IsOpen = true;
                ErrorPopup.StaysOpen = true;
            }
        }
        private void ErrorOK_Click1(object sender, RoutedEventArgs e)
        {
            //placeholder
            ErrorPopup.IsOpen = false;
        }
    }
}

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
using System.Windows.Controls.Primitives;

namespace MP3Manager
{
    /// <summary>
    /// Logika interakcji dla klasy AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            AddingDate.SelectedDate = DateTime.Today;
            int currentYear = DateTime.Now.Year;

            for (int year = currentYear; year >= 1900; year--)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = year.ToString();
                ReleaseYears.Items.Add(item);
            }
        }

        private void ChangePage_MainWindow(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                AlbumName.Text = string.Empty;
                ArtistName.Text = string.Empty;
                AddingDate.SelectedDate = DateTime.Today;
                ComboBoxItem releaseYear = (ComboBoxItem)ReleaseYears.SelectedItem;
                if (releaseYear != null)
                {
                    releaseYear.IsSelected = false;
                }
                mainWindow.Content = mainWindow.mainPage;
            }
        }

        private void AddDesiredAlbum(object sender, RoutedEventArgs e)
        {
            string albumName = AlbumName.Text;
            string artistName = ArtistName.Text;
            DateTime? addingdate = AddingDate.SelectedDate;
            ComboBoxItem releaseYear_ = (ComboBoxItem)ReleaseYears.SelectedItem;
            string releaseYear = string.Empty;
            if (releaseYear_ != null)
            {
                releaseYear = releaseYear_.Content.ToString();
            }
            if (albumName != "" && artistName != "" && releaseYear != "")
            {
                PopUpText.Text = "Czy jesteś pewien, że chcesz dodać ten album do bazy albumów? " + "\ntytuł: " +
                albumName + "\n autorstwa: " +
                artistName + "\n wydany w roku: " +
                releaseYear + "\n dodany do bazy: " +
                addingdate.Value.ToString("dd-MM-yyyy");
                Confirmation.IsOpen = true;
                Confirmation.StaysOpen = true;
            }
            else
            {
                Confirmation.IsOpen = false;
                ErrorPopup.IsOpen = true;
                ErrorPopup.StaysOpen = true;

            }

        }
        private void ErrorOK_Click(object sender, RoutedEventArgs e)
        {
            ErrorPopup.IsOpen = false;
        }
        private void UniqErrorOK_Click(object sender, RoutedEventArgs e)
        {
            AlbumName.Text = string.Empty;
            ArtistName.Text = string.Empty;
            DateTime? addingdate = DateTime.Today;
            ComboBoxItem releaseYear = (ComboBoxItem)ReleaseYears.SelectedItem;
            if (releaseYear != null)
            {
                releaseYear.IsSelected = false;
            }
            UniqErrorPopup.IsOpen = false;
        }
        private void ConfirmationTrue_Click(object sender, RoutedEventArgs e)
        {
            string albumName = AlbumName.Text;
            string artistName = ArtistName.Text;
            DateTime addingDate = (DateTime) AddingDate.SelectedDate;
            string formattedDate = addingDate.ToString("yyyy-MM-dd");
            ComboBoxItem releaseYear_ = (ComboBoxItem)ReleaseYears.SelectedItem;
            string releaseYear = releaseYear_.Content.ToString();
            int intReleaseYear = int.Parse(releaseYear);
            bool success = DatabaseHelper.AddToDatabase(albumName, artistName, intReleaseYear, formattedDate);
            if (!success)
            {
                Confirmation.IsOpen = false;
                UniqErrorPopup.IsOpen = true;
                UniqErrorPopup.StaysOpen = true;
            }
            Confirmation.IsOpen = false;
        }
        private void ConfirmationFalse_Click(object sender, RoutedEventArgs e)
        {
            Confirmation.IsOpen = false;
        }




        private void ChangePage_AddFromPath(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                AlbumName.Text = string.Empty;
                ArtistName.Text = string.Empty;
                AddingDate.SelectedDate = DateTime.Today;
                ComboBoxItem releaseYear = (ComboBoxItem)ReleaseYears.SelectedItem;
                if (releaseYear != null)
                {
                    releaseYear.IsSelected = false;
                }
                mainWindow.Content = mainWindow.addFromFolderPage;
            }
        }
    }



    
}

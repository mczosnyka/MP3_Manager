using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MP3Manager
{

        
    /// <summary>
    /// Logika interakcji dla klasy ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        private string name_parameter;
        private string artist_parameter;
        private int releaseyear_parameter;
        private string month_parameter;
        private string year_parameter;
        private int filter_index;
        private string to_delete_album;
        private string to_delete_artist;
        public ResultsPage()
        {
            InitializeComponent();
        }

        public ResultsPage(List<Album> search_results, string np, string ap, int rp, string mp, string yp, int fi)
        {
            InitializeComponent();
            Results.ItemsSource = search_results;
            name_parameter = np;
            artist_parameter = ap;
            releaseyear_parameter = rp;
            month_parameter = mp;
            year_parameter = yp;
            filter_index = fi;
        }
        public static T FindAncestor<T>(DependencyObject dependencyObject)
            where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(dependencyObject);

            while (parent != null && !(parent is T))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            return parent as T;
        }
        private void ChangePage_MainWindow(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Content = mainWindow.searchPage;
            }
        }

        private void Display_Filters(object sender, RoutedEventArgs e)
        {
            //placeholder
            FilterListPopup.IsOpen = true;
            FilterListPopup.StaysOpen = true;
        }


        private void ClosePopup(object sender, RoutedEventArgs e)
        {
            FilterListPopup.IsOpen = false;
        }

        private void Filter_Chosen(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                // Get the Tag property of the clicked RadioButton
                string selectedOption = radioButton.Tag?.ToString();
                int filterIndex = int.Parse(selectedOption);
                List<Album> searchResults = DatabaseHelper.SelectFromDatabase(name_parameter, artist_parameter, releaseyear_parameter, month_parameter, year_parameter, filterIndex);
                if (Window.GetWindow(this) is MainWindow mainWindow && searchResults.Count > 0)
                {
                    ResultsPage resultsPage = new ResultsPage(searchResults, name_parameter, artist_parameter, releaseyear_parameter, month_parameter, year_parameter, filterIndex);
                    mainWindow.Content = resultsPage;
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;
            ListViewItem listViewItem = FindAncestor<ListViewItem>(button);
            Album album = listViewItem.DataContext as Album;

            // Now you have access to the properties of the Album object
            // You can use these values to perform your delete operation
            to_delete_album = album.name;
            to_delete_artist = album.artist;
            PopUpText.Text = "Czy jesteś pewien, że chcesz usunąć ten album? " + "\ntytuł: " +
            to_delete_album + "\n autorstwa: " +
            to_delete_artist;
            Confirmation.IsOpen = true;
            Confirmation.StaysOpen = true;
        }

        private void DeleteConfirmation_OK(object sender, RoutedEventArgs e)
        {

            if (Window.GetWindow(this) is MainWindow mainWindow)
            {

                DatabaseHelper.DeleteFromDataBase(to_delete_album, to_delete_artist);
                List<Album> searchResults = DatabaseHelper.SelectFromDatabase(name_parameter, artist_parameter, releaseyear_parameter, month_parameter, year_parameter, filter_index);
                ResultsPage resultsPage = new ResultsPage(searchResults, name_parameter, artist_parameter, releaseyear_parameter, month_parameter, year_parameter, filter_index);
                mainWindow.Content = resultsPage;
            }
        }

        private void DeleteConfirmation_NO(object sender, RoutedEventArgs e)
        {
            Confirmation.IsOpen = false;
        }

    }

}

using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public MainPage mainPage;
        public SearchPage searchPage;
        public AddPage addPage;
        public AddFromFolderPage addFromFolderPage;
        public MainWindow()
        {   
            InitializeComponent();
            mainPage = new MainPage();
            searchPage = new SearchPage();
            addPage = new AddPage();
            addFromFolderPage = new AddFromFolderPage();
            this.Content = mainPage;
        }



    }
}
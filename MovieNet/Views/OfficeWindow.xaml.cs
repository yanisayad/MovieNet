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

namespace MovieNet
{
    /// <summary>
    /// Interaction logic for OfficeWindow.xaml
    /// </summary>
    public partial class OfficeWindow : Page
    {
        public OfficeWindow()
        {
            InitializeComponent();
        }

        private void GoToMovies(object sender, RoutedEventArgs e)
        {
            Movies.Content = new MoviesWindow();
        }

        private void GoToUsers(object sender, RoutedEventArgs e)
        {
            Users.Content = new UsersWindow();
        }
    }
}

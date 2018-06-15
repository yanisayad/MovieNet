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
    /// Interaction logic for MoviesWindow.xaml
    /// </summary>
    public partial class MoviesWindow : Page
    {
        public MoviesWindow()
        {
            InitializeComponent();
        }

        private void GoToOffice(object sender, RoutedEventArgs e)
        {
            Office.Content = new OfficeWindow();
        }

        private void GoToUsers(object sender, RoutedEventArgs e)
        {
            Users.Content = new UsersWindow();
        }

   
    }
}

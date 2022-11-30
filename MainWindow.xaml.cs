using System.Windows;
using System.Windows.Controls;

namespace CheckboxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imuno.Visibility= Visibility.Collapsed;
            imdos.Visibility = Visibility.Collapsed;
            imtres.Visibility = Visibility.Collapsed;
        }
        private void evento_Checked(object sender, RoutedEventArgs e)
        {
            imuno.Visibility = Visibility.Collapsed;
            imdos.Visibility = Visibility.Collapsed;
            imtres.Visibility = Visibility.Collapsed;
            cball.IsChecked = null;
            if ((cbuno.IsChecked == true) && (cbdos.IsChecked == true) && (cbtres.IsChecked == true))
            {
                cball.IsChecked= true;
            }
            if ((cbuno.IsChecked == false) && (cbdos.IsChecked == false) && (cbtres.IsChecked == false))
            {
                cball.IsChecked = false;
            }
            if (cbuno.IsChecked == true)
            {
                imuno.Visibility = Visibility.Visible;
            }
            if (cbdos.IsChecked == true)
            {
                imdos.Visibility = Visibility.Visible;
            }
            if (cbtres.IsChecked == true)
            {
                imtres.Visibility = Visibility.Visible;
            }
        }
        private void evento_all_Checked(object sender, RoutedEventArgs e)
        {
            bool bandera = (cball.IsChecked == true);
            cbuno.IsChecked = bandera;
            cbdos.IsChecked = bandera;
            cbtres.IsChecked = bandera;
        }
    }
}

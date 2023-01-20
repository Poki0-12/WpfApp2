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
using WpfApp2.Pages;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Navigate(new Pages.Start());

        }

        private void SetBtn_Click(object sender, RoutedEventArgs e)
        {
            var first = new SettingsWindow();
            SettingsWindow second = new SettingsWindow();
            first.Background = new SolidColorBrush(Color.FromRgb(255,0,0));
            second.Show();
        }

        private void GrBtn_Click(object sender, RoutedEventArgs e)
        {
            var p = new Pages.Group();
            MyFrame.Navigate(p);
        }

        private void Stud_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Pages.Student());
        }

        private void courBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.GoBack();
            if (MyFrame.CanGoBack)
                MyFrame.GoBack();
        }

        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.GoForward();
            if (MyFrame.CanGoForward)
                MyFrame.GoForward();
        }
    }
}

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

namespace WpfRadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void radioButtonRojo_Click(object sender, RoutedEventArgs e)
        {
            rojoEllipse.Visibility = Visibility;
            amarilloEliipse.Visibility = Visibility.Hidden;
            verdeEllipse.Visibility = Visibility.Hidden;


        }

        private void radioButtonMarillo_Click(object sender, RoutedEventArgs e)
        {
            amarilloEliipse.Visibility = Visibility;
            rojoEllipse.Visibility = Visibility.Hidden;
            verdeEllipse.Visibility = Visibility.Hidden;

        }

        private void radioButtonVerde_Click(object sender, RoutedEventArgs e)
        {
            verdeEllipse.Visibility = Visibility;
            amarilloEliipse.Visibility = Visibility.Hidden;
            rojoEllipse.Visibility = Visibility.Hidden;

        }
    }
}

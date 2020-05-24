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

namespace WpfComboBoxAndCheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capital> ListaCapitales = new List<Capital>() 
            {
                new Capital{ NombreCApital = "Madrid" },
                new Capital{ NombreCApital = "Bogotá" },
                new Capital{ NombreCApital = "DF" },
                new Capital{ NombreCApital = "London" },
                new Capital{ NombreCApital = "Berlin" },
            };

            CapitalesComboBox.ItemsSource = ListaCapitales;
        }

        private void TodasCApitales_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogotá.IsChecked = true;
            DF.IsChecked = true;
            London.IsChecked = true;
            Berlin.IsChecked = true;
            
        }

        private void TodasCApitales_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogotá.IsChecked = false;
            DF.IsChecked     = false;
            London.IsChecked = false;
            Berlin.IsChecked = false;
        }

        private void IndividualChecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Bogotá.IsChecked == true && DF.IsChecked == true && DF.IsChecked == true && London.IsChecked == true&& Berlin.IsChecked == true)
            {
                TodasCApitales.IsChecked = true;
            }
            else if(Madrid.IsChecked == false && Bogotá.IsChecked == false && DF.IsChecked == false && DF.IsChecked == false && London.IsChecked == false && Berlin.IsChecked == false)
            {
                TodasCApitales.IsChecked = false;

            }
            else
            {
                TodasCApitales.IsChecked = null;
            }
        }
    }
}

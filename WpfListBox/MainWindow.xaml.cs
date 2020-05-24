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

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPoblacionesList = new List<Poblaciones>()
            {
              new Poblaciones{ Poblacion1 = "Londres", Poblacion2 = "Madrid", Temperatura1 = 15, Temperatura2 = 1, DiferenciaTemperature = 14 },
              new Poblaciones{ Poblacion1 = "Oslo", Poblacion2 = "Sevilla", Temperatura1 = 8, Temperatura2 = 27 , DiferenciaTemperature = 21},
              new Poblaciones{ Poblacion1 = "Berlin", Poblacion2 = "Valencia", Temperatura1 = 12, Temperatura2 = 22 , DiferenciaTemperature = 10},
              new Poblaciones{ Poblacion1 = "Medellín", Poblacion2 = "Manchester", Temperatura1 = 25, Temperatura2 = 10,  DiferenciaTemperature = 15},
              
            };

            ListaPoblacionesListBox.ItemsSource = listaPoblacionesList;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (ListaPoblacionesListBox.SelectedItem != null)
            {
                MessageBox.Show($"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Poblacion1} - " +
                                   $"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Temperatura1} ªC  " +
                                   $"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Poblacion2} - " +
                                   $"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Temperatura2} ªC "); 
            }
            else
            {
                MessageBox.Show("Please, Select a data from the List.");
                return;
            }

        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblacionesListBox.SelectedItem != null)
            {
                MessageBox.Show($"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Poblacion1} - " +
                                   $"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Temperatura1} ªC  " +
                                   $"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Poblacion2} - " +
                                   $"{(ListaPoblacionesListBox.SelectedItem as Poblaciones).Temperatura2} ªC ");
            }
            else
            {
                MessageBox.Show("Please, Select a data from the List.");

            }

        }

        private void ListaPoblacionesListBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
           

        }
    }
}

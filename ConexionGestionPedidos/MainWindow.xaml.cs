using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);

            MostrarClientes();

        }

        private void MostrarClientes()
        {
            string consulta = "Select * From Cliente";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable clinetesDataTable = new DataTable();
                miAdaptadorSql.Fill(clinetesDataTable);
                ListaclientesListBox.DisplayMemberPath = "Nombre";
                ListaclientesListBox.SelectedValuePath = "Id";
                ListaclientesListBox.ItemsSource = clinetesDataTable.DefaultView;
            }
        }
    }
}

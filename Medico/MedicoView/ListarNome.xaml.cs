using Controller;
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
using System.Windows.Shapes;

namespace MedicoView
{
    /// <summary>
    /// Interaction logic for ListarNome.xaml
    /// </summary>
    public partial class ListarNome : Window
    {
        public ListarNome()
        {
            InitializeComponent();
        }

        private void btnNome_Click(object sender, RoutedEventArgs e)
        {
            MedicoController medicoController = new MedicoController();
            string nome = txtNome.Text;
            dgMedicosNome.ItemsSource = medicoController.ListarPorNome(nome);

        }
    }
}

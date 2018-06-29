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
    /// Interaction logic for ListarMedicos.xaml
    /// </summary>
    public partial class ListarMedicos : Window
    {
        public ListarMedicos()
        {
            InitializeComponent();
        }

        private void btnCRM_Click(object sender, RoutedEventArgs e)
        {
            ListarCRM crm = new ListarCRM();
            crm.Show();
        }

        private void btnNome_Click(object sender, RoutedEventArgs e)
        {
            ListarNome nome = new ListarNome();
            nome.Show();
        }

        private void btnEspecialidade_Click(object sender, RoutedEventArgs e)
        {
            ListarEspecialidade especialidade = new ListarEspecialidade();
            especialidade.Show();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

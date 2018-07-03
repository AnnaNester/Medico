using Controller;
using Model;
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
    /// Interaction logic for ListarCRM.xaml
    /// </summary>
    public partial class ListarCRM : Window
    {
        private Medico med;
        public ListarCRM()
        {
            InitializeComponent();
            txtEndereco.IsEnabled = false;
            txtEspecialidade.IsEnabled = false;
            txtNome.IsEnabled = false;
        }

        private void btnCRM_Click(object sender, RoutedEventArgs e)
        {
            MedicoController medicoController = new MedicoController();
            string crm = txtCRM.Text;
            dgMedicosCRM.ItemsSource = medicoController.ListarPorCRM(crm);

            med = medicoController.BuscarPorCRM(crm);

            try
            {
                txtNome.Text = med.nome;
                txtEspecialidade.Text = med.especialidade;
                txtEndereco.Text = med.endereco;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário não existe");
            }

            btnSalvar.Visibility = Visibility.Collapsed;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            MedicoController medicoController = new MedicoController();
            string crm = txtCRM.Text;
            if (medicoController.Excluir(crm))
            MessageBox.Show("Cadastro Excluído com Sucesso!");
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            txtEndereco.IsEnabled = true;
            txtEspecialidade.IsEnabled = true;
            txtNome.IsEnabled = true;
            btnSalvar.Visibility = Visibility.Visible;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            med.nome = txtNome.Text;
            med.especialidade = txtEspecialidade.Text;
            med.endereco = txtEndereco.Text;
            MedicoController medicoController = new MedicoController();
            medicoController.Atualizar(med);
            MessageBox.Show("Alterado!");
        }
    }
}

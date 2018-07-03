using Controller;
using Model;
using System;
using System.Windows;

namespace MedicoView
{
    /// <summary>
    /// Interaction logic for CadastroMedico.xaml
    /// </summary>
    public partial class CadastroMedico : Window
    {
        public CadastroMedico()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medico med = new Medico();

                med.crm = txtCRM.Text;
                med.nome = txtNome.Text;
                med.endereco = txtEndereco.Text;
                med.especialidade = txtEspecialidade.Text;

                MedicoController medicoController = new MedicoController();

                if (medicoController.BuscarPorCRM(med.crm) == null)
                {
                    medicoController.Cadastro(med);

                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Médico já cadastrado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário!");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

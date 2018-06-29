using Controller;
using System.Windows;

namespace MedicoView
{
    /// <summary>
    /// Interaction logic for ListarEspecialidade.xaml
    /// </summary>
    public partial class ListarEspecialidade : Window
    {
        public ListarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnEspecialidade_Click(object sender, RoutedEventArgs e)
        {
            MedicoController medicoController = new MedicoController();
            string especialidade = txtEspecialidade.Text;
            dgMedicosEspecialidade.ItemsSource = medicoController.ListarPorEspecialidade(especialidade);
        }
    }
}

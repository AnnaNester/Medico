using System.Windows;

namespace MedicoView
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

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {
            CadastroMedico cadmed = new CadastroMedico();
            cadmed.Show();
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            ListarMedicos listarmed = new ListarMedicos();
            listarmed.Show();
        }
    }
}

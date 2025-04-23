using Prova23_04_2025.Views;

namespace Prova23_04_2025
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CadastroGerenciamentoProdutoView), typeof(CadastroGerenciamentoProdutoView));
            Routing.RegisterRoute(nameof(BuscaVisualizacaoProdutosView), typeof(BuscaVisualizacaoProdutosView));
            Routing.RegisterRoute(nameof(ProdutosView), typeof (ProdutosView));
            Routing.RegisterRoute(nameof(RegistroDeAvaliacaoView), typeof (RegistroDeAvaliacaoView));
        }
    }
}

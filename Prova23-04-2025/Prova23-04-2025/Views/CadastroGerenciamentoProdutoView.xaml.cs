using Prova23_04_2025.ViewModels;

namespace Prova23_04_2025.Views;

public partial class CadastroGerenciamentoProdutoView : ContentPage
{
	public CadastroGerenciamentoProdutoView()
	{
		InitializeComponent();
		BindingContext = new CadastroGerenciamentoProdutoViewModel();
	}
}
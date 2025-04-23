using Prova23_04_2025.ViewModels;

namespace Prova23_04_2025.Views;

public partial class BuscaVisualizacaoProdutosView : ContentPage
{
	public BuscaVisualizacaoProdutosView()
	{
		InitializeComponent();
		BindingContext = new BuscaVisualizacaoProdutosViewModel();
	}
}
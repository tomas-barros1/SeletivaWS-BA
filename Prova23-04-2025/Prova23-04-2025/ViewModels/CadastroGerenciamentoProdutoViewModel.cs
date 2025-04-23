using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prova23_04_2025.Models;
using Prova23_04_2025.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova23_04_2025.ViewModels
{
    public partial class CadastroGerenciamentoProdutoViewModel : ObservableObject
    {
        public ObservableCollection<Produto> Produtos { get; } = new();

        [ObservableProperty]
        string nome;

        [ObservableProperty]
        string categoria;

        [ObservableProperty]
        string subcategoria;

        [ObservableProperty]
        string nomeEmpresaFabricante;

        [ObservableProperty]
        string codigoProduto;

        [ObservableProperty]
        string descricao;

        [ObservableProperty]
        decimal precoSugerido;

        [RelayCommand]
        public async void CadastrarProduto()
        {
            try
            {
                var produto = new Produto()
                {
                    Categoria = Categoria,
                    Subcategoria = Subcategoria,
                    Nome = Nome,
                    PrecoSugerido = PrecoSugerido,
                    Descricao = Descricao,
                    CodigoProduto = CodigoProduto,
                    NomeEmpresaFabricante = NomeEmpresaFabricante,
                };

                Produtos.Add(produto);
                await Shell.Current.DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "Ok");
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Erro", $"Algo inesperado aconteceu! {e.Message}", "Ok");
            }
        }

        [RelayCommand]
        public async void IrParaBusca()
        {
            await Shell.Current.GoToAsync(nameof(BuscaVisualizacaoProdutosView), true, new Dictionary<string, object>
            {
                { "Produtos", Produtos } 
            });
        }

        [RelayCommand]
        public async void IrParaProdutoDetalhe(Produto p)
        {
            if (p == null)
                return;

            await Shell.Current.GoToAsync(nameof(ProdutosView), true, new Dictionary<string, object>
            {
                 {"Produto", p}
            });
        }
    }
}

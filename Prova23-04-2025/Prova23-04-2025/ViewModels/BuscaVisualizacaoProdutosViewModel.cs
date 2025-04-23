using CommunityToolkit.Mvvm.ComponentModel;
using Prova23_04_2025.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova23_04_2025.ViewModels
{
    [QueryProperty("Produtos", "Produtos")]
    public class BuscaVisualizacaoProdutosViewModel:ObservableObject
    {
       public ObservableCollection<Produto> Produtos;
    }
}

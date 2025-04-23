using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova23_04_2025.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string NomeEmpresaFabricante { get; set; }
        public string CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoSugerido{ get; set; }
        public List<Avaliacao> Avaliacoes = new List<Avaliacao>();
    }
}

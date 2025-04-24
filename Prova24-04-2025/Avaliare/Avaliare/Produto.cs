using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliare
{
    public class Produto
    {
        public int id_produto { get; set; }
        public int id_representante { get; set; }
        public int id_categoria { get; set; }
        public int id_subcategoria { get; set; }
        public string nome_produto { get; set; }
        public string nome_fabricante { get; set; }
        public string codigo_de_barras { get; set; }
        public decimal preco_sugerido { get; set; }
        public string descricao_produto { get; set; }
    }
}

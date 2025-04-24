using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliare
{
    public partial class Busca : Form
    {
        public SqlConnection conn = new SqlConnection();

        public Busca()
        {
            InitializeComponent();
            conn.ConnectionString = "Server=C303-REP-04\\TEW_SQLEXPRESS;Database=Avaliare;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";
            conn.Open();
        }

        public List<Produto> BuscarProduto()
        {
            List<Produto> lista = new List<Produto>();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_produtos WHERE nome_produto = @nome_produto", conn);

                cmd.Parameters.Add(new SqlParameter("@nome_produto", nome_produto.Text));

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lista.Add(new Produto()
                    {
                        id_produto = rdr.GetInt32(0),
                        id_representante = rdr.GetInt32(1),
                        id_categoria = rdr.GetInt32(2),
                        id_subcategoria = rdr.GetInt32(3),
                        nome_produto = rdr.GetString(4),
                        nome_fabricante = rdr.GetString(5),
                        codigo_de_barras = rdr.GetString(6),
                        preco_sugerido = rdr.GetDecimal(7),
                        descricao_produto = rdr.GetString(8),
                    });
                }
                dataGridView1.DataSource = lista;
                return lista;
            }
        }

        private void nome_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }
    }
}

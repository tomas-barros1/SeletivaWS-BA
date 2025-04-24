using Microsoft.Data.SqlClient;

namespace Avaliare
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Server=C303-REP-04\\TEW_SQLEXPRESS;Database=Avaliare;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";
            conn.Open();
            LerProdutos();
        }

        public void CriarProduto()
        {
            conn.ConnectionString = "Server=C303-REP-04\\TEW_SQLEXPRESS;Database=Avaliare;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tb_produtos (id_representante, id_categoria, id_subcategoria, nome_produto, nome_fabricante, codigo_barras, preco_sugerido, descricao_produto) VALUES (1, @id_categoria, @id_subcategoria, @nome_produto, @nome_fabricante, @codigo_barras, @preco_sugerido, @descricao_produto)", conn);

                cmd.Parameters.Add(new SqlParameter("@nome_produto", nome_produto.Text));
                cmd.Parameters.Add(new SqlParameter("@id_categoria", fk_categoria.Text));
                cmd.Parameters.Add(new SqlParameter("@id_subcategoria", fk_subcategoria.Text));
                cmd.Parameters.Add(new SqlParameter("@nome_fabricante", nome_fabricante.Text));
                cmd.Parameters.Add(new SqlParameter("@codigo_barras", codigo_de_barras.Text));
                cmd.Parameters.Add(new SqlParameter("@preco_sugerido", preco_sugerido.Text));
                cmd.Parameters.Add(new SqlParameter("@descricao_produto", descricao_produto.Text));
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cadastrou com sucesso!");
                    LerProdutos();
                }
            }
        }

        public List<Produto> LerProdutos()
        {
            List<Produto> lista = new List<Produto>();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_produtos", conn);


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
                conn.Close();
                return lista;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarProduto();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Busca().Show();
        }
    }
}

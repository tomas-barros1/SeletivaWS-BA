namespace Avaliare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nome_produto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nome_fabricante = new TextBox();
            label3 = new Label();
            codigo_de_barras = new TextBox();
            label4 = new Label();
            preco_sugerido = new TextBox();
            label5 = new Label();
            descricao_produto = new TextBox();
            button1 = new Button();
            label6 = new Label();
            fk_categoria = new TextBox();
            fk_subcategoria = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nome_produto
            // 
            nome_produto.Location = new Point(12, 33);
            nome_produto.Name = "nome_produto";
            nome_produto.Size = new Size(103, 23);
            nome_produto.TabIndex = 0;
            nome_produto.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do produto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do fabricante";
            // 
            // nome_fabricante
            // 
            nome_fabricante.Location = new Point(12, 101);
            nome_fabricante.Name = "nome_fabricante";
            nome_fabricante.Size = new Size(103, 23);
            nome_fabricante.TabIndex = 2;
            nome_fabricante.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Código de barras";
            // 
            // codigo_de_barras
            // 
            codigo_de_barras.Location = new Point(12, 181);
            codigo_de_barras.Name = "codigo_de_barras";
            codigo_de_barras.Size = new Size(103, 23);
            codigo_de_barras.TabIndex = 4;
            codigo_de_barras.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 223);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Preço sugerido";
            // 
            // preco_sugerido
            // 
            preco_sugerido.Location = new Point(12, 256);
            preco_sugerido.Name = "preco_sugerido";
            preco_sugerido.Size = new Size(103, 23);
            preco_sugerido.TabIndex = 6;
            preco_sugerido.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 310);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 9;
            label5.Text = "Descrição produto";
            // 
            // descricao_produto
            // 
            descricao_produto.Location = new Point(12, 334);
            descricao_produto.Name = "descricao_produto";
            descricao_produto.Size = new Size(103, 23);
            descricao_produto.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(23, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 9);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "Fk categoria";
            // 
            // fk_categoria
            // 
            fk_categoria.Location = new Point(138, 27);
            fk_categoria.Name = "fk_categoria";
            fk_categoria.Size = new Size(103, 23);
            fk_categoria.TabIndex = 12;
            fk_categoria.TextChanged += textBox1_TextChanged_1;
            // 
            // fk_subcategoria
            // 
            fk_subcategoria.Location = new Point(138, 95);
            fk_subcategoria.Name = "fk_subcategoria";
            fk_subcategoria.Size = new Size(103, 23);
            fk_subcategoria.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 77);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 13;
            label7.Text = "Fk subcategoria";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 373);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button2
            // 
            button2.Location = new Point(138, 372);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 16;
            button2.Text = "Ir para busca";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 494);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(fk_subcategoria);
            Controls.Add(label7);
            Controls.Add(fk_categoria);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(descricao_produto);
            Controls.Add(label4);
            Controls.Add(preco_sugerido);
            Controls.Add(label3);
            Controls.Add(codigo_de_barras);
            Controls.Add(label2);
            Controls.Add(nome_fabricante);
            Controls.Add(label1);
            Controls.Add(nome_produto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome_produto;
        private Label label1;
        private Label label2;
        private TextBox nome_fabricante;
        private Label label3;
        private TextBox codigo_de_barras;
        private Label label4;
        private TextBox preco_sugerido;
        private Label label5;
        private TextBox descricao_produto;
        private Button button1;
        private Label label6;
        private TextBox fk_categoria;
        private TextBox fk_subcategoria;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button2;
    }
}

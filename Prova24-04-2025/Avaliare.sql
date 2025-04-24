CREATE TABLE tb_usuarios(
	id_usuario INT PRIMARY KEY IDENTITY(1,1) ,
	nome varchar(50),
	email varchar(50),
	tipo_usuario VARCHAR(30) NOT NULL,
	CHECK (tipo_usuario IN ('avaliador', 'representante'))
);

CREATE TABLE tb_categorias(
	id_categoria INT PRIMARY KEY IDENTITY(1,1),
	nome_categoria varchar(50) UNIQUE,
);

CREATE TABLE tb_subcategorias(
	id_subcategoria INT PRIMARY KEY IDENTITY(1,1),
	id_categoria INT,
	FOREIGN KEY(id_categoria) REFERENCES tb_categorias(id_categoria),
	nome_subcategoria varchar(50) UNIQUE
);

CREATE TABLE tb_produtos(
	id_produto INT PRIMARY KEY IDENTITY(1,1),
	id_representante INT,
	FOREIGN KEY(id_representante) REFERENCES tb_usuarios(id_usuario),
	id_categoria INT,
	FOREIGN KEY(id_categoria) REFERENCES tb_categorias(id_categoria),
	id_subcategoria INT,
	FOREIGN KEY(id_subcategoria) REFERENCES tb_subcategorias(id_subcategoria),
	nome_produto VARCHAR(255),
	nome_fabricante VARCHAR(100),
	codigo_barras VARCHAR(13) UNIQUE,
	preco_sugerido DECIMAL(10,2),
	descricao_produto TEXT
);

CREATE TABLE tb_criterios(
	id_criterio INT PRIMARY KEY IDENTITY(1,1),
	nome_criterio VARCHAR(100) UNIQUE,
);

CREATE TABLE tb_avaliacoes(
	id_avaliacao INT PRIMARY KEY IDENTITY(1,1),
	id_avaliador INT,
	id_produto INT,
	FOREIGN KEY(id_avaliador) REFERENCES tb_usuarios(id_usuario),
	FOREIGN KEY (id_produto) REFERENCES tb_produtos(id_produto)
);

CREATE TABLE tb_notas_avaliacoes(
	id_notas_avaliacoes INT PRIMARY KEY IDENTITY(1,1),
	id_avaliacao INT,
	FOREIGN KEY(id_avaliacao) REFERENCES tb_avaliacoes(id_avaliacao),
	id_criterio INT,
	FOREIGN KEY(id_criterio) REFERENCES tb_criterios(id_criterio),
	nota DECIMAL(3,1)
);

CREATE TABLE tb_replicas(
	id_replica INT PRIMARY KEY IDENTITY(1,1),
	id_avaliacao INT,
	FOREIGN KEY(id_avaliacao) REFERENCES tb_avaliacoes(id_avaliacao),
	id_representante INT,
	FOREIGN KEY(id_representante) REFERENCES tb_usuarios(id_usuario),
	texto_replica TEXT,
	data_replica DATETIME
);

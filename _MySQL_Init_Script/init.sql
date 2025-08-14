-- Cria o banco de dados
CREATE DATABASE IF NOT EXISTS produtosdb CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Seleciona o banco de dados
USE produtosdb;

-- Remove a tabela caso exista
DROP TABLE IF EXISTS Produtos;

-- Cria a tabela Produtos
CREATE TABLE Produtos (
    ProdutoId INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(80) NOT NULL,
    Categoria VARCHAR(50) NOT NULL,
    Preco DECIMAL(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insere os registros na tabela
INSERT INTO Produtos (Nome, Categoria, Preco) VALUES
('Caneta', 'Material Escolar', 6.50),
('Estojo', 'Material Escolar', 3.40),
('Borracha', 'Material Escolar', 2.50);
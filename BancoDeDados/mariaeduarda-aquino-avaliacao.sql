-- criacao das tables
CREATE TABLE IF NOT EXISTS produto (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL, 
categoria VARCHAR(100) NOT NULL,
preco DECIMAL(10,2) NOT NULL,
estoque INT NOT NULL, 
fornecedor_id INT NOT NULL);  

CREATE TABLE IF NOT EXISTS fornecedor (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
cidade VARCHAR(100) NOT NULL);

CREATE TABLE IF NOT EXISTS pedido (
id INT PRIMARY KEY AUTO_INCREMENT,
produto_id INT NOT NULL, 
quantidade INT NOT NULL,
data_pedido DATE NOT NULL,
cliente_id INT NOT NULL);  

CREATE TABLE IF NOT EXISTS cliente (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL, 
cidade VARCHAR(100) NOT NULL,
idade int NOT NULL);
-- tables criadas 

-- insercao de dados nas tables 

-- inserir dados na tabela 'produto'
INSERT INTO produto (id, nome, categoria, preco, estoque, fornecedor_id) VALUES
(1, 'Celular X', 'Eletrônicos', 2500.00, 30, 1),
(2, 'Notebook Y', 'Eletrônicos', 4800.00, 15, 2),
(3, 'Mesa de Madeira', 'Móveis', 750.00, 10, 3),
(4, 'Cadeira Z', 'Móveis', 300.00, 25, 3),
(5, 'TV 50"', 'Eletrônicos', 3500.00, 8, 1);

-- inserir dados na tabela 'fornecedor'
INSERT INTO fornecedor (id, nome, cidade) VALUES
(1, 'TechBrasil', 'São Paulo'),
(2, 'Computech', 'Rio de Janeiro'),
(3, 'Moveis&Co', 'Curitiba');

-- inserir dados na tabela 'pedido'
INSERT INTO pedido (id, produto_id, quantidade, data_pedido, cliente_id) VALUES
(1, 1, 2, '2024-03-10', 1),
(2, 3, 1, '2024-03-11', 2),
(3, 2, 1, '2024-03-15', 3),
(4, 5, 3, '2024-03-18', 1),
(5, 4, 4, '2024-03-20', 4);

-- inserir dados na tabela 'cliente'
INSERT INTO cliente (id, nome, cidade, idade) VALUES
(1, 'João Silva', 'São Paulo', 35),
(2, 'Maria Santos', 'Belo Horizonte', 28),
(3, 'Carlos Lima', 'Rio de Janeiro', 42),
(4, 'Fernanda Rocha', 'Curitiba', 30);

-- iniciacao de exercicios

-- ex01 
SELECT 
    nome, preco
FROM
    produto
WHERE
    categoria = 'Eletrônicos'
        AND preco > 3000
ORDER BY preco DESC;
-- task 1 ok
SELECT 
    nome, cidade, idade
FROM
    cliente
WHERE
    cidade != 'São Paulo' AND idade > 30;
-- task 2 ok
SELECT 
    id, produto_id, quantidade, data_pedido, cliente_id
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;
-- task 3 ok
SELECT 
    nome, estoque
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque ASC;
-- task 4 ok
SELECT 
    nome, cidade
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro'
        AND nome LIKE 'T%';
-- task 5 ok

-- ex 02

SELECT 
    categoria, AVG(preco) AS preco_medio
FROM
    produto
GROUP BY categoria;
-- task 1 ok
SELECT 
    cliente_id, COUNT(*) AS total_pedidos
FROM
    pedido
GROUP BY cliente_id;
-- task 2 ok
SELECT 
    categoria, SUM(estoque) AS total_estoque
FROM
    produto
GROUP BY categoria;
-- tsak 3 ok
SELECT 
    id, produto_id, quantidade
FROM
    pedido
ORDER BY quantidade DESC
LIMIT 1;
-- task 4 ok
SELECT 
    cidade, COUNT(*) AS total_clientes
FROM
    cliente
GROUP BY cidade
ORDER BY total_clientes DESC;
-- task 5 ok

-- ex 03 

SELECT 
    produto.nome AS produto, fornecedor.nome AS fornecedor
FROM
    produto
        INNER JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id
ORDER BY fornecedor.nome;
-- task 1 ok
SELECT 
    pedido.id, cliente.nome AS cliente, produto.nome AS produto
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
ORDER BY pedido.data_pedido;
-- task 2 ok
SELECT 
    cliente.nome AS cliente,
    produto.nome AS produto,
    fornecedor.nome AS fornecedor
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
        INNER JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id;
-- task 3 ok
SELECT 
    cliente.nome AS cliente,
    SUM(pedido.quantidade) AS total_comprado
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
GROUP BY cliente.nome;
-- task 4 ok

-- ex 04

SELECT nome, categoria, preco 
FROM produto 
WHERE preco > (SELECT AVG(preco) FROM produto WHERE produto.categoria = categoria);
-- task 1 ok
UPDATE produto 
SET 
    preco = preco * 1.10
WHERE
    categoria = 'Eletrônicos';
-- task 2 ok
DELETE FROM pedido
WHERE cliente_id IN (SELECT id FROM cliente WHERE cidade = 'Curitiba');
-- task 3 ok
INSERT INTO cliente (nome, cidade, idade) 
VALUES ('Ricardo Lopes', 'Porto Alegre', 38);
-- task 4 ok
INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) 
VALUES (2, 2, '2024-03-25', 1);
-- task 5 ok
SELECT DISTINCT
    cliente.nome
FROM
    pedido
        INNER JOIN
    produto ON pedido.produto_id = produto.id
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
WHERE
    produto.categoria = 'Móveis'
-- task 6 ok


-- ex01
CREATE TABLE IF NOT EXISTS cliente (
id int primary key auto_increment,
nome varchar(100) not null, 
idade int not null,
cidade varchar(100) not null, 
saldo decimal (10,2) not null);

INSERT INTO cliente ( nome, idade, cidade, saldo )
VALUES
( 'Carlos', '45', 'São Paulo', '2500.00' ), 
( 'Mariana', '32', 'Rio de Janeiro', '3200.50' ),
( 'Pedro', '27', 'Belo Horizonte', '1500.75' ),
( 'Fernanda', '38', 'Curitiba', '4200.00' ); 

SELECT 
* 
FROM cliente
WHERE 
cliente.cidade = 'Rio de Janeiro';
-- task 1 ok

SELECT 
    *
FROM
    cliente
WHERE 
saldo >  2000
ORDER BY saldo DESC; 
-- task 2 ok

SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade > 30; 
-- task 3 ok

-- ex02
SELECT 
    *
FROM
    cliente
WHERE
    idade BETWEEN 25 AND 40;
-- task 1 ok
SELECT *
FROM cliente
WHERE nome LIKE 'F%'; 
-- task 2 ok 
SELECT *
FROM cliente
WHERE cidade NOT IN ('São Paulo', 'Curitiba');
-- task 3 ok

-- ex03
CREATE TABLE IF NOT EXISTS pedido (
id int primary key auto_increment, 
cliente_id int not null,
valor decimal(8,2) not null,
data_pedido date not null);

INSERT INTO pedido (cliente_id, valor, data_pedido)
VALUES 
( '1', '500.00', '2024-03-10'),
( '2', '1200.00', '2024-03-12'),
( '3', '300.50', '2024-03-15'),
( '1', '800.00', '2024-03-18');

SELECT 
    COUNT(*) AS total_pedido
FROM
    pedido;
-- task 1 ok
SELECT 
    AVG(valor) AS media_valor
FROM
    pedido;
-- task 2 ok 
SELECT 
    cliente_id, SUM(valor) AS total_gasto
FROM
    pedido
GROUP BY cliente_id;
-- task 3 ok

-- ex 04
DROP TABLE cliente;
DROP TABLE pedido; 

CREATE TABLE IF NOT EXISTS cliente (
id int primary key auto_increment,
nome VARCHAR(100) NOT NULL, 
cidade VARCHAR(100) NOT NULL);

INSERT INTO cliente (nome, cidade)
VALUES 
('Carlos', 'São Paulo'),
('Mariana', 'Rio de Janeiro'),
('Pedro', 'Belo Horizonte'),
('Fernanda', 'Curitiba');
-- table cliente criada

CREATE TABLE IF NOT EXISTS pedido (
id int primary key auto_increment, 
cliente_id int not null,
valor decimal (10,2) not null);

INSERT INTO pedido (cliente_id, valor) 
VALUES 
('1', '500.00'),
('2', '1200.00'),
('3', '300.50'), 
('1', '800.00');
-- table pedido criada 

SELECT 
    pedido.id AS pedido_id,
    pedido.valor,
    cliente.nome AS cliente_nome,
    cliente.cidade
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id;
-- task 1 ok 

SELECT 
    cliente.nome AS cliente_nome,
    cliente.cidade,
    pedido.valor AS pedido_valor
FROM
    cliente
        LEFT JOIN
    pedido ON cliente.id = pedido.cliente_id;
-- task 2 ok

-- ex 05
SELECT 
    cliente.nome AS cliente_nome, pedido.valor AS pedido_valor
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
WHERE
    pedido.valor > (SELECT 
            AVG(valor)
        FROM
            pedido);
-- task 1 ok

SELECT DISTINCT
    cliente.nome AS cliente_nome, cliente.cidade
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
WHERE
    pedido.valor > 1000;
-- task 2 ok

-- ex 06
INSERT INTO cliente (
 nome,
 cidade
) 
VALUES ( ' Rafael ', ' Porto Alegre ' ); 

SELECT 
    *
FROM
    cliente;
-- task 1 ok

UPDATE pedido 
SET 
    valor = valor + (valor * 0.10 );
-- task 2 

DELETE FROM pedido
where valor < 500.00
-- task 3 


CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);

INSERT INTO cliente (nome, nome_social,data_nascimento,email,telefone,tipo,etnia,genero,estrangeiro,id_endereco)
VALUES 
('Rayane Lima',NULL, '04-05-26', 'ray.ane@email.com','11940028922',0,0,0,0, (SELECT id FROM endereco WHERE logradouro = "Endereco do Rafael"));

INSERT INTO cliente (nome, nome_social,data_nascimento,email,telefone,tipo,etnia,genero,estrangeiro,id_endereco)
VALUES 
('Viviane Oliveira',NULL,'18031985','vivi.oli@email.com','11948555899',0,0,0,0, (SELECT id FROM endereco WHERE logradouro = 'Endereco dos pais do rafael'));


SELECT 
    *
FROM
    cliente
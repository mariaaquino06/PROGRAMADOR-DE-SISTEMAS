CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
insert into usuario (
nome, 
email, 
senha
) 
VALUES (
'eduarda aquino', 
'eduarda.aquino@email.com', 
'Senha@123'
); 
INSERT INTO usuario (
nome, 
email, 
senha
) 
VALUES 
('Neymar Jr', 'neymar.junior@email.com', 'Bruna@2'),
('Maria Madalena', 'madalena@email.com', 'a1s2d3f4!'),
('Pablo Vittar,´pablo.vittar@email.com', 'Senh@Fort3');
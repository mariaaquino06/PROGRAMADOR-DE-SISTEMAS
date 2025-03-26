CREATE table IF NOT EXISTS testeAtividade 
(
id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
cargo VARCHAR(100) NOT NULL,
salario VARCHAR(50) NOT NULL,
beneficios VARCHAR(50) NOT NULL,
localidade VARCHAR(50) NOT NULL
);
SELECT 
    *
FROM
    testeAtividade;
    
insert INTO testeAtividade ( cargo, salario, beneficios, localidade)
VALUES 
( 'Assistente Jurídico', 'R$2.100,00', 'VR,VT e Seguro de vida','São Paulo'),
('Analista de Dados', 'R$4.100,00', 'VR,VT,Seguro de vida,GymPass','Rio de Janeiro'),
('Engenheiro de Software', 'R$10.100,00', 'VA,VT,Convênio,GymPass','Espírito Santo'),
('Auxiliar Admnistrativo', 'R$1.550,00', 'VR,VT,Auxílio Creche,GymPass','Rio de Janeiro'),
('Coordenador Financeiro', 'R$17.379,00', 'VR,Seguro de vida,Day-Off','Bahia'),
('Secretária Executiva', 'R$2.109,00', 'Vale Transporte','São Paulo'),
('Advogado Jr.', 'R$5.000,00', 'VR,VT,Auxílio combustível,Cesta Básica','Santa Catarina'),
('Jovem aprendiz', 'R$1.000,02', 'VR,VT','Brasília'),
('Dev Jr.', 'R$3.458,99', 'VR,VT,Seguro de vida,COnvênio','São Paulo'),
('Estágio em Dados', 'R$2.110,00', 'VR,GymPass','Minas Gerais'),
('Auxiliar de Dentista', 'R$2.100,00', 'VR,VT,Seguro de vida,GymPass','Paraiba'),
('Analista Financeiro', 'R$7.500,00', 'VR,VT,GymPass','São Paulo'),
('Vendedor', 'R$4.100,00', 'VR,VT,Cesta Básica','Curitiba'),
('Recepcionista', 'R$1.800,00', 'VR,VT,GymPass, Convênio','Rio de Janeiro'), 
('Assistente Administrativo', 'R$2.050,00', 'VR,VT,VA, Seguro de vida,GymPass, Convênio','Rio de Janeiro');
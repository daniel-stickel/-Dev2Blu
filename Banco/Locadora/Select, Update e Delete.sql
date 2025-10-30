create database locadoraminha;
use locadoraminha;

alter table carro add Status_Carro enum ('Ativo', 'Inativo') default "Ativo" not null;
alter table categoria add Status_Categoria enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table cidade add Status_Cidade enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table estado add Status_Estado enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table filial add Status_Filial enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table genero add Status_Genero enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table marca add Status_Marca enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table modelo add Status_Modelo enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table pacote add Status_Pacote enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table pessoa add Status_Pessoa enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table reserva add Status_Reserva enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table servico add Status_Servico enum ('Ativo', 'Inativo') default 'Ativo' not null;

ALTER TABLE `locadoraminha`.`carro` 
CHANGE COLUMN `Status_carro` `Status_Carro` ENUM('Ativo', 'Inativo') NOT NULL DEFAULT 'Ativo' ;



# Modulo Carro

# Post - Create   
INSERT INTO carro (Filial_Id, Modelo_Id, Placa, Capacidade_Mala, Capacidade_Pessoa, Motor, Ano, TipoCambio, Valor, Disponivel, Km)
VALUES (1, 2, 'PHL4F06', 210, 5, '1600', 1986, 'Manual', 3000.00, 1, 50000);

#Get - Read
select * from carro;

#Put - UpDate
update carro set filial_Id = 5, Placa = "KJE8123", Capacidade_Mala = 48, Capacidade_Pessoa = 5, Motor = 1.8, Ano = 2011, TipoCambio = 1,
 Valor = 30000.00, Disponivel = 0, Km = 60000 where id = 1; 
 
 #Delete - Delete
 update carro set Status_Carro = 'Inativo' where Id = 51;
 

# Modulo Categora 

# Post - Create
insert into categoria (Id, Nome) value (null, "Mega Master");

# Get - Read
select * from categoria;

# Put - UpDate
update categoria set Status_Categoria = 'Inativo' where id = 9;

# Delete - delete 
update carro set status_Carro = "Inativo" where  Id = 9;


# Modulo cidade

# Post - Create
insert into cidade (Id, Nome, Estado_Id, Status_Cidade)
values (null, 'Cidade Teste', 24, 'Ativo'); 

# Get - Read
select * from cidade;

# Put - UpDate
update cidade set nome = "Floripa" where id = 24;

# Delete - Delete
update cidade set status_cidade = 'Inativo' where Id = 4;


# Modulo - Estado

# Post - Create 
insert into estado (Id, Nome, Status_Estado)
values (null, "TE", 'Ativo'); 

# Get - Read 
select * from estado;

# Put - UpDate
update estado set Nome = "KW" where Nome = "TE";

#Delete - Delete
update estado set Status_estado = 'Inativo' where Nome = "TE";


#Modulo Filial

# Post - Create
insert into filial (Id, Cidade_Id, CodigoFilial, Nome, Endereco, Telefone, Email, CEP, Status_Filial)
values (null, 23, 501, "locadora", "R. da Fulano de Tal", "4712345678", "email@email.com", 8905101, 'Inativo' );

# Get - Read
select * from filial; 

# Put - UpDate
update filial set Status_Filial = 'Ativo' where Id = 6;

#Delete - Delete
update filial set Status_Filial = 'Inativo' where Id = 6;


# Modulo Genero

 #Post - Create
insert into genero(Id, nome, Status_Genero)
values(null, "Travesti", 'Ativo');  
 
 #Get - Read
 select * from genero;
 
 #Put - UpDate
 update genero set nome = "Traveco" where id = (SELECT MAX(Id) FROM FILIAL);
 
 #Delete - Delete
update genero set Status_Genero = 'Inativo' where id = 4;


# Modulo Genero

#Post - Create
 insert into marca (Id, Nome, Status_Marca) values (null, "Corgel do Brasil", 'Inativo');
 
#Get - Read
select * from marca;
  
#Put - UpDate
update marca set Status_Marca = "Ativo" where id = 12;
   
#Delete - Delete
update marca set Status_Marca = "Inativo" where id = 12;

 
 # Modulo Modelo

 #Post - Create
 insert into modelo (Id, Marca_Id, Categoria_Id, Nome, Status_Modelo)
 VALUES (null, 7, 5, "Compas", 'Inativo');
 
 
#Get - Read
select * from modelo;
  
#Put - UpDate
update modelo set Status_Modelo = "Ativo" where id = 20;
   
#Delete - Delete
update modelo set Status_Modelo = "Inativo" where id = 20; 
  

# Modulo Pacote

#Post - Create
 insert into pacote (Id, Nome, Valor, Status_Pacote) 
 VALUES (null, "Mafioso", 500.00, 'Inativo');
 
#Get - Read
select * from pacote;
  
#Put - UpDate
update pacote set Status_Pacote = 'Ativo' where id = 4;
   
#Delete - Delete
update pacote set Status_Pacote = 'Inativo' where id = 4;


#Modulo Pessoa

#Post - Create
 insert into pessoa (Id, Genero_Id, Cidade_Id, Nome, CPF, CNH, Endereco, Telefone, Email, CEP, Senha, Status_Pessoa) VALUES
(null, 1, 25, 'Zequinha da Silva', '11122233888', '12345678888', 'Rua Flores, 188', '11987654888', 'zequinha@email.com', '01001000', 'senha123', 'Inativo');
 
#Get - Read
select * from pessoa;
  
#Put - UpDate
update pessoa set Status_Pessoa = 'Ativo' where id = 4;
   
#Delete - Delete
update pessoa set Status_Pessoa = 'Inativo' where id = 4;


#Modulo reserva

#Post - Create
insert into reserva (Id, Pacote_Id, Carro_Id, DataRetirada, DataDevolucao, Pessoa_Id, Valor_Total, Status_ReservaServico, Data_Reserva, Status_Reserva) VALUES
(null, 1, 1, '2025-07-10 10:00:00', '2025-07-15 10:00:00', 121, 625.00, 'Finalizado', '2025-10-09 10:00:00', 'Inativo'); 

#Get - Read
select * from reserva;
  
#Put - UpDate
update reserva set Status_Reserva = 'Ativo' where id = 21;
   
#Delete - Delete
update reserva set Status_Reserva = 'Inativo' where id = 21;


#Modulo Servico

#Post - Create
insert into servico (Id, Nome, Descricao, Valor, Status_Servico) VALUES 
(null, 'Máquina de Choque', "Acessório de segurança forçada", 0.00, 'Inativo');

#Get - Read
select * from servico;
  
#Put - UpDate
update servico set Status_Servico = 'Ativo' where id = 5;
   
#Delete - Delete
update servico set Status_servico = 'Inativo' where id = 5;


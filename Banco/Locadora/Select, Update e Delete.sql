use minhalocadora;

alter table carro add status_carro enum ('Ativo', 'Inativo') default "Ativo" not null;
alter table categoria add status_categoria enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table cidade add status_cidade enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table estado add status_estado enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table filial add status_filial enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table genero add status_genero enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table marca add status_marca enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table modelo add status_modelo enum ('Ativo', 'Inativo') default 'Ativo' not null;
alter table pacote add status_pacote enum ('Ativo', 'Inativo') default 'Ativo' not null;


# Modulo Carro

# Post - Create
insert into carro (Id, filial_Id, modelo_Id, Placa, Capacidade_Mala, Capacidade_Pessoa, Motor, Ano, TipoCambio, Valor, Disponivel, Km)
value (210, 210, 20, "PHL4F06", 210, 5, "1600", 1986, "Manual", 30000.00, 1, 50000);

#Get - Read
select * from carro;

#Put - UpDate
update carro set filial_Id = 210, modelo_Id = 210, Placa = "KJE8123", Capacidade_Mala = 48, Capacidade_Pessoa = 5, Motor = 1.8, Ano = 2011, TipoCambio = 1,
 Valor = 30000.00, Disponivel = 0, Km = 60000 where id = 1; 
 
 #Delete - Delete
 delete from carro where Id = 1;

# Modulo Categora 

# Post - Create
insert into categoria (Id, Nome) value (null, "Mega Master");

# Get - Read
select * From categoria;

# Delete - delete 
update carro set statusCarro = "inativo" where = Id = 1;

# Vai precisar criar uma coluna para todos as tabelas do banco para poder deletar === statusNomedatabela



insert into 

# Modulo - CLIENTE 

#POST - CREATE
INSERT INTO CLIENTE (Id, Nome, Email, Telefone) VALUES (null, "Tiago", "tiago@dsa.com", "47988989898");

#GET - READ
SELECT * FROM CLIENTE;

#PUT - UPDATE
UPDATE CLIENTE SET Nome = "T", Email = "t@t.com", Telefone = "8489498" WHERE Id = 1;

#DELETE - DELETE
DELETE FROM CLIENTE WHERE Id = 1;


select * from categoria; 

select * from cidade;

select * from estado;

select * from filial;

select * from genero;

select * from marca;

select * from modelo;

select * from pacote;

select * from pacote_servico;

select * from pessoa;

select * from reserva;


select * from  reserva_servico;

select * from servico;

# Modulo - CLIENTE 

#POST - CREATE
INSERT INTO CLIENTE (Id, Nome, Email, Telefone) VALUES (null, "Tiago", "tiago@dsa.com", "47988989898");

#GET - READ
SELECT * FROM CLIENTE;

#PUT - UPDATE
UPDATE CLIENTE SET Nome = "T", Email = "t@t.com", Telefone = "8489498" WHERE Id = 1;

#DELETE - DELETE
DELETE FROM CLIENTE WHERE Id = 1;

# Modulo - Peca 
#POST - CREATE
INSERT INTO PECA (Id, Descricao, Preco) VALUES (null, "Junta de cabeçote", 55.20);

#GET - READ
SELECT * FROM PECA;

#PUT - UPDATE
UPDATE PECA SET Descricao = "T", Preco = 32.50 WHERE Id = 1;

#DELETE - DELETE
DELETE FROM PECA WHERE Id = 1;


# Modulo - Mecanico 
#POST - CREATE
INSERT INTO MECANICO (Id, Nome) VALUES (null, "Tiago");

#GET - READ
SELECT * FROM MECANICO;

#PUT - UPDATE
UPDATE MECANICO SET Nome = "T" WHERE Id = 1;

#DELETE - DELETE
DELETE FROM MECANICO WHERE Id = 1;


# Modulo da OS 

#POST - Create
INSERT INTO ORDEM_SERVICO (Id, Descricao, DataOrdem, Valor, ClienteId, MecanicoId)
VALUES (null, "Veio trocar o oleo", "2025-09-17", 55.50, 2, 2);

#for 
# peça 2
INSERT INTO ORDEM_SERVICO_PECA (OrdemServicoId, PecaId, Quantidade, Preco)
VALUES ((SELECT MAX(Id) FROM ORDEM_SERVICO), 2, 5, 55.00);

# peça 3
INSERT INTO ORDEM_SERVICO_PECA (OrdemServicoId, PecaId, Quantidade, Preco)
VALUES ((SELECT MAX(Id) FROM ORDEM_SERVICO), 3, 5, 55.00);
 


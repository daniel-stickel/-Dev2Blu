create database MinhaLocadora;

use MinhaLocadora;
use locadoraminha;

create table genero(
id INT not null auto_increment primary key,
nome varchar(20) not null
);

create table estado(
Id int not null auto_increment primary key,
Nome varchar(2) not null unique
);

create table marca(
Id int primary key not null auto_increment,
Nome varchar(255)
);

create table categoria(
Id int primary key not null auto_increment,
Nome varchar(50) not null unique
);

create table modelo(
Id int primary key not null auto_increment,
Marca_Id int not null ,
Categoria_Id int not null ,
Nome varchar(255),
CONSTRAINT FK_MODELO_MARCA foreign key (Marca_Id) references marca(Id),
CONSTRAINT FK_MODELO_CATEGORIA foreign key (Categoria_Id) references categoria(Id)
);

create table carro(
Id int primary key not null auto_increment ,
Filial_Id int not null,
Modelo_Id int not null,
Placa varchar(9) not null,
Capacidade_Mala int(4) not null,
Capacidade_Pessoa int(1) not null,
Motor varchar(15) not null,
Ano int not null, 
TipoCambio Enum('Automatico', 'Manual') not null,
Valor Decimal(10,2) not null,
Disponivel tinyint(1) not null,
Km int(10),
constraint FK_CARRO_MODELO foreign key (Modelo_Id) references modelo(Id),
constraint FK_CARRO_FILIAL foreign key (Filial_Id) references filial(Id)
);


create table reserva(
Id int primary key not null auto_increment,
Pacote_Id int not null,
Carro_Id int not null,
DataRetirada datetime,
DataDevolucao datetime,
constraint FK_RESERVA_CARRO foreign key (Carro_Id) references carro(Id),
constraint FK_RESERVA_PACOTE foreign key (Pacote_Id) references pacote(Id)
);




create table reserva_servico(
Reserva_id int primary key not null,
Servico_Id int not null,
constraint FK_RESERVA_SERVICO_SERVICO foreign key (Servico_id) references servico(Id)
);

create table servico(
Id int primary key not null auto_increment,
Nome varchar(255) not null unique,
Descricao text not null
);

create table pacote_servico(
Pacote_Id int not null primary key,
Serviço_Id int not null,
constraint FK_PACOTE_SERVICO_SERVICO foreign key (Servico_Id) references servico(id)
);

create table pacote(
Id int primary key not null auto_increment,
Nome varchar(255) unique not null,
Valor decimal(10,2) not null
);

create table filial(
Id int primary key not null auto_increment,
Cidade_Id int not null,
CodigoFilial int not null,
Nome varchar(255) not null,
Endereco varchar(255) not null,
Telefone varchar(16) not null,
Email varchar(255) not null,
CEP varchar(8),
constraint FK_FILIAL_CIDADE foreign key (Cidade_Id) references cidade(Id)
);

create table cidade(
Id Int primary key not null auto_increment,
Estado_Id int not null,
Nome varchar(255) not null,
constraint FK_CIDADE_ESTADO foreign key (Estado_Id) references estado(Id)
);

create table pessoa(
Id int primary key not null auto_increment,
Genero_Id int not null,
Cidade_Id int not null,
Nome varchar(255) not null,
CPF varchar(11) not null,
CNH int(11) not null,
Endereco varchar(255) not null,
Telefone varchar(16) not null,
Email varchar(255) unique not null,
CEP varchar(8),
Senha varchar(15) not null,
constraint FK_PESSOA_CIDADE foreign key (Cidade_Id) references cidade(Id),
constraint FK_PESSOA_GENERO foreign key (Genero_Id) references genero(Id)
);



create table pacote_servico(
Pacote_Id int,
Servico_Id int,
primary key(Pacote_id, Servico_Id),
foreign key(Pacote_Id) references pacote(Id),
foreign key(Servico_id) references servico(Id)
);

# Adicionando colunas que ficarão pendentes

# Tabela servico
alter table servico add column Valor decimal(10,2);

# Tabela reserva
alter table reserva
add column Pessoa_Id int not null,
add column Valor_Total decimal(10,2),
add column Status_Reserva enum('Aberto', 'Pendente', 'Finalizado'),
add column Data_Reserva datetime,
add constraint FK_RESERVA_PESSOA foreign key (Pessoa_Id) references pessoa(Id);



create table teste(
Id int primary key,
Nome varchar(30)
);

alter table teste add Coluna varchar(50); -- adicionando uma coluna a uma tabéla

alter table teste modify Coluna text;  -- modificando o tipo de uma coluna 

alter table teste drop column Coluna; -- apagando uma coluna 

alter table servico modify descricao text;

create table teste2(
Id int primary key,
Teste2_id int
);

alter table teste add teste2_Id int; -- adicionando uma coluna a uma tabela

alter table teste add constraint FK_TESTE_TESTE2 foreign key (teste2_id) references teste2(id); -- adicionando uma coluna estrangeira a tabela

alter table teste2 drop column teste2_Id; -- apagando uma coluna

drop table teste2; -- apagando uma tabela

alter table teste drop foreign key FK_TESTE_TESTE2;  -- apagando uma coluna estrangeira de uma tabéla 

drop table teste2;

drop table teste; --apagando uma tabela

alter table servico change column descrevendo descricao varchar(255); --alterando o nome de uma coluna






    












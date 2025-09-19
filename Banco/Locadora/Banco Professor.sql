
CREATE DATABASE LojaDB;
USE LojaDB;

CREATE TABLE Clientes (
    ClienteID INT AUTO_INCREMENT PRIMARY KEY,
    Nome       VARCHAR(100) NOT NULL,
    Cidade     VARCHAR(100),
    Estado     CHAR(2),
    DataCadastro DATE
);

CREATE TABLE Produtos (
    ProdutoID INT AUTO_INCREMENT PRIMARY KEY,
    Nome       VARCHAR(100) NOT NULL,
    Categoria  VARCHAR(50),
    Preco      DECIMAL(10,2) NOT NULL
);

CREATE TABLE Pedidos (
    PedidoID  INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT NOT NULL,
    DataPedido DATE,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);

CREATE TABLE ItensPedido (
    ItemID    INT AUTO_INCREMENT PRIMARY KEY,
    PedidoID  INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnit  DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (PedidoID)  REFERENCES Pedidos(PedidoID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
);

CREATE TABLE Pagamentos (
    PagamentoID INT AUTO_INCREMENT PRIMARY KEY,
    PedidoID    INT NOT NULL,
    DataPagamento DATE,
    Valor       DECIMAL(10,2),
    Metodo      VARCHAR(30),
    FOREIGN KEY (PedidoID) REFERENCES Pedidos(PedidoID)
);

-- Clientes
INSERT INTO Clientes (Nome,Cidade,Estado,DataCadastro) VALUES
('Ana Souza','Curitiba','PR','2024-01-10'),
('Bruno Lima','Florianópolis','SC','2024-02-05'),
('Carla Torres','Porto Alegre','RS','2024-02-20'),
('Diego Martins','Joinville','SC','2024-03-12');

-- Produtos
INSERT INTO Produtos (Nome,Categoria,Preco) VALUES
('Notebook','Informática',3500.00),
('Mouse','Informática',50.00),
('Teclado Mecânico','Informática',320.00),
('Cadeira Gamer','Móveis',1200.00),
('Monitor 24"','Informática',900.00);

-- Pedidos
INSERT INTO Pedidos (ClienteID,DataPedido) VALUES
(1,'2024-03-15'),
(2,'2024-03-18'),
(1,'2024-03-20'),
(3,'2024-03-22');

-- Itens de pedido
INSERT INTO ItensPedido (PedidoID,ProdutoID,Quantidade,PrecoUnit) VALUES
(1,1,1,3500.00),
(1,2,2,50.00),
(2,4,1,1200.00),
(3,3,1,320.00),
(3,5,2,900.00),
(4,2,1,50.00);

-- Pagamentos
INSERT INTO Pagamentos (PedidoID,DataPagamento,Valor,Metodo) VALUES
(1,'2024-03-16',3600.00,'Cartão'),
(2,'2024-03-18',1200.00,'Pix'),
(3,'2024-03-21',2120.00,'Boleto');



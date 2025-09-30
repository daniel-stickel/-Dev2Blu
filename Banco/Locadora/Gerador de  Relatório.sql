use locadoraminha;

select *
from pessoa P 
join genero G 
on P.Genero_Id like G.Id;
    
select C.Nome as cidade,
    G.Nome as Genero,
    count(P.Id) as QuantidadeClientes
    from pessoa P 
    join cidade C 
    on P.Cidade_Id like C.Id
    join genero G 
    on P.genero_Id = G.Id
    group by C.Nome, G.Nome
    order by cidade;	#Informa por cidade a quantidade de clientes por gênero 

select G.Nome as GeneroMaisReservado, count(P.Genero_Id) as Quantidade
	from genero G
    join pessoa P
	on P.Genero_Id = G.Id
    group by P.Genero_Id
    order by Quantidade desc; # Informa de reserva a quantidade por gênero
    
select E.Nome as Estado, count(P.Id) as QuantidadeClienteEstado
    from pessoa P 
    join cidade C
    on P.cidade_Id like C.Id
    join estado E 
    on C.Estado_Id like E.Id
    group by E.nome
    order by QuantidadeClienteEstado desc;	#Informa a quantidade de clientes que tiveram aluguel por estado 
    
select C.Nome as Cidade, E.Nome as estados, count(P.Id) as QuantidadeClientes
    from pessoa P 
    join Cidade C 
    on P.cidade_Id like C.Id
    join estado E 
    on C.estado_Id = E.Id
    group by C.Nome, E.Nome
    order by QuantidadeClientes desc, Cidade
    limit 10;	# Top 10 cidades que mais tem clientes
    
select G.Nome as Genero, sum(R.Valor_Total) as ValorTotalReservas, round(avg(R.Valor_Total),2) as GastoMedioReserva
    from reserva R 
    join Pessoa P 
    on R.Pessoa_Id = P.Id
    join genero G 
    on P.genero_ID like G.Id
    group by G.nome
    order by ValorTotalReservas desc;	# Informa o genero que mais alugol carros
    
    
    


SELECT M.Nome AS Modelo,
 COUNT(R.Carro_Id) AS TotalReservas		# Gera calculaos, une os dados e a palavra AS da nome a coluna que vai apresentar o resultado
  FROM Reserva R	# Pega informações dea tabela Reserva e apelida como R
  JOIN Carro C 		# Pega a informação da tabela Carro e apelida como C
    ON R.Carro_Id = C.Id	# Coluna primaria e FK 
  JOIN Modelo MO			# Faz junção de mais uma tabela ao relatório
    ON C.Modelo_Id = MO.Id	# Coluna primaria e Fk da segunda junção (Modelo)
  JOIN Marca M		# Faz junção de uma quarta tabela
  ON MO.Marca_Id = M.Id		# Coluna primaria e Fk da terceira junção (Modelo)
GROUP BY M.Nome				# Diz que a primeira coluna vai ser Nome
ORDER BY TotalReservas desc; 	#Diz que a ordem é decrecente a partir da tabela TotalReservas


SELECT Marca.Nome AS Marca,
    COUNT(Reserva.Id) AS TotalReservas
	FROM Reserva
	JOIN Carro ON Reserva.Carro_Id = Carro.Id
	JOIN Modelo ON Carro.Modelo_Id = Modelo.Id
	JOIN Marca ON Modelo.Marca_Id = Marca.Id
	GROUP BY  Marca.Id, Marca.Nome
	ORDER BY  TotalReservas DESC
LIMIT 1;











  SELECT *, Quantidade*PrecoUnit AS ValorTotal
  FROM ItensPedido;
  
SELECT SUM(Quantidade*PrecoUnit) AS Faturamento,
       SUM(Quantidade*PrecoUnit)*0.94 AS FaturamentoLiquido,
       GROUP_CONCAT(PedidoId) AS Pedidos,
       ROUND(AVG(Quantidade*PrecoUnit), 2) AS TicketMedio,
       MAX(Quantidade*PrecoUnit) AS TicketMaximo,
       MIN(Quantidade*PrecoUnit) AS TicketMinimo
  FROM ItensPedido;
  
  SELECT ProdutoId, 
         SUM(Quantidade*PrecoUnit) AS Faturamento,
         COUNT(DISTINCT PedidoId) AS QtdPedidos,
         AVG(Quantidade*PrecoUnit) AS TicketMedio
    FROM ItensPedido
  GROUP BY ProdutoId;
  
  

  SELECT IP.ProdutoId, P.Nome, SUM(IP.Quantidade*IP.PrecoUnit) AS ValorTotal
  FROM ItensPedido IP
  JOIN Produtos P
    ON IP.ProdutoId = P.ProdutoId
  GROUP BY Ip.ProdutoId
  ORDER BY ValorTotal DESC
  LIMIT 2;    
use locadoraminha;

select *
from pessoa P 
join genero G 
on P.Genero_Id like G.Id;

select G.Nome as GeneroMaisReservado, count(P.Genero_Id) as Quantidade
	from genero G
    join pessoa P
	on P.Genero_Id = G.Id
    group by G.Nome
    order by G.Nome ; # Informa a quantidade por gênero


SELECT M.Nome AS Modelo, COUNT(R.Carro_Id) AS TotalReservas
  FROM Reserva R
  JOIN Carro C 
    ON R.Carro_Id = C.Id
  JOIN Modelo MO
    ON C.Modelo_Id = MO.Id
  JOIN Marca M ON MO.Marca_Id = M.Id
GROUP BY M.Nome
ORDER BY TotalReservas desc; 	#tabela que informa as marcas que mais tiveram reservas

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
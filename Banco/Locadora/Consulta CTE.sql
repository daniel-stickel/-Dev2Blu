use locadoraminha;

with clientes_genero as (
select C.Nome as cidade,
    G.Nome as Genero,
    count(P.Id) as QuantidadeClientes
    from pessoa P 
    join cidade C 
    on P.Cidade_Id like C.Id
    join genero G 
    on P.genero_Id = G.Id
    group by C.Nome, G.Nome
    order by cidade	#Informa por cidade a quantidade de clientes por gênero 
) select * from clientes_genero;

    
    with cliente_aluguel_estado as (
    select E.Nome as Estado, count(P.Id) as QuantidadeClienteEstado
    from pessoa P 
    join cidade C
    on P.cidade_Id like C.Id
    join estado E 
    on C.Estado_Id like E.Id
    group by E.nome
    order by QuantidadeClienteEstado desc	#Informa a quantidade de clientes que tiveram aluguel por estado 
) select * from cliente_aluguel_estado;

with top_cidade_clientes as (
select C.Nome as Cidade, E.Nome as estados, count(P.Id) as QuantidadeClientes
    from pessoa P 
    join Cidade C 
    on P.cidade_Id like C.Id
    join estado E 
    on C.estado_Id = E.Id
    group by C.Nome, E.Nome
    order by QuantidadeClientes desc, Cidade
    limit 10	# Top 10 cidades que mais tem clientes
    ) select * from top_cidade_clientes;
    
 with carros_mais_reservados as (   
    SELECT M.Nome AS Modelo,
 COUNT(R.Carro_Id) AS TotalReservas		
  FROM Reserva R	
  JOIN Carro C 		
    ON R.Carro_Id = C.Id	
  JOIN Modelo MO			
    ON C.Modelo_Id = MO.Id	
  JOIN Marca M		
  ON MO.Marca_Id = M.Id		
GROUP BY M.Nome				
ORDER BY TotalReservas desc
) select * from carros_mais_reservados;

with marcas_mais_reservadas as(
SELECT Marca.Nome AS Marca,
    COUNT(Reserva.Id) AS TotalReservas
	FROM Reserva
	JOIN Carro ON Reserva.Carro_Id = Carro.Id
	JOIN Modelo ON Carro.Modelo_Id = Modelo.Id
	JOIN Marca ON Modelo.Marca_Id = Marca.Id
	GROUP BY  Marca.Id, Marca.Nome
	ORDER BY  TotalReservas DESC
    LIMIT 1
    ) select * from marcas_mais_reservadas;

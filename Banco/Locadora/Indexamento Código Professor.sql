#Consulta
explain
select C.Nome as cidade,
    G.Nome as Genero,
    count(P.Id) as QuantidadeClientes
    from pessoa P 
    join cidade C 
    on P.Cidade_Id like C.Id
    join genero G 
    on P.genero_Id = G.Id
    where G.Nome = "Masculino"
    group by C.Nome, G.Nome
    order by cidade;	#Informa por cidade a quantidade de clientes por gênero 
    #rows antes do índice = 6
    
    #Índice
    create index genero_Nome_IDX on genero (Nome);
    #Rows depois do index = 1
    # Ganho 600%

#Consulta
explain
select G.Nome as GeneroMaisReservado, count(P.Genero_Id) as Quantidade
	from genero G
    join pessoa P
	on P.Genero_Id = G.Id
    where P.Genero_id = 1 
    group by P.Genero_Id
    order by Quantidade desc; # Informa de reserva a quantidade por gênero
    #Rows antes do índice = 66
    
    #Índice
    create index pessoa_Genero_Id_IDX on pessoa (Genero_Id);
    #Rows depois do ìndice = 1
    # Ganho 6600%
    
    
#Consulta
explain    
select E.Nome as Estado, count(P.Id) as QuantidadeClienteEstado
    from pessoa P 
    join cidade C
    on P.cidade_Id like C.Id
    join estado E 
    on C.Estado_Id like E.Id
    where P.cidade_Id = 24
    group by E.nome
    order by QuantidadeClienteEstado desc;	#Informa a quantidade de clientes que tiveram aluguel por estado 
    #Rows antes do índice = 200
    
    #Índice
    create index estado_Estado_nome_IDX on estado (Nome);
    #Rows depois do índice = 28
    # Ganho 714%
    
           
    #Consulta
explain    
select C.Nome as Cidade, E.Nome as estados, count(P.Id) as QuantidadeClientes
    from pessoa P 
    join Cidade C 
    on P.cidade_Id like C.Id
    join estado E 
    on C.estado_Id = E.Id
    where C.nome = "Blumenau"
    group by C.Nome, E.Nome
    order by QuantidadeClientes desc, Cidade
    limit 10;	# Top 10 cidades que mais tem clientes
    #Rows antes do índice = 1022
    #Rows antes do índice = 2132
    #Rows antes do índice = 12
    
    #Índice
    create index cidade_Estado_Id_IDX on cidade (Estado_Id);
    #Rows depois do índice = 3
    # Ganho 34066%
    create index cidade_Nome_IDX on cidade (Nome);
    #Rows depois do índice = 1
    # Ganho 213200%
    create index pessoa_Cidade_Id_IDX on pessoa (Cidade_Id);
    #Rows depois do índice = 1
    # Ganho 1200%
        
    #Consulta
    explain
select G.Nome as Genero, sum(R.Valor_Total) as ValorTotalReservas, round(avg(R.Valor_Total),2) as GastoMedioReserva
    from reserva R 
    join Pessoa P 
    on R.Pessoa_Id = P.Id
    join genero G 
    on P.genero_ID like G.Id
    where R.Pessoa_Id = 100
    group by G.nome
    order by ValorTotalReservas desc;	# Informa o genero que mais alugol carros
    #Rows antes do índice = 100
    
    #Índice
    create index reserva_Pessoa_Id on reserva (Pessoa_Id);
    #Rows depois do índice = 1
    #Ganho de 10000%
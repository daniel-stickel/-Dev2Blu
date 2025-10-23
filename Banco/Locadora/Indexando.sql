use locadoraminha;

drop index nome on estado; # para apagar um Index

select * from cidade where nome = "Blumenau";

create index cidade_nome_idx on cidade (nome); # comando para criar um index // create index nomeDaTabela_NomeDaColuna_idx on NomeDaTabela (NomeDoCampo);
# index é usado quando a muitos dados em uma tabela 


create index FK_cidade_Cidade_Id_IDX on estado (Id);
create index cidade_nome_idx on cidade (nome);

create index FK_carro_Filial_Id_IDX on filial (Id)
create index FK_carro_Modelo_Id_IDX on modelo (id)

create index carro_nome_IDX on carro (nome);

# Consulta:
select * from cidade where nome = "Blumenau";
#Rows antes do 	Indice = 5570

 #Indice:
 create index cidade_Nome_IDX on cidade (Nome);
# Row apos o Indice = 1


#Consulta
explain
select * from pessoa where Cidade_Id;
# Rows antes do índice = 201

#Índice
create index pessoa_Cidade_Id_IDX on pessoa (Cidade_Id);
#Rows depois do índice = 1

#Consulta:
explain
select * from pessoa where Nome;
# Rows antes do índice = 201

#Índice
create index pessoa_nome_IDX on pessoa (nome);
# Rows depois do índice = 1

drop index pessoa_Cidade_Id_IDX on pessoa;

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
    group by C.Nome, G.Nome
    order by cidade;	#Informa por cidade a quantidade de clientes por gênero 
    #rows antes do índice = 660
    
    #Índice
    create index cidade_Nome_IDX on cidade (Nome);
    #Rows depois do index = 66

#Consulta
explain
select G.Nome as GeneroMaisReservado, count(P.Genero_Id) as Quantidade
	from genero G
    join pessoa P
	on P.Genero_Id = G.Id
    group by P.Genero_Id
    order by Quantidade desc; # Informa de reserva a quantidade por gênero
    #Rows antes do índice = 66
    
    #Índice
    create index pessoa_Genero_Id_IDX on pessoa (Genero_Id);
    #Rows depois do ìndice
    
    
#Consulta
explain    
select E.Nome as Estado, count(P.Id) as QuantidadeClienteEstado
    from pessoa P 
    join cidade C
    on P.cidade_Id like C.Id
    join estado E 
    on C.Estado_Id like E.Id
    group by E.nome
    order by QuantidadeClienteEstado desc;	#Informa a quantidade de clientes que tiveram aluguel por estado 
    #Rows antes do índice = 200
    
    #Índice
    create index estado_Estado_nome_IDX on estado (Nome);
    #Rows depois do índice = 200
    
    
#Consulta
explain    
select C.Nome as Cidade, E.Nome as estados, count(P.Id) as QuantidadeClientes
    from pessoa P 
    join Cidade C 
    on P.cidade_Id like C.Id
    join estado E 
    on C.estado_Id = E.Id
    group by C.Nome, E.Nome
    order by QuantidadeClientes desc, Cidade
    limit 10;	# Top 10 cidades que mais tem clientes
    #Rows antes do índice = 1
    
    #Índice
    create index cidade_Estado_Id_IDX on cidade (Estado_Id);
    #Rows depois do índice = 1
    
    #Consulta
    explain
select G.Nome as Genero, sum(R.Valor_Total) as ValorTotalReservas, round(avg(R.Valor_Total),2) as GastoMedioReserva
    from reserva R 
    join Pessoa P 
    on R.Pessoa_Id = P.Id
    join genero G 
    
    on P.genero_ID like G.Id
    group by G.nome
    order by ValorTotalReservas desc;	# Informa o genero que mais alugol carros
    #Rows antes do índice = 100
    
    #Índice
    create index reserva_Pessoa_Id on reserva (Pessoa_Id);
    #Rows depois do índice = 1
    

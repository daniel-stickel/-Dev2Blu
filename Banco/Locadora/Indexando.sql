use minhalocadora;

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

use locadoraminha;

select * from clientes where estado = "SC";

select * from clientes where estado = "SC" and cidade  = "Florianópolis";

select * from clientes where estado = "PR" and cidade  = "Florianópolis";

select * from clientes where estado = "PR" or cidade  = "Florianópolis";

select * from clientes where nome = "Ana ";

insert into clientes (ClienteId, Nome, Cidade, Estado, DataCadastro)
values (null, "André Souza", "Blumenau", "SC", "2025-09-18");

select * from clientes where nome like "An%"; #  % busca todos que iniciam com AN . e o like é como se foce o sinal de igual

select * from clientes where nome like "% Souza"; #busca todos que terminam com Souza

select * from clientes where nome like "%Andre Souza"; 

select * from produtos;

select * from produtos order by Preco;

select * from produtos order by Preco asc; # Exibe em ordem crecente 

select * from produtos order by Preco desc; # Exibe em ordem descrecente

select * from Pedidos P, Clientes C where P.ClienteId = C.ClienteId;

select *
from Pedidos P 
inner join Clientes C
on P.ClienteId = C.ClienteId;

select *			# seleciona a tabela 
from Pedidos P 		# compara pedidos
join Clientes C		#com Clientes 
on P.ClienteId = C.ClienteId;	

use locadoraminha;

select *
from modelo M
join Marca Ma
on M.Categoria_Id = Ma.Id;

select * 
from modelo M 
join categoria C 
on M.Categoria_Id = C.Id
and C.Status_categoria = 'Ativo';

select *
from carro C  
inner join modelo M	 # inner join paga os dados que estão juntos do mesmo grupo, ou seja, que estão em carro e modelo
on C.Modelo_Id = M.Id order by C.Motor asc;

select *
from carro C 
join Filial F 
on C.Filial_Id like F.Id order by F.Nome desc; # like faz o mesmo que o =  e o desc exibe em ordem decrescente

select *
from cidade C  
join estado E 
on C.Estado_Id = E.Id and E.Nome = "SC" order by C.Id desc;

select *
from filial F 
join Cidade C 
on F.Cidade_Id like C.Id order by Cidade_Id asc;

select *
from pessoa P 
inner join genero G 
on P.Genero_Id = G.Id order by Cidade_Id asc;

select * 
from pessoa P 
join cidade C 
on P.Cidade_Id like C.Id;

select * 
from reserva R 
inner join pessoa P 
on R.Carro_Id like P.Id where P.Cidade_Id = 24;

select * 
from reserva R
join pacote P
on R.Pacote_Id like P.Id where Nome = 'basico';

select * 
from reserva R
inner join carro C 
on R.Carro_Id = C.Id where valor > 100 and valor < 500;

select * 
from pacote P 
join pacote_Servico PS
on P.Id = PS.Pacote_Id order by Nome asc;

select * 
from servico S
left join pacote_servico PS
on S.Id like PS.Servico_Id order by Pacote_Id > 1 or Status_Servico != 'Inativo';


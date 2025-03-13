create database AulaDBFacul
create table jogos(
	id int not null primary key,
	descricao varchar(50),
	valorLocacao decimal(18,2),
	dataAquisicao datetime,
	categoriaId int
)
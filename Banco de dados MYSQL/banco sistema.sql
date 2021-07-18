create database sistema;

use sistema;

create table tbusuario(
id int (8) primary key auto_increment,
cpf varchar (16) not null unique,
nome varchar (50) not null,
login varchar (20) not null,
senha varchar (10) not null,
perfil varchar (20) not null
);

create table tbfornecedor(
id int(8) primary key auto_increment,
cnpj varchar (20) not null unique,
nomefantasia varchar (50) not null,
razaosocial varchar (50) not null,
inscricaoestadual varchar (50) not null,
inscricaomunicipal varchar (50) not null,
dddcel varchar (50) not null,
celular varchar (50) not null,
dddtel varchar (50) not null,
telefone varchar (50) not null,
cep varchar (50) not null,
lougradouro varchar (50) not null,
bairro varchar (50) not null,
numero varchar (50) not null,
complemento varchar (50) not null,
cidade varchar (50) not null,
uf varchar (50) not null,
email varchar (50) not null);

SELECT * FROM TBFORNECEDOR;

SELECT * FROM TBusuario;

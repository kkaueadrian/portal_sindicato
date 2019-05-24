create database portal_sindicato;
use portal_sindicato;

create table adm_administrador(
adm_codigo int primary key auto_increment,
adm_nome varchar(100) not null,
adm_status tinyint(1) not null,
adm_senha varchar(20) not null,
adm_contato varchar(14),
adm_email varchar(45));

create table sin_sindicato(
sin_codigo int primary key auto_increment,
sin_cnpj varchar(18) not null,
sin_razao_social text not null,
sin_endereco varchar(100) not null,
sin_contato varchar(100) not null,
sin_ativo tinyint(1));

create table set_setor(
set_codigo int primary key auto_increment,
set_tipo varchar(45) not null);

create table sis_sindicato_setor(
sis_codigo int primary key auto_increment,
sin_codigo int not null,
set_codigo int not null,
foreign key(set_codigo) references set_setor(set_codigo),
foreign key(sin_codigo) references sin_sindicato(sin_codigo));

create table pes_pessoa(
pes_codigo int primary key auto_increment,
pes_tipo int(1) not null,
pes_e_administrador tinyint(1),
pes_nome varchar(100) not null,
pes_senha varchar(20) not null,
pes_cpf varchar (14) not null,
pes_nascimento datetime not null,
pes_dataadm datetime,
pes_datadem datetime,
pes_endereco varchar(100) not null,
pes_email varchar(45),
pes_contato varchar(14),
pes_matricula int,
pes_cnpj varchar(18),
pes_ie varchar(13),
pes_caepf varchar(18),
sin_codigo int not null,
foreign key(sin_codigo) references sin_sindicato(sin_codigo));

create table ser_servico(
ser_codigo int primary key auto_increment,
ser_descricao text not null,
ser_status tinyint(1) not null,
ser_tipo text not null,
set_codigo int not null,
sin_codigo int not null,
foreign key(set_codigo) references set_setor(set_codigo),
foreign key(sin_codigo) references sin_sindicato(sin_codigo));

create table pub_publicacao(
pub_codigo int primary key auto_increment,
pub_datacadastro datetime not null,
pub_datainicio datetime not null,
pub_datatermino datetime,
pub_endereco varchar(100),
pub_descricao text not null,
pub_status tinyint(1) not null,
pub_tipo tinyint(1) not null,
pub_imagem text,
sin_codigo int not null,
foreign key(sin_codigo) references sin_sindicato(sin_codigo));

create table pen_pendencia(
pen_codigo int primary key auto_increment,
pen_tipo varchar(45),
pen_documento text,
pes_codigo int not null,
foreign key(pes_codigo) references pes_pessoa(pes_codigo));
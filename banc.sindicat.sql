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
set_tipo varchar(255) not null);

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
ser_tipo varchar(255) not null,
sis_codigo int not null,
foreign key(sis_codigo) references sis_sindicato_setor(sis_codigo));

create table pub_publicacao(
pub_codigo int primary key auto_increment,
pub_datacadastro datetime not null,
pub_datainicio datetime not null,
pub_datatermino datetime,
pub_endereco varchar(100),
pub_descricao text not null,
pub_status tinyint(1) not null,
pub_tipo varchar(255) not null,
pub_imagem text,
sin_codigo int not null,
foreign key(sin_codigo) references sin_sindicato(sin_codigo));

create table pen_pendencia(
pen_codigo int primary key auto_increment,
pen_tipo varchar(255),
pen_documento text,
set_codigo int not null,
pes_codigo int not null,
foreign key(set_codigo) references set_setor(set_codigo),
foreign key(pes_codigo) references pes_pessoa(pes_codigo));

INSERT INTO `portal_sindicato`.`adm_administrador` (`adm_codigo`, `adm_nome`, `adm_status`, `adm_senha`, `adm_contato`, `adm_email`) VALUES ('1', 'Barbara Aline', '0', '1234', '(12)99152-7550', 'barbara_aline@gmail.com');
INSERT INTO `portal_sindicato`.`adm_administrador` (`adm_codigo`, `adm_nome`, `adm_status`, `adm_senha`, `adm_contato`, `adm_email`) VALUES ('2 ', 'José Pietro', '0', '1234', '(12)98235-6210', 'pietro_moreira@gmail.com');
INSERT INTO `portal_sindicato`.`adm_administrador` (`adm_codigo`, `adm_nome`, `adm_status`, `adm_senha`, `adm_contato`, `adm_email`) VALUES ('3', 'Paulo Otávio', '0', '1234', '(12)99113-9039', 'paulo_otavio@gmail.com');
INSERT INTO `portal_sindicato`.`adm_administrador` (`adm_codigo`, `adm_nome`, `adm_status`, `adm_senha`, `adm_contato`, `adm_email`) VALUES ('4', 'Kauê Adrian', '0', '1234', '(12)98226-5132', 'kaue.adrian@hotmail.com');
INSERT INTO `portal_sindicato`.`adm_administrador` (`adm_codigo`, `adm_nome`, `adm_status`, `adm_senha`, `adm_contato`, `adm_email`) VALUES ('5', 'Jessica Coelho', '0', '1234', '(12)98889-5937', 'jekicoelho@hotmail.com');

INSERT INTO `portal_sindicato`.`sin_sindicato` (`sin_codigo`, `sin_cnpj`, `sin_razao_social`, `sin_endereco`, `sin_contato`, `sin_ativo`) VALUES ('1', '51.784.163/0001-43', 'Sindicato Rural de Lorena e Piquete', 'Rua Dom Bosco 78', '(12)3153-1743', '1');
INSERT INTO `portal_sindicato`.`sin_sindicato` (`sin_codigo`, `sin_cnpj`, `sin_razao_social`, `sin_endereco`, `sin_contato`, `sin_ativo`) VALUES ('2', '72.774.569/0001-45', 'Sindicato Rural de Cachoeira Paulista', 'Avenida Eulália 2550', '(12)3301-6313', '0');

INSERT INTO `portal_sindicato`.`pes_pessoa` (`pes_codigo`, `pes_tipo`, `pes_nome`, `pes_senha`, `pes_cpf`, `pes_nascimento`, `pes_dataadm`, `pes_endereco`, `pes_email`, `pes_contato`, `pes_matricula`, `sin_codigo`) VALUES ('1', '0', 'Adão Paulo', '1234', '123.456.789-12', '1950-05-10', '2019-01-01', 'Fazenda Vargem Grande', 'adao.paulo@gmail.com', '(12)3153-1743', '0214', '1');
INSERT INTO `portal_sindicato`.`pes_pessoa` (`pes_codigo`, `pes_tipo`, `pes_e_administrador`, `pes_nome`, `pes_senha`, `pes_cpf`, `pes_nascimento`, `pes_dataadm`, `pes_endereco`, `pes_email`, `pes_contato`, `sin_codigo`) VALUES ('2', '1', '1', 'Mario Augusto', '1234', '234.456.789-12', '1967-05-23', '1990-05-01', 'Rua Carijós 43', 'mario.augusto@gmail.com', '(12)3153-1743', '1');
INSERT INTO `portal_sindicato`.`pes_pessoa` (`pes_codigo`, `pes_tipo`, `pes_e_administrador`, `pes_nome`, `pes_senha`, `pes_cpf`, `pes_nascimento`, `pes_dataadm`, `pes_endereco`, `pes_email`, `pes_contato`, `sin_codigo`) VALUES ('3', '1', '0', 'Andya Aynne', '1234', '456.789.456-12', '1980-04-27', '2011-03-01', 'Rua Conselheiro João Henrique 175', 'andya.aynne@gmail.com', '(12)3153-1743', '1');
INSERT INTO `portal_sindicato`.`pes_pessoa` (`pes_codigo`, `pes_tipo`, `pes_nome`, `pes_senha`, `pes_cpf`, `pes_nascimento`, `pes_dataadm`, `pes_datadem`, `pes_endereco`, `pes_email`, `pes_contato`, `pes_matricula`, `sin_codigo`) VALUES ('4', '0', 'Marcos Vinicius', '1234', '789.123.456-85', '1994-07-28', '2010-05-17', '2019-02-28', 'Rua São Paulo', 'marcos.vinicius@gmail.com', '(12)3153-1743', '0750', '2');

INSERT INTO `portal_sindicato`.`set_setor` (`set_codigo`, `set_tipo`) VALUES ('1', 'RH');
INSERT INTO `portal_sindicato`.`set_setor` (`set_codigo`, `set_tipo`) VALUES ('2', 'Fiscal');
INSERT INTO `portal_sindicato`.`set_setor` (`set_codigo`, `set_tipo`) VALUES ('3', 'Gerência');
INSERT INTO `portal_sindicato`.`set_setor` (`set_codigo`, `set_tipo`) VALUES ('4', 'Contabilidade');
INSERT INTO `portal_sindicato`.`set_setor` (`set_codigo`, `set_tipo`) VALUES ('5', 'SPA');

INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('1', '1', '1');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('2', '1', '2');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('3', '1', '3');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('4', '1', '4');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('5', '2', '1');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('6', '2', '2');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('7', '2', '3');
INSERT INTO `portal_sindicato`.`sis_sindicato_setor` (`sis_codigo`, `sin_codigo`, `set_codigo`) VALUES ('8', '2', '4');

INSERT INTO `portal_sindicato`.`pen_pendencia` (`pen_codigo`, `pen_tipo`, `set_codigo`, `pes_codigo`) VALUES ('1', 'Falta livro de registro', '1', '1');
INSERT INTO `portal_sindicato`.`pen_pendencia` (`pen_codigo`, `pen_tipo`, `set_codigo`, `pes_codigo`) VALUES ('2', 'Falta trazer extrato', '3', '4');

INSERT INTO `portal_sindicato`.`ser_servico` (`ser_codigo`, `ser_descricao`, `ser_status`, `ser_tipo`, `sis_codigo`) VALUES ('1', 'Registro de funcionários', '1', 'RH', '1');
INSERT INTO `portal_sindicato`.`ser_servico` (`ser_codigo`, `ser_descricao`, `ser_status`, `ser_tipo`, `sis_codigo`) VALUES ('2', 'Abertura de CNPJ', '1', 'Fiscal', '2');
INSERT INTO `portal_sindicato`.`ser_servico` (`ser_codigo`, `ser_descricao`, `ser_status`, `ser_tipo`, `sis_codigo`) VALUES ('3', 'Rescisão', '1', 'RH', '1');
INSERT INTO `portal_sindicato`.`ser_servico` (`ser_codigo`, `ser_descricao`, `ser_status`, `ser_tipo`, `sis_codigo`) VALUES ('4', 'Declaração RAIS', '0', 'RH', '1');
INSERT INTO `portal_sindicato`.`ser_servico` (`ser_codigo`, `ser_descricao`, `ser_status`, `ser_tipo`, `sis_codigo`) VALUES ('5', 'Cadastro de sócios', '1', 'Fiscal', '2');

INSERT INTO `portal_sindicato`.`pub_publicacao` (`pub_codigo`, `pub_datacadastro`, `pub_datainicio`, `pub_descricao`, `pub_status`, `pub_tipo`, `sin_codigo`) VALUES ('1', '2019-05-24', '2019-05-24', 'Anuncio 1', '1', '1', '1');
INSERT INTO `portal_sindicato`.`pub_publicacao` (`pub_codigo`, `pub_datacadastro`, `pub_datainicio`, `pub_datatermino`, `pub_endereco`, `pub_descricao`, `pub_status`, `pub_tipo`, `sin_codigo`) VALUES ('2', '2019-05-01', '2019-05-01', '2019-05-01', 'Rua Dom Bosco 78', 'Curso de capacitação', '0', '0', '1');
INSERT INTO `portal_sindicato`.`pub_publicacao` (`pub_codigo`, `pub_datacadastro`, `pub_datainicio`, `pub_datatermino`, `pub_endereco`, `pub_descricao`, `pub_status`, `pub_tipo`, `sin_codigo`) VALUES ('3', '2019-04-14', '2019-05-05', '2019-05-08', 'Recinto de Exposições Sindicato Rural de Lorena', 'Curso de Apicultura', '1', '0', '2');
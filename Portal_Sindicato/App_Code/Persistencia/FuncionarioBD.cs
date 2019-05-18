using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using classes;
using System.Data;

namespace persistencia
{

    /// <summary>
    /// Descrição resumida de FuncionarioBD
    /// </summary>
    public class FuncionarioBD
    {
        //métodos
        //insert
        public bool Insert(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO pes_pessoas( pes_codigo, pes_permissao_administrador, pes_nome, pes_senha, pes_cpf, pes_nascimento, pes_dataadm, pes_endereco, pes_email, pes_contato, sin_codigo, set_codigo) VALUES (?permissaoAdministrador, ?nome, ?senha, ?cpf, ?nascimento, ?dataadm, ?endereco, ?email, ?contato, ?sindicato, ?setor)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?permissaoAdministrador", funcionario.PermissaoAdministrador));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", funcionario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", funcionario.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?nascimento", funcionario.Nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?dataadm", funcionario.Dataadm));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", funcionario.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?email", funcionario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", funcionario.Contato));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", funcionario.Sindicato.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", funcionario.Setor.Codigo));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //selectall
        //select
        //update
        //delete
        //construtor

        public FuncionarioBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
using Classe;
using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Persistencia
{
    /// <summary>
    /// Descrição resumida de PessoasBD
    /// </summary>
    public class PessoasBD
    {
        //métodos
        //insert
        public bool Insert(Pessoas pessoas)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO pes_pessoas(pes_nome, pes_senha, pes_cpf, pes_nascimento, pes_dataadm, pes_datadem, pes_endereco, pes_email, pes_contato) VALUES (?nome, ?senha, ?cpf, ?nascimento, ?dataadm, ?datadem, ?endereco, ?email, ?contato)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", pessoas.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", pessoas.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", pessoas.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?nascimento", pessoas.Nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?dataadm", pessoas.Dataadm));
            objCommand.Parameters.Add(Mapped.Parameter("?datadem", pessoas.Datadem));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", pessoas.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?email", pessoas.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", pessoas.Contato));
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
        public PessoasBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
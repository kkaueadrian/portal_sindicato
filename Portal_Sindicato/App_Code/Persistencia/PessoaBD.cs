using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace persistencia
{
    /// <summary>
    /// Descrição resumida de PessoaBD
    /// </summary>
    public class PessoaBD
    {
        public Pessoa Autentica(string email, string senha)
        {
            Pessoa obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa WHERE pes_email = ?email and pes_senha = ?senha", objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?email", email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
            objDataReader = objCommand.ExecuteReader();

            while (objDataReader.Read())
            {
                obj = new Pessoa();
                obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pes_nome"]);
                obj.Email = Convert.ToString(objDataReader["pes_email"]);
                obj.Tipo = Convert.ToInt32(objDataReader["pes_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public Pessoa Select(int id)
        {
            Pessoa obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa WHERE pes_codigo = ?codigo",
           objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Pessoa();
                obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pes_nome"]);
                obj.Email = Convert.ToString(objDataReader["pes_email"]);
                obj.Tipo = Convert.ToInt32(objDataReader["pes_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public PessoaBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
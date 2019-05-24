using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PublicacaoBD
/// </summary>

namespace persistencia
{
    public class PublicacaoBD
    {
        //métodos
        //insert
        public bool Insert(Publicacao publicacao)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO pub_publicacao(pub_datacadastro, pub_datainicio, pub_datatermino, pub_endereco, pub_descricao, pub_status, pub_tipo, pub_imagem, sin_codigo) VALUES (?datacadastro, ?datainicio, ?datatermino, ?endereco, ?descricao, ?status, ?tipo, ?imagem, ?sindicato)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?datacadastro", publicacao.DataCadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?datainicio", publicacao.DataInicio));
            objCommand.Parameters.Add(Mapped.Parameter("?datatermino", publicacao.DataTermino));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", publicacao.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", publicacao.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?status", publicacao.Status));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", publicacao.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?imagem", publicacao.Imagem));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", publicacao.Sindicato.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pub_publicacao", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public DataSet SelectAllWithSindicate()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pub_publicacao p inner join sin_sindicato s on p.sin_codigo = s.sin_codigo", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public DataSet SelectAllByStatus()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pub_publicacao WHERE pub_status = 1", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Publicacao Select(int id)
        {
            Publicacao obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pub_publicacao WHERE pub_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Publicacao();
                obj.Codigo = Convert.ToInt32(objDataReader["pub_codigo"]);
                obj.DataCadastro = Convert.ToDateTime(objDataReader["pub_datacadastro"]);
                obj.DataInicio = Convert.ToDateTime(objDataReader["pub_datainicio"]);
                obj.DataTermino = Convert.ToDateTime(objDataReader["pub_datatermino"]);
                obj.Endereco = Convert.ToString(objDataReader["pub_endereco"]);
                obj.Descricao = Convert.ToString(objDataReader["pub_descricao"]);
                obj.Status = Convert.ToBoolean(objDataReader["pub_status"]);
                obj.Tipo = Convert.ToString(objDataReader["pub_tipo"]);
                obj.Imagem = Convert.ToString(objDataReader["pub_imagem"]);

                //método para buscar todos os campos do sindicato
                SindicatoBD sindicatoBD = new SindicatoBD();
                Sindicato sindicato = sindicatoBD.Select(Convert.ToInt32(objDataReader["sin_sindicato"]));               
                obj.Sindicato = sindicato;

                //método para buscar somente o código do sindicato
                //Sindicato sindicato = new Sindicato();
                //sindicato.Codigo = Convert.ToInt32(objDataReader["sin_sindicato"]);
                //obj.Sindicato = sindicato;
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //update
        public bool Update(Publicacao publicacao)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE pub_publicacao(pub_datacadastro, pub_datainicio, pub_datatermino, pub_endereco, pub_descricao, pub_status, pub_tipo, pub_imagem, sin_sindicato) VALUES (?datacadastro, ?datainicio, ?datatermino, ?endereco, ?descricao, ?status, ?tipo, ?imagem, ?sindicato)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?datacadastro", publicacao.DataCadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?datainicio", publicacao.DataInicio));
            objCommand.Parameters.Add(Mapped.Parameter("?datatermino", publicacao.DataTermino));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", publicacao.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", publicacao.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?status", publicacao.Status));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", publicacao.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?imagem", publicacao.Imagem));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", publicacao.Sindicato.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM pub_publicacao WHERE pub_codigo = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //construtor
        public PublicacaoBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }

    }
}
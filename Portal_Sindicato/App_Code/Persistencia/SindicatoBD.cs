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
    /// Descrição resumida de SindicatoBD
    /// </summary>
    public class SindicatoBD
    {
        //métodos
        //insert
        public bool Insert(Sindicato sindicato)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO sin_sindicato(sin_cnpj, sin_razao_social, sin_endereco, sin_contato, sin_ativo) VALUES (?cnpj, ?razaoSocial, ?endereco, ?contato, ?ativo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?cnpj", sindicato.Cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?razaoSocial", sindicato.RazaoSocial));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", sindicato.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", sindicato.Contato));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", sindicato.Ativo));
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
            objCommand = Mapped.Command("SELECT * FROM sin_sindicato", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Sindicato Select(int id)
        {
            Sindicato obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM sin_sindicato WHERE sin_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Sindicato();
                obj.Codigo = Convert.ToInt32(objDataReader["sin_codigo"]);
                obj.Cnpj = Convert.ToString(objDataReader["sin_cnpj"]);
                obj.RazaoSocial = Convert.ToString(objDataReader["sin_razao_social"]);
                obj.Endereco = Convert.ToString(objDataReader["sin_endereco"]);
                obj.Contato = Convert.ToString(objDataReader["sin_contato"]);
                obj.Ativo = Convert.ToBoolean(objDataReader["sin_ativo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Sindicato sindicato)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE sin_sindicato SET sin_cnpj=?cnpj, sin_razao_social=?razaosocial, sin_endereco=?endereco, sin_contato=?contato, sin_ativo=?ativo WHERE sin_codigo =?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", sindicato.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?cnpj", sindicato.Cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?razaosocial", sindicato.RazaoSocial));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", sindicato.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", sindicato.Contato));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", sindicato.Ativo));
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
        string sql = "DELETE FROM sin_sindicato WHERE sin_codigo=?codigo";
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
    public SindicatoBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
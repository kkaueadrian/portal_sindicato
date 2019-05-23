using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FATEC;
using classes;
using System.Data;

namespace persistencia
{
    /// <summary>
    /// Descrição resumida de SetorBD
    /// </summary>
    public class SetorBD
    {
        //métodos
        //insert
        public bool Insert(Setor setor)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO set_setor(set_tipo) VALUES (?tipo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", setor.Tipo));
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
            objCommand = Mapped.Command("SELECT * FROM set_setor", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Setor Select(int id)
        {
            Setor obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM set_setor WHERE set_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Setor();
                obj.Codigo = Convert.ToInt32(objDataReader["set_codigo"]);
                obj.Tipo = Convert.ToString(objDataReader["set_tipo"]);
                
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        //delete
        //construtor
        public SetorBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
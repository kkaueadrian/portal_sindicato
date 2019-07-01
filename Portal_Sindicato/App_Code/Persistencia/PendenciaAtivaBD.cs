using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace persistencia
{

    /// <summary>
    /// Descrição resumida de PendenciaAtivaBD
    /// </summary>
    public class PendenciaAtivaBD
    {
        public bool Insert(PendenciaAtiva pendenciaAtiva)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO atv_pendencia(atv_quantidade, atv_data) VALUES (?quantidade, ?data)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", pendenciaAtiva.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?data", pendenciaAtiva.Data));
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
            objCommand = Mapped.Command("SELECT * FROM atv_pendencia", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public PendenciaAtiva Select(string data)
        {
            PendenciaAtiva obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM atv_pendencia WHERE atv_data = ?data", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?data", data));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new PendenciaAtiva();
                obj.Codigo = Convert.ToInt32(objDataReader["atv_codigo"]);
                obj.Data = Convert.ToDateTime(objDataReader["atv_data"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["atv_quantidade"]);

            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        public Boolean SelectLast(string data)
        {
            PendenciaAtiva obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM atv_pendencia WHERE atv_data = ?data", objConexao);
           
            objCommand.Parameters.Add(Mapped.Parameter("?data", data));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new PendenciaAtiva();
                obj.Codigo = Convert.ToInt32(objDataReader["atv_codigo"]);
                obj.Data = Convert.ToDateTime(objDataReader["atv_data"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["atv_quantidade"]);



            }

            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            if (obj == null)
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        public bool Update(PendenciaAtiva pendenciaAtiva)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE atv_pendencia SET atv_quantidade=?quantidade WHERE atv_codigo =?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", pendenciaAtiva.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", pendenciaAtiva.Quantidade));
           
            
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        public PendenciaAtivaBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
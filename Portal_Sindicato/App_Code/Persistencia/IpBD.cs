using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace persistencia { 

public class IpBD
{

        public bool Insert(Ip ip)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO ip_acesso(ip_endereco, ip_data) VALUES (?endereco, ?data)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", ip.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?data", ip.Data));
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
            objCommand = Mapped.Command("select count(distinct ip_codigo), ip_data from ip_acesso group by year(ip_data), month(ip_data), day(ip_data)", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        public Boolean Select(string endereco, string data)
        {
            Ip obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM ip_acesso WHERE ip_endereco = ?endereco and ip_data = ?data", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?data", data));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Ip();
                obj.Codigo = Convert.ToInt32(objDataReader["ip_codigo"]);
                obj.Data = Convert.ToDateTime(objDataReader["ip_data"]);
                obj.Endereco = Convert.ToString(objDataReader["ip_endereco"]);


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

        public IpBD()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    }
}

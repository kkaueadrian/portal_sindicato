using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using classes;
using System.Data;

namespace persistencia
{

    public class LogonBD
    {

        public bool Insert(Logon logon)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO log_login(log_hora, pes_codigo) VALUES (?tempo, ?pessoa)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?tempo", logon.Tempo));
            objCommand.Parameters.Add(Mapped.Parameter("?pessoa", logon.Pessoa.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        public DataSet CountLogin()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("select day(log_hora), month(log_hora), year(log_hora), count(distinct log_codigo) from log_login group by year(log_hora), month(log_hora), day(log_hora)", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        public LogonBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
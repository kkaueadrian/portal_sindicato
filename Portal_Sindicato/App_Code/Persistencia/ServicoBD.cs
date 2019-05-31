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
    /// Descrição resumida de ServicoBD
    /// </summary>
    public class ServicoBD

    {
        public bool Insert(Servico servico)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO ser_servico(ser_descricao, ser_status, ser_tipo, set_codigo ) VALUES ( ?descricao, ?status, ?tipo, ?setor)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", servico.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?status", servico.Status));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", servico.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", servico.Setor.Codigo));
            
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
            objCommand = Mapped.Command("SELECT * FROM ser_servico", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public DataSet SelectAllWithsectorandsindicate()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM ser_servico s inner join sin_sindicato si on s.sin_codigo = si.sin_codigo inner join set_setor se on s.set_codigo = se.set_codigo order by ser_codigo", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM ser_servico WHERE ser_codigo = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }


        public ServicoBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
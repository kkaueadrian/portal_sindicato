using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PendenciaBD
/// </summary>
public class PendenciaBD
{
    public bool Insert(Pendencia pendencia)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO pen_pendencia(pen_tipo, pen_documento, pes_codigo) VALUES (?tipo, ?documento, ?associado)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?tipo", pendencia.Tipo));
        objCommand.Parameters.Add(Mapped.Parameter("?documento", pendencia.Documento));
        objCommand.Parameters.Add(Mapped.Parameter("?associado", pendencia.Associado.Codigo));
        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }

    public DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
       
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    public DataSet SelectAllWithAssociate()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia pe inner join pes_pessoa pa on pe.pes_codigo = pa.pes_codigo order by pen_codigo ", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);

        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    public DataSet SelectAllByUser(int userid)
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia  WHERE pes_codigo = ?codigo and pen_status = 1", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", userid));
        objDataAdapter = Mapped.Adapter(objCommand);

        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    public Pendencia SelectSpecific(int id)
    {
        Pendencia obj = null;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia WHERE pes_codigo = ?codigo", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            obj = new Pendencia();
            obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
            obj.Tipo = Convert.ToString(objDataReader["pen_tipo"]);
            obj.Documento = Convert.ToString(objDataReader["pen_documento"]);

        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return obj;
    }

    public DataSet SearchAllWithAssociate(string termo)
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia pe inner join pes_pessoa pa on pe.pes_codigo = pa.pes_codigo where pes_nome like ?termo order by pen_codigo ", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objCommand.Parameters.Add(Mapped.Parameter("?termo", termo));

        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }
    public DataSet CountTer()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("select pen_datatermino, count(distinct pen_codigo) from pen_pendencia   group by day(pen_datatermino), month(pen_datatermino), year(pen_datatermino)", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }
    public int CountAtv()
    {
        int obj = 0;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("select  count(distinct pen_codigo) from pen_pendencia where pen_status = 1", objConexao);
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
             obj = Convert.ToInt32(objDataReader["count(distinct pen_codigo)"]);
        }
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return obj;
    }
    //select
    public Pendencia Select(int id)
    {
        Pendencia obj = null;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM pen_pendencia WHERE pen_codigo = ?codigo", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            obj = new Pendencia();
            obj.Codigo = Convert.ToInt32(objDataReader["pen_codigo"]);
            obj.Tipo = Convert.ToString(objDataReader["pen_tipo"]);
            obj.Status = Convert.ToBoolean(objDataReader["pen_status"]);

        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return obj;
    }



    public bool UpdateStatus(Pendencia pendencia)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "UPDATE pen_pendencia SET pen_status = ?status WHERE pen_codigo = ?codigo";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", pendencia.Codigo));
        objCommand.Parameters.Add(Mapped.Parameter("?status", pendencia.Status));
        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }
    public bool UpdateStatusAndSetTime(Pendencia pendencia)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "UPDATE pen_pendencia SET pen_status = ?status, pen_datatermino = ?data WHERE pen_codigo = ?codigo";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", pendencia.Codigo));
        objCommand.Parameters.Add(Mapped.Parameter("?status", pendencia.Status));
        objCommand.Parameters.Add(Mapped.Parameter("?data", pendencia.DataTermino));
        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }

    public PendenciaBD()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}
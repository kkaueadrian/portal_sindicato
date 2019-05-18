using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FATEC;
using classes;

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
        //select
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
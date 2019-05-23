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
    /// Descrição resumida de SindicatoSetorBD
    /// </summary>
    public class SindicatoSetorBD
    {
        //métodos
        //insert
        public bool Insert(SindicatoSetor sindicatoSetor)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO sis_sindicato_setor(sin_codigo, set_codigo) VALUES (?sindicato, ?setor)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", sindicatoSetor.Sindicato.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", sindicatoSetor.Setor.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
    }
}
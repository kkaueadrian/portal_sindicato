using classes;
using FATEC;
using System;
using System.Collections.Generic;
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
            string sql = "INSERT INTO ser_servico(ser_descricao, ser_status, ser_tipo, set_codigo, sin_codigo) VALUES ( ?descricao, ?status, ?tipo, ?setor, ?sindicato)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", servico.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?status", servico.Status));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", servico.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", servico.Setor.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", servico.Sindicato.Codigo));
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
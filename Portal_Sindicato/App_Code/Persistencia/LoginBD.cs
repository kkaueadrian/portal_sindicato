using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace persistencia
{

    public class LoginBD
    {

        public bool Insert(Login login)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO ser_servico(ser_descricao, ser_status, ser_tipo, set_codigo) VALUES ( ?descricao, ?status, ?tipo, ?setor)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", login.Tempo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", login.Pessoa.Codigo));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        public LoginBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
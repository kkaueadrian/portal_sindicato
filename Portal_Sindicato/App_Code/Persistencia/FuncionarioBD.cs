using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classe;
using System.Data;

namespace Persistencia
{

    /// <summary>
    /// Descrição resumida de FuncionarioBD
    /// </summary>
    public class FuncionarioBD
    {
        //métodos
        //insert
        public bool Insert(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO fun_funcionario(fnc_permissao_administrador, set_codigo, pes_codigo, sin_codigo) VALUES (?nome, ?salario, ?cracha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?permissao_administrador", funcionario.permissao_administrador));
            objCommand.Parameters.Add(Mapped.Parameter("?", funcionario.));
            objCommand.Parameters.Add(Mapped.Parameter("?", funcionario.));
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

        public FuncionarioBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de SindicatoBD
/// </summary>
public class SindicatoBD
{
    //métodos
    //insert
    public bool Insert(Sindicato sindicato)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO sin_sindicato(sin_cnpj, sin_razao_social, sin_endereco, sin_contato, sin_ativo) VALUES (?cnpj, ?razaoSocial, ?endereco, ?contato, ?ativo)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?cnpj", sindicato.Cnpj));
        objCommand.Parameters.Add(Mapped.Parameter("?razaoSocial", sindicato.RazaoSocial));
        objCommand.Parameters.Add(Mapped.Parameter("?endereco", sindicato.Endereco));
        objCommand.Parameters.Add(Mapped.Parameter("?contato", sindicato.Contato));
        objCommand.Parameters.Add(Mapped.Parameter("?ativo", sindicato.Ativo));
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
    public SindicatoBD()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}
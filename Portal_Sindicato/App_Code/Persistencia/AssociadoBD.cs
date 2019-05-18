using classes;
using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace persistencia
{
    /// <summary>
    /// Descrição resumida de AssociadoBD
    /// </summary>
    public class AssociadoBD
    {
        public bool Insert(Associado associado)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO pes_pessoas( pes_codigo, pes_permissao_administrador, pes_nome, pes_senha, pes_cpf, pes_nascimento, pes_dataadm, pes_endereco, pes_email, pes_contato, sin_codigo, pes_cnpj, pes_ie, pes_caepf) VALUES (?permissaoAdministrador, ?nome, ?senha, ?cpf, ?nascimento, ?dataadm, ?endereco, ?email, ?contato, ?sindicato, ?cnpj, ?ie, ?caepf)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", associado.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", associado.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", associado.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?nascimento", associado.Nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?dataadm", associado.Dataadm));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", associado.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?email", associado.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", associado.Contato));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", associado.Sindicato.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?cnpj", associado.Cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?ie", associado.Ie));
            objCommand.Parameters.Add(Mapped.Parameter("?caepf", associado.Caepf));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        public AssociadoBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
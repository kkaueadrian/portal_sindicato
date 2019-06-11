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
    /// Descrição resumida de AssociadoBD
    /// </summary>
    public class AssociadoBD
    {
        public bool Insert(Associado associado)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO pes_pessoa( pes_nome, pes_senha, pes_cpf, pes_nascimento, pes_dataadm, pes_endereco, pes_email, pes_contato, sin_codigo, pes_cnpj, pes_ie, pes_caepf, pes_tipo) VALUES (?nome, ?senha, ?cpf, ?nascimento, ?dataadm, ?endereco, ?email, ?contato, ?sindicato, ?cnpj, ?ie, ?caepf, ?tipo)";
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
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", associado.Tipo));


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
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa where pes_tipo = 0", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }        public DataSet SelectAllWithSindicate()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa INNER JOIN sin_sindicato ON pes_pessoa.sin_codigo = sin_sindicato.sin_codigo where pes_pessoa.pes_tipo = 0 order by pes_codigo ", objConexao);
           
           
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Associado Select(int id)
        {
            Associado obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa WHERE pes_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Associado();
                obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pes_nome"]);
                obj.Senha = Convert.ToString(objDataReader["pes_senha"]);
                obj.Cpf = Convert.ToString(objDataReader["pes_cpf"]);
                obj.Nascimento = Convert.ToDateTime(objDataReader["pes_nascimento"]);
                obj.Dataadm = Convert.ToDateTime(objDataReader["pes_dataadm"]);
                obj.Endereco = Convert.ToString(objDataReader["pes_endereco"]);
                obj.Email = Convert.ToString(objDataReader["pes_email"]);
                obj.Contato = Convert.ToString(objDataReader["pes_contato"]);
                
                obj.Cnpj = Convert.ToString(objDataReader["pes_cnpj"]);
                obj.Ie = Convert.ToString(objDataReader["pes_ie"]);
                obj.Caepf = Convert.ToString(objDataReader["pes_caepf"]);

            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //update
        public bool Update(Associado associado)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE pes_pessoa SET pes_nome = ?nome, pes_senha = ?senha, pes_cpf = ?cpf, pes_nascimento = ?nascimento, pes_dataadm = ?dataadm, pes_endereco = ?endereco, pes_email = ?email, pes_contato = ?contato, sin_codigo = ?sindicato, pes_cnpj = ?cnpj, pes_ie = ?ie, pes_caepf = ?caepf  WHERE pes_codigo = ?codigo";
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
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", associado.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        public bool UpdatePassword(Associado associado)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE pes_pessoa SET pes_senha = ?senha";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?senha", associado.Senha));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
            //delete
            public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM pes_pessoa WHERE pes_codigo = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //login

        
        public AssociadoBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
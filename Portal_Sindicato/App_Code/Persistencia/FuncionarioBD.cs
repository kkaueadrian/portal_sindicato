using FATEC;
using classes;
using System.Data;
using System;

namespace persistencia
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
            string sql = "INSERT INTO pes_pessoa( pes_permissao_administrador, pes_nome, pes_senha, pes_cpf, pes_nascimento, pes_dataadm, pes_endereco, pes_email, pes_contato, sin_codigo, set_codigo, pes_tipo) VALUES (?permissaoAdministrador, ?nome, ?senha, ?cpf, ?nascimento, ?dataadm, ?endereco, ?email, ?contato, ?sindicato, ?setor, ?tipo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?permissaoAdministrador", funcionario.PermissaoAdministrador));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", funcionario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", funcionario.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?nascimento", funcionario.Nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?dataadm", funcionario.Dataadm));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", funcionario.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?email", funcionario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", funcionario.Contato));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", funcionario.Sindicato.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", funcionario.Setor.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", funcionario.Tipo));

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
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa where tipo = 1", objConexao);
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
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa p inner join sin_sindicato si on p.sin_codigo = si.sin_codigo inner join set_setor se on p.set_codigo = se.set_codigo  where pes_tipo = 1", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Funcionario Select(int id)
        {
            Funcionario obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pes_pessoa WHERE pes_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Funcionario();
                obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
                obj.Codigo = Convert.ToInt32(objDataReader["pes_permissao_administrador"]);
                obj.Nome = Convert.ToString(objDataReader["pes_nome"]);
                obj.Senha = Convert.ToString(objDataReader["pes_senha"]);
                obj.Cpf = Convert.ToString(objDataReader["pes_cpf"]);
                obj.Nascimento = Convert.ToDateTime(objDataReader["pes_nascimento"]);
                obj.Dataadm = Convert.ToDateTime(objDataReader["pes_dataadm"]);
                obj.Endereco = Convert.ToString(objDataReader["pes_endereco"]);
                obj.Email = Convert.ToString(objDataReader["pes_email"]);
                obj.Contato = Convert.ToString(objDataReader["pes_contato"]);

               

            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE pes_pessoa SET pes_permissao_administrador = ?permissaoAdministrador, pes_nome = ?nome, pes_senha = ?senha, pes_cpf = ?cpf, pes_nascimento = ?nascimento, pes_dataadm = ?dataadm, pes_endereco = ?endereco, pes_email = ?email, pes_contato = ?contato, sin_codigo = ?sindicato, set_codigo = ?setor  WHERE pes_codigo = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?permissaoAdministrador", funcionario.PermissaoAdministrador));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", funcionario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", funcionario.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?nascimento", funcionario.Nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?dataadm", funcionario.Dataadm));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", funcionario.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?email", funcionario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?contato", funcionario.Contato));
            objCommand.Parameters.Add(Mapped.Parameter("?sindicato", funcionario.Sindicato.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?setor", funcionario.Setor.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", funcionario.Codigo));
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
        //construtor

        public FuncionarioBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}
using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Login : System.Web.UI.Page
{

    private bool IsPreenchido(string str)
    {
        bool retorno = false;
        if (str != string.Empty)
        {
            retorno = true;
        }
        return retorno;
    }
    private bool UsuarioEncontrado(Pessoa pessoa)
    {
        bool retorno = false;
        if (pessoa != null)
        {
            retorno = true;
        }
        return retorno;
    }    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        string cpf = txtCpf.Text.Trim();
        string senha = txtSenha.Text.Trim();
        if (!IsPreenchido(cpf))
        {
            lblMensagem.Text = "Preencha o email";
            txtCpf.Focus();
            return;
        }
        if (!IsPreenchido(senha))
        {
            lblMensagem.Text = "Preencha a senha";
            txtSenha.Focus();
            return;
        }
        PessoaBD bd = new PessoaBD();
        Pessoa pessoa = new Pessoa();
        pessoa = bd.Autentica(cpf, senha);
        if (!UsuarioEncontrado(pessoa))
        {
            lblMensagem.Text = "Usuário não encontrado";
            txtCpf.Focus();
            return;
        }
        Session["ID"] = pessoa.Codigo;
        PessoaBD pessoabd = new PessoaBD();
        Pessoa pescod = pessoabd.Select(Convert.ToInt32(Session["ID"]));

        Logon logon = new Logon();
        logon.Pessoa = pescod;
        var time = DateTime.Now;
        string formattedTime = time.ToString("yyyy/MM/dd hh:mm:ss");
        logon.Tempo = Convert.ToDateTime(formattedTime);
        LogonBD bl= new LogonBD();
        bl.Insert(logon);
            switch (pessoa.Tipo)
        {

            case 0:
                Response.Redirect("HomeAssociado.aspx");
                break;
            case 1:
                Response.Redirect("HomeFuncionario.aspx");
                break;
            default:
                break;
        }
    }
}
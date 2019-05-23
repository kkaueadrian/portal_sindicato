using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_HomeAssociado : System.Web.UI.Page
{
    private bool IsAssociado(int tipo)
    {
        bool retorno = false;
        if (tipo == 0)
        {
            retorno = true;
        }
        return retorno;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(Session["ID"]);
        PessoaBD bd = new PessoaBD();
        Pessoa pessoa = bd.Select(codigo);
        if (!IsAssociado(pessoa.Tipo))
        {
            Response.Redirect("AcessoNegado.aspx");
        }
        else
        {
            lblTitulo.Text = "Bem vindo " + pessoa.Nome + " o que deseja fazer hoje:";
        }
    }

    protected void lbSair_Click(object sender, EventArgs e)
    {
        
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        
    }
}
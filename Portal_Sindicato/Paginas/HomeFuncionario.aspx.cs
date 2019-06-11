using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_HomeFuncionario : System.Web.UI.Page
{
    private bool IsFuncionario(int tipo)
    {
        bool retorno = false;
        if (tipo == 1)
        {
            retorno = true;
        }
        return retorno;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(Session["ID"]);
        FuncionarioBD bd = new FuncionarioBD();
        Funcionario funcionario = bd.Select(codigo);
        
        if (!IsFuncionario(funcionario.Tipo))
        {
            Response.Redirect("AcessoNegado.aspx");
        }
        else
        {
            if(funcionario.PermissaoAdministrador == false)
            {
                hlFuncionario.Visible=false;
            }
            lblTitulo.Text = "Bem vindo  " + funcionario.Nome + " o que deseja fazer hoje";

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
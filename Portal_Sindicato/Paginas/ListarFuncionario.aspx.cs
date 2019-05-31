using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using classes;
using persistencia;


public partial class Paginas_ListarFuncionario : System.Web.UI.Page
{
    private void Carrega()
    {
        FuncionarioBD bd = new FuncionarioBD();
        DataSet ds = bd.SelectAllWithsectorandsindicate();
        gvFuncionario.DataSource = ds.Tables[0].DefaultView;
        gvFuncionario.DataBind();
    }
    

    protected void Page_Load(object sender, EventArgs e)
    {
        FuncionarioBD bd = new FuncionarioBD();
        DataSet ds = bd.SelectAllWithsectorandsindicate();
        //verifica a quantidade de associados no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {


            gvFuncionario.DataSource = ds.Tables[0].DefaultView;
            gvFuncionario.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " Funcionários cadastrados";
        }
        else
        {
            lblMensagem.Text = "Nenhum Funcionario cadastrado";
        }
        Carrega();

    }

    protected void gvFuncionario_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("AlterarFuncionario.aspx");
                break;
            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                FuncionarioBD bd = new FuncionarioBD();
                bd.Delete(codigo);
                Carrega();
                break;
            default:
                break;
        }
    }
}
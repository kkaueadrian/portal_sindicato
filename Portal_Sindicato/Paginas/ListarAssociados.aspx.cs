using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using persistencia;
using classes;

public partial class Paginas_ListarAssociados : System.Web.UI.Page
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
    private void Carrega()
    {
        AssociadoBD bd = new AssociadoBD();
        DataSet ds = bd.SelectAllWithSindicate();
        grvAssociados.DataSource = ds.Tables[0].DefaultView;
        grvAssociados.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(Session["ID"]);
        PessoaBD bf = new PessoaBD();
        Pessoa pessoa = bf.Select(codigo);
        if (!IsFuncionario(pessoa.Tipo))
        {
            Response.Redirect("AcessoNegado.aspx");
        }

        AssociadoBD bd = new AssociadoBD();
        DataSet ds = bd.SelectAllWithSindicate();
        //verifica a quantidade de associados no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        { 
            
 
            grvAssociados.DataSource = ds.Tables[0].DefaultView;
            grvAssociados.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " Associados cadastrados";
        }
        else
        {
            lblMensagem.Text = "Nenhum Associado cadastrado";
        }
        Carrega();

        
    }



    protected void grvAssociados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("AlterarAssociado.aspx");
                break;

            case "AlterarSenha":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("AlterarAssociado.aspx");
                break;

            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                AssociadoBD bd = new AssociadoBD();
                bd.Delete(codigo);
                Carrega();
                break;
            default:
                break;
        }
    }
}

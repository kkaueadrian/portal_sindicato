using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_ListarServico : System.Web.UI.Page
{
    private void Carrega()
    {
        ServicoBD bd = new ServicoBD();
        DataSet ds = bd.SelectAllWithsector();
        gvServico.DataSource = ds.Tables[0].DefaultView;
        gvServico.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ServicoBD bd = new ServicoBD();
        DataSet ds = bd.SelectAllWithsector();
        //verifica a quantidade de associados no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {


            gvServico.DataSource = ds.Tables[0].DefaultView;
            gvServico.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " Servico cadastrados";
        }
        else
        {
            lblMensagem.Text = "Nenhum Servico cadastrado";
        }
        Carrega();

    
}



    protected void gvServico_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            
            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                ServicoBD bd = new ServicoBD();
                bd.Delete(codigo);
                Carrega();
                break;
            default:
                break;
        }
    }
}
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_HomePublicacoes : System.Web.UI.Page
{
    private void Carrega()
    {
        PublicacaoBD bd = new PublicacaoBD();
        DataSet ds = bd.SelectAllByStatus();
        //verifica a quantidade de publicações no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {


            gvPublicacao.DataSource = ds.Tables[0].DefaultView;
            gvPublicacao.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " Publicações Ativas";
        }
        else
        {
            lblMensagem.Text = "Nenhuma Publicação Ativa!";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        Carrega();
    }


    protected void gvPublicacao_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            string foto = Convert.ToString(drv["pub_imagem"]);
            if (foto != string.Empty)
            {
                e.Row.Cells[0].Text = "<img src='http://localhost:54428/Upload/" + foto + "'style = 'width:250px' /> ";
            }
        }
    }
}
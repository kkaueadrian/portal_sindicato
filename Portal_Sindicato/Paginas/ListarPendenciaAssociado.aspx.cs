using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_ListarPendenciaAssociado : System.Web.UI.Page
{
    private void Carrega()
    {
        PendenciaBD bd = new PendenciaBD();
        DataSet ds = bd.SelectAllByUser(Convert.ToInt32(Session["ID"]));
        grvPendencias.DataSource = ds.Tables[0].DefaultView;
        grvPendencias.DataBind();
        //verifica a quantidade de associados no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {


            grvPendencias.DataSource = ds.Tables[0].DefaultView;
            grvPendencias.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " Pendências cadastrados";
        }
        else
        {
            lblMensagem.Text = "Nenhuma Pendencia cadastrado";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Carrega();
        }

    }
   



    protected void grvPendencias_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView dr = (DataRowView)e.Row.DataItem;
           // int codigo = Convert.ToInt32( dr["pen_codigo"]);
            string documento = Convert.ToString(dr["pen_documento"]);

            e.Row.Cells[1].Text = "<a href='http://localhost:54428/Upload/" + documento  + "' target='_blank'>Download</a>";
        }
    }
}
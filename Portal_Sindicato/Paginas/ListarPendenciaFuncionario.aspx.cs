using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_ListarPendenciaFuncionario : System.Web.UI.Page
{
    private void Carrega()
    {
        PendenciaBD bd = new PendenciaBD();
        DataSet ds = bd.SelectAllWithAssociate();
        gvPendencias.DataSource = ds.Tables[0].DefaultView;
        gvPendencias.DataBind();
        //verifica a quantidade de associados no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {


            gvPendencias.DataSource = ds.Tables[0].DefaultView;
            gvPendencias.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " Pendencias cadastrados";
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
        protected DataRow GetLastRow()
        {
            PendenciaAtivaBD ba = new PendenciaAtivaBD();
            DataSet da = ba.SelectAll();

            DataRow dr = (DataRow)da.Tables[0].Rows[da.Tables[0].Rows.Count - 1];
            return dr;
        }
        DateTime data = dr.Data;



    }

    protected void gvPendencias_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView dr = (DataRowView)e.Row.DataItem;
            // int codigo = Convert.ToInt32( dr["pen_codigo"]);
            string documento = Convert.ToString(dr["pen_documento"]);

            e.Row.Cells[2].Text = "<a href='http://localhost:54428/Upload/" + documento + "' target='_blank'>Download</a>";
        }
    }

    protected void gvPendencias_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "AlterarStatus":
                codigo = Convert.ToInt32(e.CommandArgument);
                int oldId = Convert.ToInt32(Convert.ToInt32(Session["ID"]));
                Session["ID"] = codigo;
                Response.Redirect("AlterarStatus.aspx?Parametro="+oldId);
                break;
        }
    }

    protected void lbPesquisar_Click(object sender, EventArgs e)
    {
        string termo = txtPesquisar.Text;
        Response.Redirect("PesquisarPendencias.aspx?Parametro="+termo);
    }

    
}
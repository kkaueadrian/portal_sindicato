using classes;
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

        PendenciaBD bd = new PendenciaBD();
        int qtd = bd.CountAtv();

        PendenciaAtivaBD ba = new PendenciaAtivaBD();
        DataSet da = ba.SelectAll();

        int cod = Convert.ToInt32(da.Tables[0].Rows.Count);

        PendenciaAtiva pendenciaAtiva = ba.Select(cod);
        
        string formattedTime = Convert.ToDateTime(pendenciaAtiva.Data).ToString("yyyy/MM/dd");

        var time2 = DateTime.Now;
        string formattedTime2 = time2.ToString("yyyy/MM/dd");
        string formattedTime3 = time2.ToString("yyyy/MM/dd hh:mm:ss");



        if (formattedTime == formattedTime2)
        {

            pendenciaAtiva.Quantidade = qtd;
            ba.Update(pendenciaAtiva);

        }
        else {
            pendenciaAtiva.Quantidade = qtd;
            pendenciaAtiva.Data = Convert.ToDateTime(formattedTime3);
            ba.Insert(pendenciaAtiva);

        }










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
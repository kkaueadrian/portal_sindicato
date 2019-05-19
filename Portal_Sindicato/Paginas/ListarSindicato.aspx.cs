﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using persistencia;
using System.Data;

public partial class Paginas_ListarSindicato : System.Web.UI.Page
{
    private void Carrega()
    {
        SindicatoBD bd = new SindicatoBD();
        DataSet ds = bd.SelectAll();
        gvSindicato.DataSource = ds.Tables[0].DefaultView;
        gvSindicato.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();





    }
    

    protected void gvSindicato_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("Alterar.aspx");
                break;
            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                SindicatoBD bd = new SindicatoBD();
                bd.Delete(codigo);
                Carrega();
                break;
            default:
                break;
        }
    }
}
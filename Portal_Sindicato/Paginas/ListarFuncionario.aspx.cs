﻿using System;
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
    public object GridView1 { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        private void Carrega()
        {
            FuncionarioBD bd = new FuncionarioBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrega();
        }
    }
}
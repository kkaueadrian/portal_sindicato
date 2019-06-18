using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_DadosEstatisticos : System.Web.UI.Page
{
    private void Carrega()
    {
        LogonBD bd = new LogonBD();
        DataSet ds = bd.SelectCountLogin();
       
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }





    protected void Logon_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        Carrega();
    }
}
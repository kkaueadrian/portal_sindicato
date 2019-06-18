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
        AssociadoBD bd = new AssociadoBD();
        DataSet ds = bd.SelectAllWithSindicate();
       
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
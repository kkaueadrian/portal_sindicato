using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_AlterarStatusAssociado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {




        AssociadoBD bd = new AssociadoBD();
        Associado associado = bd.Select(Convert.ToInt32(Session["ID"]));
        Boolean status = associado.Status;
        if (status == true)
        {
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy/MM/dd hh:mm:ss");
            associado.Datadem = Convert.ToDateTime(formattedTime);
            associado.Status = false;
            bd.UpdateStatusAssociado(associado);





        }
        else
        {
            associado.Status = true;
            bd.UpdateStatusAssociado(associado);

        }
        string id = Request.QueryString["Parametro"];
        Session["ID"] = id;
        Response.Redirect("ListarAssociados.aspx");



    }



    
}
using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_alterarStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

           
            PendenciaBD bd = new PendenciaBD();
            Pendencia pendencia = bd.Select(Convert.ToInt32(Session["ID"]));
        Boolean status = pendencia.Status;
        if (status == true)
        {
            pendencia.Status = false;
            bd.UpdateStatus(pendencia);
            


            

        }
        else
        {
            pendencia.Status = true;
            bd.UpdateStatus(pendencia);

        }
        string id = Request.QueryString["Parametro"];
        Session["ID"] = id;
        Response.Redirect("ListarPendenciaFuncionario.aspx");








    }

   
}
using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_AlterarSenhaAssociado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //carrega somente a primeira vez
       
        if (!Page.IsPostBack)
        {


            AssociadoBD bd = new AssociadoBD();
            Associado associado = bd.Select(Convert.ToInt32(Session["ID"]));
            txtSenha.Text = associado.Senha;
        


        }

    }

   


    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        AssociadoBD bd = new AssociadoBD();
        Associado associado = bd.Select(Convert.ToInt32(Session["ID"]));

        associado.Senha = txtSenha.Text;

        if (bd.UpdatePassword(associado))
        {
            lblMensagem.Text = "Senha alterada com sucesso ";
            txtSenha.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao Alterar.";
        }

    }
}
using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Alterar : System.Web.UI.Page
{
   

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
            if (!Page.IsPostBack)
            {
                SindicatoBD bd = new SindicatoBD();
                Sindicato sindicato = bd.Select(Convert.ToInt32(Session["ID"]));
                txtCnpj.Text = sindicato.Cnpj;
                txtRazaoSocial.Text = sindicato.RazaoSocial;
                txtEndereco.Text = sindicato.Endereco;
                txtContato.Text = sindicato.Contato;
                chkAtivo.Checked = sindicato.Ativo;

        }
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SindicatoBD bd = new SindicatoBD();
        Sindicato sindicato = bd.Select(Convert.ToInt32(Session["ID"]));
        sindicato.Cnpj = txtCnpj.Text;
        sindicato.RazaoSocial = txtRazaoSocial.Text;
        sindicato.Endereco = txtEndereco.Text;
        sindicato.Contato = txtContato.Text;
        sindicato.Ativo = chkAtivo.Checked;

        if (bd.Update(sindicato))
        {
            lblMensagem.Text = "Sindicato alterado com sucesso";
            txtCnpj.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}
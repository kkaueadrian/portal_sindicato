using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using classes;
using persistencia;

public partial class Paginas_CadastrarSindicato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Sindicato sindicato = new Sindicato();
        sindicato.Cnpj = txtCnpj.Text;
        sindicato.RazaoSocial = txtRazaoSocial.Text;
        sindicato.Endereco = txtEndereco.Text;
        sindicato.Contato = txtContato.Text;
        sindicato.Ativo = chkAtivo.Checked;

        SindicatoBD bd = new SindicatoBD();
        if (bd.Insert(sindicato))
        {
            lblMensagem.Text = "Sindicato cadastrado com sucesso";
            txtCnpj.Text = "";
            txtRazaoSocial.Text = "";
            txtEndereco.Text = "";
            txtContato.Text = "";
            chkAtivo.Checked = false;
            txtCnpj.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}

using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_AlterarAssociado : System.Web.UI.Page
{
    private void CarregaSindicatos()
    {
        SindicatoBD bd = new SindicatoBD();
        DataSet ds = bd.SelectAll();
        ddlSindicato.DataSource = ds.Tables[0].DefaultView;
        ddlSindicato.DataTextField = "sin_razao_social";
        ddlSindicato.DataValueField = "sin_codigo";
        ddlSindicato.DataBind();
        ddlSindicato.Items.Insert(0, "Selecione");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //carrega somente a primeira vez
        if (!Page.IsPostBack)
        {
            CarregaSindicatos();
            ddlSindicato.Focus();
        }
        if (!Page.IsPostBack)
        {
            

            AssociadoBD bd = new AssociadoBD();
            Associado associado = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = associado.Nome;
            txtCpf.Text = associado.Cpf;
            txtSenha.Text = associado.Senha;
            txtNascimento.Text = associado.Nascimento.ToString();
            txtDataadm.Text = associado.Dataadm.ToString();
            txtEndereco.Text = associado.Endereco;
            txtEmail.Text = associado.Email;
            txtContato.Text = associado.Contato;
            txtCnpj.Text = associado.Cnpj;
            txtIe.Text = associado.Ie;
            txtCaepf.Text = associado.Caepf;
    
            
        }

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        SindicatoBD sindicatobd = new SindicatoBD();
        Sindicato sindicato = sindicatobd.Select(Convert.ToInt32(ddlSindicato.SelectedItem.Value));

        AssociadoBD bd = new AssociadoBD();
        Associado associado = bd.Select(Convert.ToInt32(Session["ID"]));
        associado.Nome = txtNome.Text;
        associado.Cpf = txtCpf.Text;
        associado.Senha = txtSenha.Text;
        associado.Nascimento = Convert.ToDateTime(txtNascimento.Text);
        associado.Dataadm = Convert.ToDateTime(txtDataadm.Text);
        associado.Endereco = txtEndereco.Text;
        associado.Email = txtEmail.Text;
        associado.Contato = txtContato.Text;
        associado.Cnpj = txtCnpj.Text;
        associado.Ie = txtIe.Text;
        associado.Caepf = txtCaepf.Text;
        associado.Sindicato = sindicato;
        if (bd.Update(associado))
        {
            lblMensagem.Text = "Associado alterado com sucesso ";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}
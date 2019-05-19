using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_CadastrarAssociado : System.Web.UI.Page
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

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        SindicatoBD sindicatobd = new SindicatoBD();
        Sindicato sindicato = sindicatobd.Select(Convert.ToInt32(ddlSindicato.SelectedItem.Value));

        Associado associado = new Associado();
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
            associado.Tipo = 0;


        AssociadoBD bd = new AssociadoBD();
            if (bd.Insert(associado))
            {
                lblMensagem.Text = "Associado cadastrado com sucesso";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtSenha.Text = "";
                txtNascimento.Text = "";
                txtDataadm.Text = "";
                txtEndereco.Text = "";
                txtEmail.Text = "";
                txtContato.Text = "";
                txtCnpj.Text = "";
                txtIe.Text = "";
            //remove seleção do ddl
            for (int i = 0; i < ddlSindicato.Items.Count; i++)
            {
                ddlSindicato.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlSindicato.Items[0].Selected = true;

            txtCaepf.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
}
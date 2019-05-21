using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_AlterarFuncionario : System.Web.UI.Page
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
    private void CarregaSetores()
    {
        SetorBD bd = new SetorBD();
        DataSet ds = bd.SelectAll();
        ddlSetor.DataSource = ds.Tables[0].DefaultView;
        ddlSetor.DataTextField = "set_tipo";
        ddlSetor.DataValueField = "set_codigo";
        ddlSetor.DataBind();
        ddlSetor.Items.Insert(0, "Selecione");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CarregaSindicatos();
            ddlSindicato.Focus();
        }
        if (!Page.IsPostBack)
        {
            CarregaSetores();
            ddlSetor.Focus();
        }
        if (!Page.IsPostBack)
        {


            FuncionarioBD bd = new FuncionarioBD();
            Funcionario funcionario = bd.Select(Convert.ToInt32(Session["ID"]));
            ckdPermissaoAdministrador.Checked = funcionario.PermissaoAdministrador;
            txtNome.Text = funcionario.Nome;
            txtCpf.Text = funcionario.Cpf;
            txtSenha.Text = funcionario.Senha;
            txtNascimento.Text = funcionario.Nascimento.ToString();
            txtDataadm.Text = funcionario.Dataadm.ToString();
            txtEndereco.Text = funcionario.Endereco;
            txtEmail.Text = funcionario.Email;
            txtContato.Text = funcionario.Contato;
          


        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        SindicatoBD sindicatobd = new SindicatoBD();
        Sindicato sindicato = sindicatobd.Select(Convert.ToInt32(ddlSindicato.SelectedItem.Value));

        SetorBD setorbd = new SetorBD();
        Setor setor = setorbd.Select(Convert.ToInt32(ddlSetor.SelectedItem.Value));

        FuncionarioBD bd = new FuncionarioBD();
        Funcionario funcionario = bd.Select(Convert.ToInt32(Session["ID"]));
        funcionario.Nome = txtNome.Text;
        funcionario.Cpf = txtCpf.Text;
        funcionario.Senha = txtSenha.Text;
        funcionario.Nascimento = Convert.ToDateTime(txtNascimento.Text);
        funcionario.Dataadm = Convert.ToDateTime(txtDataadm.Text);
        funcionario.Endereco = txtEndereco.Text;
        funcionario.Email = txtEmail.Text;
        funcionario.Contato = txtContato.Text;
        funcionario.Sindicato = sindicato;
        funcionario.Setor = setor;
        if (bd.Update(funcionario))
        {
            lblMensagem.Text = "Funcionario alterado com sucesso";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}
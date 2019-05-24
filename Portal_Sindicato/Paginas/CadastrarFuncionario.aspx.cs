using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_CadastrarFuncionario : System.Web.UI.Page
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
//carrega somente a primeira vez
        if (!Page.IsPostBack)
        {
            CarregaSindicatos();
            ddlSindicato.Focus();

        }
        //carrega somente a primeira vez
        if (!Page.IsPostBack)
        {
            CarregaSetores();
            ddlSetor.Focus();
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        SindicatoBD sindicatobd = new SindicatoBD();
        Sindicato sindicato = sindicatobd.Select(Convert.ToInt32(ddlSindicato.SelectedItem.Value));

        SetorBD setorbd = new SetorBD();
        Setor setor = setorbd.Select(Convert.ToInt32(ddlSetor.SelectedItem.Value));

        Funcionario funcionario = new Funcionario();
        funcionario.PermissaoAdministrador = ckdPermissaoAdministrador.Checked;
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
        funcionario.Tipo = 1;


        FuncionarioBD bd = new FuncionarioBD();
        if (bd.Insert(funcionario))
        {
            lblMensagem.Text = "Funcionario cadastrado com sucesso";
            ckdPermissaoAdministrador.Checked = false;
            txtNome.Text = "";
            txtCpf.Text = "";
            txtSenha.Text = "";
            txtNascimento.Text = "";
            txtDataadm.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtContato.Text = "";
            
            //remove seleção do ddl
            for (int i = 0; i < ddlSindicato.Items.Count; i++)
            {
                ddlSindicato.Items[i].Selected = false;
            }
            //coloca o "Selecione" selecionado
            ddlSindicato.Items[0].Selected = true;

            txtContato.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}

    


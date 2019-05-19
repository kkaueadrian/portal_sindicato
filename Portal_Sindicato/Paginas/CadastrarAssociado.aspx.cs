using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_CadastrarAssociado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        
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

                txtCaepf.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
}
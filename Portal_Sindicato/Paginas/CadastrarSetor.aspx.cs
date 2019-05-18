using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using classes;
using persistencia;

public partial class Paginas_CadastrarSetor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Setor setor = new Setor();
        setor.Tipo = txtTipo.Text;
        SetorBD bd = new SetorBD();
        if (bd.Insert(setor))
        {
            lblMensagem.Text = "Setor cadastrado com sucesso";
            txtTipo.Text = "";
            txtTipo.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}
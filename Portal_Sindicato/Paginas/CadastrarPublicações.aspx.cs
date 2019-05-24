using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
 if (!Page.IsPostBack)
        {
            CarregaAssociados();
ddlAssociado.Focus();
        }

    }


    protected void btnSalvar_Click(object sender, EventArgs e)
{
    if (fuDocumento.HasFile)
    {
        //1 MB
        if (fuDocumento.PostedFile.ContentLength <= 1024000)
        {
            string arquivo = fuDocumento.FileName;
            //caminho onde a foto será salva
            fuDocumento.SaveAs(@"C:\Users\Pietro\source\repos\kkaueadrian\Portal_Sindicato\Portal_Sindicato\Upload\" + arquivo);

            PublicacaoBD publicacaobd = new PubçicacaoBD();
            Publicacao publicacao = publicacaobd.Select(Convert.ToInt32(ddlPublicacao.SelectedItem.Value));

            Publicacao publicacao = new Publicacao();
            publicacao.Endereco = txtEndereco.Text;
            publicacao.Descrição = txtDescrição.Text;
            publicacao.Status = txtStatus.Text;
            publicacao.tipo = txtTipo.Text;

            PublicacaoBD bd = new PublicacaoBD();
            if (bd.Insert(publicacao))
            {
                lblMensagem.Text = "Publicação cadastrada com sucesso";
                txtTipo.Text = "";


                //remove seleção do ddl
                for (int i = 0; i < ddlAssociado.Items.Count; i++)
                {
                    ddlAssociado.Items[i].Selected = false;
                }
                //coloca o "Selecione" selecionado
                ddlAssociado.Items[0].Selected = true;

                txtTipo.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}
    }
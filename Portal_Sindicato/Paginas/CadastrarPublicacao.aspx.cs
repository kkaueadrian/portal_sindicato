using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_CadastrarPublicacao : System.Web.UI.Page
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
        if (!Page.IsPostBack)
        {
            CarregaSindicatos();
            ddlSindicato.Focus();

        }

    }

    protected void lblSalvar_Click(object sender, EventArgs e)
    {


        if (fuImagem.HasFile)
        {
            //1 MB
            if (fuImagem.PostedFile.ContentLength <= 1024000)
            {
                string arquivo = fuImagem.FileName;
                //caminho onde a foto será salva
                fuImagem.SaveAs(@"C:\Users\Pietro\source\repos\kkaueadrian\Portal_Sindicato\Portal_Sindicato\Upload\" + arquivo);


                SindicatoBD sindicatobd = new SindicatoBD();
                Sindicato sindicato = sindicatobd.Select(Convert.ToInt32(ddlSindicato.SelectedItem.Value));

                Publicacao publicacao = new Publicacao();
                publicacao.Endereco = txtEndereco.Text;
                publicacao.Descricao = txtDescricao.Text;
                publicacao.Status = ckdStatus.Checked;
                publicacao.Tipo = txtTipo.Text;
                publicacao.Imagem = arquivo;
                publicacao.Sindicato = sindicato;

                PublicacaoBD bd = new PublicacaoBD();
                if (bd.Insert(publicacao))
                {
                    lblMensagem.Text = "Publicação cadastrada com sucesso";
                    txtEndereco.Text = "";
                    txtDescricao.Text = "";
                    ckdStatus.Checked = false;
                    txtTipo.Text = "";



                    //remove seleção do ddl
                    for (int i = 0; i < ddlSindicato.Items.Count; i++)
                    {
                        ddlSindicato.Items[i].Selected = false;
                    }
                    //coloca o "Selecione" selecionado
                    ddlSindicato.Items[0].Selected = true;

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
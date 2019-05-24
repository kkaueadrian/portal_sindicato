using classes;
using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_CadastrarPendencia : System.Web.UI.Page
{
    private void CarregaAssociados()
    {
        AssociadoBD bd = new AssociadoBD();
        DataSet ds = bd.SelectAll();
        ddlAssociado.DataSource = ds.Tables[0].DefaultView;
        ddlAssociado.DataTextField = "pes_nome";
        ddlAssociado.DataValueField = "pes_codigo";
        ddlAssociado.DataBind();
        ddlAssociado.Items.Insert(0, "Selecione");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //carrega somente a primeira vez
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

                AssociadoBD associadobd = new AssociadoBD();
                Associado associado = associadobd.Select(Convert.ToInt32(ddlAssociado.SelectedItem.Value));

                Pendencia pendencia = new Pendencia();
                pendencia.Tipo = txtTipo.Text;
                pendencia.Documento = arquivo;
                pendencia.Associado = associado;


                PendenciaBD bd = new PendenciaBD();
                if (bd.Insert(pendencia))
                {
                    lblMensagem.Text = "Pendência cadastrada com sucesso";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facil
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;
            string cpf = txCpf.Text;

            int tipoCliente = 0;
            if (!String.IsNullOrEmpty(ddlTipoCliente.SelectedValue))
            {
                tipoCliente = Convert.ToInt32(ddlTipoCliente.SelectedValue);
            }

            string sexo = ddlSexo.SelectedValue;

            int situacaoCliente = 0;
            if (!String.IsNullOrEmpty(ddlSituacaoCliente.SelectedValue))
            {
                situacaoCliente = Convert.ToInt32(ddlSituacaoCliente.SelectedValue);
            }

            if(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(cpf))
            {
                new ClienteServiceReference.Cliente_ServiceClient().InserirCliente(nome, cpf, tipoCliente, sexo, situacaoCliente);
            }

            Response.Redirect("TabelaClientes.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facil
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarClientes();
            }
        }

        public void ListarClientes()
        {
            var result = new ClienteServiceReference.Cliente_ServiceClient().ListarClientes();
            var lista = result.Select(a => new Objetos.Clientes
            {
                IdCliente = a.IdCliente,
                Nome = a.Nome,
                CPF = a.CPF,
                IdTipoCliente = a.IdTipoCliente,
                Sexo = a.Sexo,
                IdSituacaoCliente = a.IdSituacaoCliente
            }).ToList();

            if (lista.Count != 0)
            {
                MsgVazio.Visible = false;
                PreencheGrid(lista);
            }
            else
            {
                MsgVazio.Visible = true;
            }
        }

        public void PreencheGrid(List<Objetos.Clientes> lista)
        {
            ClienteGridView.DataSource = lista;
            ClienteGridView.DataBind();
        }

        protected void ClienteGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            ClienteGridView.EditIndex = -1;
            ListarClientes();
        }
        protected void ClienteGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ClienteGridView.EditIndex = e.NewEditIndex;
            ListarClientes();
        }
        protected void ClienteGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idCliente = Convert.ToInt32(ClienteGridView.DataKeys[e.RowIndex].Value.ToString());
            string nome = ((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txtNome")).Text;
            string cpf = ((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txtCpf")).Text;
            int idTipoCliente = Convert.ToInt32(((DropDownList)ClienteGridView.Rows[e.RowIndex].FindControl("ddlEditTipoCliente")).SelectedValue);
            string sexo = ((DropDownList)ClienteGridView.Rows[e.RowIndex].FindControl("ddlEditSexo")).SelectedValue;
            int idSituacaoCliente = Convert.ToInt32(((DropDownList)ClienteGridView.Rows[e.RowIndex].FindControl("ddlEditSituacaoCliente")).SelectedValue);
            string result = new ClienteServiceReference.Cliente_ServiceClient().AlterarCliente(idCliente, nome, cpf, idTipoCliente, sexo, idSituacaoCliente);
            ClienteGridView.EditIndex = -1;
            ListarClientes();
        }
        protected void ClienteGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idCliente = Convert.ToInt32(ClienteGridView.DataKeys[e.RowIndex].Value.ToString());
            new ClienteServiceReference.Cliente_ServiceClient().RemoverCliente(idCliente);
            ListarClientes();
        }
        protected void ClienteGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) | e.Row.RowState == DataControlRowState.Edit)
            {
                return;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Referencia ao linkbutton delete
                ImageButton deleteButton = (ImageButton)e.Row.Cells[6].Controls[0];
                deleteButton.OnClientClick = "if (!window.confirm('Tem certeza que deseja excluir este registro?')) return false;";
            }
        }

        protected void btnNovoCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCliente.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCliente.aspx");
        }
    }
}
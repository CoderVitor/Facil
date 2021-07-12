using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facil
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        public void ListarClientes()
        {
            var result = new ClienteServiceReference.Cliente_ServiceClient().ListarClientes();
            var model = result.Select(a => new Objetos.Clientes
            {
                IdCliente = a.IdCliente,
                Nome = a.Nome,
                CPF = a.CPF,
                IdTipoCliente = a.IdTipoCliente,
                Sexo = a.Sexo,
                IdSituacaoCliente = a.IdSituacaoCliente
            }).ToList();

            if (model.Count != 0)
            {
                PreencherTabela(model);
            }
        }

        public void PreencherTabela(List<Objetos.Clientes> cliente)
        {

            for (int i = 0; i < cliente.Count; i++)
            {
                TableRow row = new TableRow();

                TableCell nome = new TableCell();
                TableCell cpf = new TableCell();
                TableCell sexo = new TableCell();
                TableCell editar = new TableCell();
                TableCell excluir = new TableCell();

                nome.Text = cliente[i].Nome;
                cpf.Text = cliente[i].CPF;
                sexo.Text = cliente[i].Sexo;

                row.Cells.Add(nome);
                row.Cells.Add(cpf);
                row.Cells.Add(sexo);

                myTable.Rows.Add(row);
            }
        }
        protected void btnNovoCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCliente.aspx");
        }
    }
}
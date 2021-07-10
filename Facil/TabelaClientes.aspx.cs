using Facil.ClienteServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public List<Clientes> ListarClientes()
        {
            //ClienteServiceReference.Clientes[] cliente;
            //using (ClienteServiceReference.Cliente_ServiceClient select = new ClienteServiceReference.Cliente_ServiceClient())
            //{
            //    cliente = select.ListarClientes();
            //}
            var result = new ClienteServiceReference.Cliente_ServiceClient().ListarClientes();
                var model = result.Select(a => new Clientes
                {
                    IdCliente = a.IdCliente,
                    Nome = a.Nome,
                    CPF = a.CPF,
                    Sexo = a.Sexo
                }).ToList();

            return model;
        }
    }
}
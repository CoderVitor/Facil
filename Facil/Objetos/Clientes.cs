using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facil.Objetos
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int IdTipoCliente { get; set; }
        public string Sexo { get; set; }
        public int IdSituacaoCliente { get; set; }
    }
}
using Facil.Objetos;
using Facil_Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Facil_WCF
{
    public class Cliente_Service : ICliente_Service
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public List<Clientes> ListarClientes()
        {
            return clienteRepository.ListarClientes();
        }

        public Clientes BuscarCliente(string nome)
        {
            return clienteRepository.BuscarCliente(nome);
        }

        public void InserirCliente(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente)
        {
            clienteRepository.InserirCliente(nome, cpf, idTipoCliente, sexo, idSituacaoCliente);
        }

        public void RemoverCliente(int idCliente)
        {
            clienteRepository.RemoverCliente(idCliente);
        }

        public string AlterarCliente(int idCliente, string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente)
        {
            return clienteRepository.AlterarCliente(idCliente, nome, cpf, idTipoCliente, sexo, idSituacaoCliente);
        }
    }
}

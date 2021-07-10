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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Cliente_Service" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Cliente_Service.svc ou Cliente_Service.svc.cs no Gerenciador de Soluções e inicie a depuração.
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

        //Inserir novo cliente com um endereço e um telefone.
        public void InserirCliente(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente)
        {
            clienteRepository.InserirCliente(nome, cpf, idTipoCliente, sexo, idSituacaoCliente);
        }

        //Excluir um cliente pelo Id.
        public void RemoverCliente(int idCliente, int idTipoCliente, int idSituacaoCliente)
        {
            clienteRepository.RemoverCliente(idCliente, idTipoCliente, idSituacaoCliente);
        }

        //Alterar um cliente pelo Id.
        public string AlterarCliente(int idCliente, string nome, string cpf, string sexo)
        {
            return clienteRepository.AlterarCliente(idCliente, nome, cpf, sexo);
        }
    }
}

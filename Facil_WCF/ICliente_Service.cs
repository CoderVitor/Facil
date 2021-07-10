using Facil.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Facil_WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "ICliente_Service" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface ICliente_Service
    {
        [OperationContract]
        List<Clientes> ListarClientes();

        [OperationContract]
        Clientes BuscarCliente(string nome);

        [OperationContract]
        void InserirCliente(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente);

        [OperationContract]
        void RemoverCliente(int idCliente, int idTipoCliente, int idSituacaoCliente);

        [OperationContract]
        string AlterarCliente(int idCliente, string nome, string cpf, string sexo);
    }
}

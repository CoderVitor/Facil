using Dapper;
using Facil.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil_Repository.Repository
{
    public class ClienteRepository : BaseDapperRepository
    {
        public List<Clientes> ListarClientes()
        {
            var sql = "EXEC Clientes_Select";

            using (var conn = Connection)
            {
                return conn.Query<Clientes>(sql).ToList();
            }
        }
        public Clientes BuscarCliente(string nome)
        {
            var sql = "EXEC ClientesPorNome_Select @NOME";

            using (var conn = Connection)
            {
                var qlqr = conn.Query<Clientes>(sql, new
                {
                    NOME = nome
                }).FirstOrDefault();
                return qlqr;
            }
        }
        public void InserirCliente(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente)
        {
            try
            {
                var sql = "EXEC Clientes_Insert @Nome, @CPF, @IdTipoCliente, @Sexo, @IdSituacaoCliente";

                using (var conn = Connection)
                {
                    conn.Query(sql, new
                    {
                        Nome = nome,
                        CPF = cpf,
                        IdTipoCliente = idTipoCliente,
                        Sexo = sexo,
                        IdSituacaoCliente = idSituacaoCliente
                    });
                }
            }
            catch (Exception)
            {

            }
        }
        public void RemoverCliente(int idCliente, int idTipoCliente, int idSituacaoCliente)
        {
            var sql = @"EXEC Clientes_Delete @IdCliente, @IdTipoCliente, @IdSituacaoCliente";

            using (var conn = Connection)
            {
                conn.Query(sql, new
                {
                    IdCliente = idCliente,
                    IdTipoCliente = idTipoCliente,
                    IdSituacaoCliente = idSituacaoCliente
                });
            }
        }
        public string AlterarCliente(int idCliente, string nome, string cpf, string sexo)
        {
            try
            {
                var sql = @"EXEC Clientes_Update @IdCliente, @Nome, @CPF, @Sexo";

                using (var conn = Connection)
                {
                    conn.Query(sql, new
                    {
                        IdCliente = idCliente,
                        Nome = nome,
                        CPF = cpf,
                        Sexo = sexo
                    });
                }

                return "Cliente alterado com Sucesso.";
            }
            catch (Exception)
            {
                return "Erro ao alterar o cliente, preencha todos os campos.";
            }
        }
    }
}

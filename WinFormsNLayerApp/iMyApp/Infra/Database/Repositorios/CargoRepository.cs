using Dapper;
using Database.Conexões;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using Negocio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    internal class CargoRepository : ICargoRepository
    {
        public bool Atualizar(Cargo cargo)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"UPDATE [dbo].[Cargo]
                                SET
                                    [Nome] = @nome,
                                    [Status] = @status,
                                    [AlteradoEm] = @alteradoEm,
                                    [AlteradoPor] = @alteradoPor
                                WHERE
                                    [Id] = @id";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", cargo.Nome);
                    parametros.Add("@status", cargo.Status);
                    parametros.Add("@alteradoEm", DateTime.Now);
                    parametros.Add("@alteradoPor", cargo.AlteradoPor);
                    parametros.Add("@id", cargo.Id);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Deletar(Cargo cargo)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"DELETE FROM Cargo WHERE Id = @id";

                    var parametros = new DynamicParameters();
                    parametros.Add("@id", cargo.Id);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Deletar(int v)
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Cargo cargo)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Cargo]
                            ([Nome]
                            ,[Status]
                            ,[CriadoEm]
                            ,[CriadoPor]
                            ,[AlteradoEm]
                            ,[AlteradoPor])
                        VALUES
                            (@nome, 
                            @status, 
                            @criadoEm, 
                            @criadoPor, 
                            @alteradoEm, 
                            @alteradoPor)";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", cargo.Nome);
                    parametros.Add("@status", cargo.Status);
                    parametros.Add("@criadoEm", cargo.CriadoEm);
                    parametros.Add("@criadoPor", cargo.CriadoPor);
                    parametros.Add("@alteradoEm", cargo.AlteradoEm);
                    parametros.Add("@alteradoPor", cargo.AlteradoPor);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cargo ObterPorId(int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {

                    //Comando Sql a ser executado no banco de dados use @ para criar espaços
                    //reservados de substituição
                    var sql = "SELECT * FROM Cargos WHERE Id = @id";

                    //Cria os parametros 
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id);

                    //Executa o comando no banco e substitui o @id pelo int id do parametro do Metodo
                    //E retorna uma única linha do banco QuerySingleOrDefault.
                    var cargos = connection.QuerySingleOrDefault<Cargo>(sql, parametros);

                    return cargos;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Cargo> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT * FROM Cargos";

                    var cargos = connection.Query<Cargo>(sql);

                    return cargos.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public List<Cargo> ObterTodosPorStatus(int status)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    //Comando Sql a ser executado no banco de dados use @ para criar espaços
                    //reservados de substituição
                    var sql = "SELECT * FROM Cargos WHERE Status = @status";

                    //Cria os parametros 
                    var parametros = new DynamicParameters();
                    parametros.Add("@status", status);

                    //Executa o comando no banco e substitui o @status pelo int status do parametro do Metodo
                    var cargos = connection.Query<Cargo>(sql, parametros).ToList();

                    return cargos;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

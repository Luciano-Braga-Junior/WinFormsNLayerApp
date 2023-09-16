using Database.Conexões;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {

        public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]
                    ([Nome]
                    ,[Status]
                    ,[CriadoPor]
                    ,[CriadoEm]
                    ,[AlteradoPor]
                    ,[AlteradoEm])
                    VALUES
                    (@nome,
                    @status,
                    @criadoPor,
                    @criadoEm,
                    @alteradoPor,
                    @alteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Atualizar(Cargo cargo, int id)
        {
            try
            {
                var sql = @"UPDATE [dbo].[Cargo]
                   SET [Nome] = @nome
                  ,[Status] = @Status
                  ,[AlteradoEm] = @AlteradoEm
                  ,[AlteradoPor] = @AlteradoPor
                   WHERE Id = @id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Deletar(int cargoId)
        {
            try
            {
                var sql = @"DELETE FROM[dbo].[Cargo]
                            WHERE Id = @Id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);
                    var resposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ObterTodos()
        {
            try
            {
                var sql = @"SELECT [Id]
                          ,[Nome]
                          ,[Status]
                          ,[CriadoEm]
                          ,[AlteradoPor]
                          ,[AlteradoEm]
                      FROM [dbo].[Cargo]";
                SqlDataAdapter dataAdapter = null;
                var dataTable = new DataTable();

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = connection.CreateCommand();

                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> Complemento(string cargo)
        {
            var sql = @"SELECT [Nome] FROM [dbo].[Cargo]";

            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand(sql, connection);

                    SqlDataReader reader = com.ExecuteReader();

                    var lista = new List<string>();
                    while (reader.Read()) 
                    {
                        lista.Add(reader.GetString(1));
                    }       
                    return lista;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


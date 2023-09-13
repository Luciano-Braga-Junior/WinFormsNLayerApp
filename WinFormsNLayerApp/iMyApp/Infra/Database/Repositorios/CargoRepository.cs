using Database.Conexões;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public int Inserir(Cargo cargo)
        {
            var stringConexao = SqlServer.StrConexao();
            var sqlConnection = new SqlConnection(stringConexao);
            sqlConnection.Open();

            var sql = @"INSERT INTO [dbo].[Cargo]
                            ([Nome]
                           ,[Status]
                           ,[CriadoPor]
                           ,[AlteradoEm]
                           ,[AlteradoPor])
                         VALUES
                           (@nome,
                           @status,
                           @criadoEm,
                           @criadoPor,
                           @alteradoEm,
                           @alteradoPor";
            var cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@nome",cargo.Nome);
            cmd.Parameters.AddWithValue("@status",cargo.Status);
            cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
            cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
            sqlConnection.Close();
        }
    }
}

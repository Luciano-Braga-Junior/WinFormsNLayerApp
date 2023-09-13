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


            sqlConnection.Close();
        }
    }
}

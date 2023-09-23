using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexões
{
    /// <summary>
    /// A <c>SqlServer</c> é uma classe estatica com a string
    /// de conexão com SqlServer
    /// </summary>
    internal static class SqlServer
    {
        /// <summary>
        /// Metodo <c>StrConexao()</c> retorna a string de conexao sql
        /// </summary>
        /// <returns>string: ConnectionString</returns>
        internal static string StrConexao()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=NortWind;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True;"; 
        }
    }
}

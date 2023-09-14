using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexões
{
    internal static class SqlServer
    {
        internal static string StrConexao()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=IMyApp;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True;"; 
        }
    }
}

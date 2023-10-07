using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexões
{
    internal static class SqlServerContext
    {
        internal static string Conexao => ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
}
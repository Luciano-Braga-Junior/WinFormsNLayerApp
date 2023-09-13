using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexões
{
    internal static class SqlServer
    {
        internal static string StrConexaoHardCode()
        {
            return "Server=localhost;Database=iMyApp;User Id=sa;Password=sql2022;";
        }
    }
}

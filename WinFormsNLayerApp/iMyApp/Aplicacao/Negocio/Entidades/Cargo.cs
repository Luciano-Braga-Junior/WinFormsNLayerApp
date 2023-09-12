using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBase
    {
        public int Nome { get; set; }
        public string Status { get; set; }

    }
}

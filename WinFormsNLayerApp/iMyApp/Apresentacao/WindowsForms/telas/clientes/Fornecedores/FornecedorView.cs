using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.telas.clientes.Fornecedores
{
    public partial class FornecedorViwe : Form
    {
        private IFornecedorRepository _fornecedorRepository;
        public FornecedorViwe()
        {
            _fornecedorRepository = IFornecedorRepository();
            InitializeComponent();
        }
    }
}

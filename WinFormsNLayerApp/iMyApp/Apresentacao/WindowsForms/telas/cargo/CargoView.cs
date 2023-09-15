using Database.Repositorios;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.telas.cargo
{
    public partial class CargoView : Form
    {
        public CargoView()
        {
            InitializeComponent();
        }

        private GroupBox groupBoxCargo;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private TextBox txtCargo;
        private Label lblTodosCargos;
        private Button btnRecarregar;
        private BackgroundWorker backgroundWorker1;
        private DataGridView gvCargos;
        private Button btnNovoCargo;

        private void InitializeComponent()
        {
            groupBoxCargo = new GroupBox();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtCargo = new TextBox();
            btnNovoCargo = new Button();
            lblTodosCargos = new Label();
            btnRecarregar = new Button();
            backgroundWorker1 = new BackgroundWorker();
            gvCargos = new DataGridView();
            groupBoxCargo.SuspendLayout();
            ((ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Location = new Point(12, 41);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(678, 44);
            groupBoxCargo.TabIndex = 0;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo Cargo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(590, 15);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(447, 20);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(89, 19);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 18);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(382, 23);
            txtCargo.TabIndex = 0;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Location = new Point(12, 12);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(82, 23);
            btnNovoCargo.TabIndex = 0;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // lblTodosCargos
            // 
            lblTodosCargos.AutoSize = true;
            lblTodosCargos.Location = new Point(18, 99);
            lblTodosCargos.Name = "lblTodosCargos";
            lblTodosCargos.Size = new Size(149, 15);
            lblTodosCargos.TabIndex = 2;
            lblTodosCargos.Text = "Todos os cargos (GridView)";
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(605, 91);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(72, 23);
            btnRecarregar.TabIndex = 3;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // gvCargos
            // 
            gvCargos.AllowUserToAddRows = false;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(12, 117);
            gvCargos.Name = "gvCargos";
            gvCargos.ReadOnly = true;
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(665, 329);
            gvCargos.TabIndex = 4;
            gvCargos.CellMouseClick += gvCargos_CellMouseClick;
            // 
            // CargoView
            // 
            ClientSize = new Size(702, 458);
            Controls.Add(gvCargos);
            Controls.Add(btnRecarregar);
            Controls.Add(lblTodosCargos);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CargoView";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CargoView_Load;
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var novoCargo = new Cargo(nome, status);

            var cargoRepository = new CargoRepository();

            var resultado = cargoRepository.Inserir(novoCargo);

            if (resultado)
            {
                MessageBox.Show("Cargo cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o cargo!");
            }
        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {

        }

        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                DataGridViewRow row = gvCargos.Rows[e.RowIndex];
                txtCargo.Text = row.Cells[1].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());
            }
        }
    }
}

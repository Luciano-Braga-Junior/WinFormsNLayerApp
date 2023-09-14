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
        private GroupBox gvCargos;
        private Label lblTodosCargos;
        private Button btnRecarregar;
        private BackgroundWorker backgroundWorker1;
        private Button btnNovoCargo;

        private void InitializeComponent()
        {
            groupBoxCargo = new GroupBox();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtCargo = new TextBox();
            gvCargos = new GroupBox();
            btnNovoCargo = new Button();
            lblTodosCargos = new Label();
            btnRecarregar = new Button();
            backgroundWorker1 = new BackgroundWorker();
            groupBoxCargo.SuspendLayout();
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
            // gvCargos
            // 
            gvCargos.BackColor = SystemColors.AppWorkspace;
            gvCargos.Location = new Point(18, 117);
            gvCargos.Name = "gvCargos";
            gvCargos.Size = new Size(672, 320);
            gvCargos.TabIndex = 1;
            gvCargos.TabStop = false;
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
            // 
            // CargoView
            // 
            ClientSize = new Size(702, 458);
            Controls.Add(btnRecarregar);
            Controls.Add(lblTodosCargos);
            Controls.Add(gvCargos);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            Name = "CargoView";
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
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

            if(resultado)
            {
                MessageBox.Show("Cargo cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o cargo!");
            }
        }
    }
}

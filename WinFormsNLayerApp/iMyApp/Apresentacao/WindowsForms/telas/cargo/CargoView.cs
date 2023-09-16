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
        private DataGridViewButtonColumn Delete;
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
            Delete = new DataGridViewButtonColumn();
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
            txtCargo.TextChanged += txtCargo_TextChanged;
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
            gvCargos.Columns.AddRange(new DataGridViewColumn[] { Delete });
            gvCargos.Location = new Point(12, 117);
            gvCargos.Name = "gvCargos";
            gvCargos.ReadOnly = true;
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(665, 329);
            gvCargos.TabIndex = 4;
            gvCargos.CellMouseClick += gvCargos_CellMouseClick;
            // 
            // Delete
            // 
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "Ação";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Excluir";
            Delete.ToolTipText = "Delete o registro permanente";
            Delete.UseColumnTextForButtonValue = true;
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

        int id = -1;
        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novoCargo = new Cargo(txtCargo.Text, chkStatus.Checked);
            var cargoRepository = new CargoRepository();
            if (id > 0)
            {

                var atualizarCargo = new CargoRepository();
                atualizarCargo.Atualizar(novoCargo, id);
                MessageBox.Show("Cargo atualizado com sucesso");
            }
            else
            {
                var nome = txtCargo.Text;
                var status = chkStatus.Checked;


                var resultado = cargoRepository.Inserir(novoCargo);

                txtCargo.Text = novoCargo.CriadoPor;

                if (resultado)
                {
                    MessageBox.Show("Cargo cadastrado com sucesso");

                }
                else
                {
                    MessageBox.Show("Não foi possível cadastra o cargo");
                }
            }
        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            carregarCargos();
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            carregarCargos();
        }

        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cargoRepository = new CargoRepository();
            DataGridViewRow row = gvCargos.Rows[e.RowIndex];

            if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show("Deletado com sucesso!");
                {
                    var resultado = cargoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                txtCargo.Text = row.Cells[2].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());


                id = Convert.ToInt32(row.Cells[1].Value);
            }
        }

        private void carregarCargos()
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var cargo = new CargoRepository();

            var reader = cargo.Complemento(nome);

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

            foreach ( var i in reader)
            {
                autoCompleteStringCollection.Add(i);
            }
            txtCargo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCargo.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
    }
}

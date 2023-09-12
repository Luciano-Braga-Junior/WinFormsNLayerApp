namespace WindowsForms.telas.clientes
{
    partial class ClienteCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            dtpNascimento = new DateTimePicker();
            pictureBox1 = new PictureBox();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 13);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 64);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 13);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "Cpf";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 33);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(338, 33);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "txtCpf";
            txtCpf.Size = new Size(134, 23);
            txtCpf.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(87, 84);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(114, 23);
            dtpNascimento.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sem_foto;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(87, 143);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "txtTelefone";
            txtTelefone.Size = new Size(157, 23);
            txtTelefone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 123);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(273, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 123);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "E-mail";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(87, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 176);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 13;
            label6.Text = "Bolsa de estudos";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(87, 235);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Cliente é o responsável legal?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 198);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 15;
            label7.Text = "cmbBolsaEstudos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(273, 235);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 16;
            label8.Text = "chkEhResponsavel";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(207, 90);
            lbl.Name = "lbl";
            lbl.Size = new Size(89, 15);
            lbl.TabIndex = 17;
            lbl.Text = "dtpNascimento";
            // 
            // ClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 445);
            Controls.Add(lbl);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dtpNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteCadastrar";
            Text = "ClienteCadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCpf;
        private DateTimePicker dtpNascimento;
        private PictureBox pictureBox1;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private Label label8;
        private Label lbl;
    }
}
namespace AirSystem.Views
{
    partial class frmCadastroIngles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroIngles));
            this.tbxConfirmarSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxUsuario = new AirSystem.MarkedWaterTextBox();
            this.tbxNendereco = new AirSystem.MarkedWaterTextBox();
            this.tbxEndereco = new AirSystem.MarkedWaterTextBox();
            this.tbxSobrenome = new AirSystem.MarkedWaterTextBox();
            this.tbxNome = new AirSystem.MarkedWaterTextBox();
            this.lblSenhaRegex = new System.Windows.Forms.Label();
            this.lblSenhaAviso = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbxAdm = new System.Windows.Forms.CheckBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbUserFoto = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(259, 358);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxConfirmarSenha.TabIndex = 67;
            this.tbxConfirmarSenha.Text = "Confirm Password";
            this.tbxConfirmarSenha.WaterMarkText = "Confirm Password";
            this.tbxConfirmarSenha.TextChanged += new System.EventHandler(this.tbxConfirmarSenha_TextChanged);
            this.tbxConfirmarSenha.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxConfirmarSenha.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxSenha
            // 
            this.tbxSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxSenha.Location = new System.Drawing.Point(259, 323);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxSenha.TabIndex = 66;
            this.tbxSenha.Text = "Password";
            this.tbxSenha.WaterMarkText = "Password";
            this.tbxSenha.TextChanged += new System.EventHandler(this.tbxSenha_TextChanged);
            this.tbxSenha.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxSenha.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.tbxUsuario.Location = new System.Drawing.Point(259, 292);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(145, 20);
            this.tbxUsuario.TabIndex = 65;
            this.tbxUsuario.Text = "Username";
            this.tbxUsuario.WaterMarkText = "Username";
            this.tbxUsuario.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxNendereco
            // 
            this.tbxNendereco.ForeColor = System.Drawing.Color.Gray;
            this.tbxNendereco.Location = new System.Drawing.Point(495, 249);
            this.tbxNendereco.Name = "tbxNendereco";
            this.tbxNendereco.Size = new System.Drawing.Size(91, 20);
            this.tbxNendereco.TabIndex = 64;
            this.tbxNendereco.Text = "N°";
            this.tbxNendereco.WaterMarkText = "N°";
            this.tbxNendereco.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxNendereco.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.ForeColor = System.Drawing.Color.Gray;
            this.tbxEndereco.Location = new System.Drawing.Point(259, 249);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(230, 20);
            this.tbxEndereco.TabIndex = 63;
            this.tbxEndereco.Text = "Adress";
            this.tbxEndereco.WaterMarkText = "Adress";
            this.tbxEndereco.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxEndereco.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.ForeColor = System.Drawing.Color.Gray;
            this.tbxSobrenome.Location = new System.Drawing.Point(414, 209);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(145, 20);
            this.tbxSobrenome.TabIndex = 62;
            this.tbxSobrenome.Text = "Last Name";
            this.tbxSobrenome.WaterMarkText = "Last Name";
            this.tbxSobrenome.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxSobrenome.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxNome
            // 
            this.tbxNome.ForeColor = System.Drawing.Color.Gray;
            this.tbxNome.Location = new System.Drawing.Point(259, 209);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(145, 20);
            this.tbxNome.TabIndex = 61;
            this.tbxNome.Text = "First Name";
            this.tbxNome.WaterMarkText = "First Name";
            this.tbxNome.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxNome.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // lblSenhaRegex
            // 
            this.lblSenhaRegex.AutoSize = true;
            this.lblSenhaRegex.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaRegex.Location = new System.Drawing.Point(21, 421);
            this.lblSenhaRegex.Name = "lblSenhaRegex";
            this.lblSenhaRegex.Size = new System.Drawing.Size(383, 13);
            this.lblSenhaRegex.TabIndex = 60;
            this.lblSenhaRegex.Text = "*Your password must be at least one upper letter, 8 characters and one number.";
            // 
            // lblSenhaAviso
            // 
            this.lblSenhaAviso.AutoSize = true;
            this.lblSenhaAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAviso.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaAviso.Location = new System.Drawing.Point(21, 384);
            this.lblSenhaAviso.Name = "lblSenhaAviso";
            this.lblSenhaAviso.Size = new System.Drawing.Size(150, 13);
            this.lblSenhaAviso.TabIndex = 59;
            this.lblSenhaAviso.Text = "**Password must be the same.";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(495, 292);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(145, 21);
            this.dtpNascimento.TabIndex = 58;
            // 
            // cbxAdm
            // 
            this.cbxAdm.AutoSize = true;
            this.cbxAdm.Location = new System.Drawing.Point(414, 335);
            this.cbxAdm.Name = "cbxAdm";
            this.cbxAdm.Size = new System.Drawing.Size(86, 17);
            this.cbxAdm.TabIndex = 55;
            this.cbxAdm.Text = "Administrator";
            this.cbxAdm.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(436, 147);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 54;
            this.btnRemover.Text = "Remove";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(272, 147);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 53;
            this.btnAlterar.Text = "Change";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(369, 395);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 56;
            this.btnCadastrar.Text = "Register";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(121, 358);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(121, 17);
            this.lblConfirmarSenha.TabIndex = 52;
            this.lblConfirmarSenha.Text = "Confirm Password";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(169, 283);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 17);
            this.lblUsuario.TabIndex = 51;
            this.lblUsuario.Text = "Username";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(173, 323);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 17);
            this.lblSenha.TabIndex = 49;
            this.lblSenha.Text = "Password";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(411, 292);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(60, 17);
            this.lblNascimento.TabIndex = 48;
            this.lblNascimento.Text = "Birthday";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(190, 249);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(52, 17);
            this.lblEndereco.TabIndex = 47;
            this.lblEndereco.Text = "Adress";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(197, 209);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 50;
            this.lblNome.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.cbxAdm);
            this.panel2.Controls.Add(this.tbxSobrenome);
            this.panel2.Controls.Add(this.btnRemover);
            this.panel2.Controls.Add(this.tbxNendereco);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.tbxNome);
            this.panel2.Controls.Add(this.pcbUserFoto);
            this.panel2.Controls.Add(this.tbxUsuario);
            this.panel2.Controls.Add(this.tbxEndereco);
            this.panel2.Controls.Add(this.tbxSenha);
            this.panel2.Controls.Add(this.tbxConfirmarSenha);
            this.panel2.Controls.Add(this.lblSenhaAviso);
            this.panel2.Controls.Add(this.dtpNascimento);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.lblSenhaRegex);
            this.panel2.Controls.Add(this.lblConfirmarSenha);
            this.panel2.Controls.Add(this.lblSenha);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblEndereco);
            this.panel2.Controls.Add(this.lblNascimento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 68;
            // 
            // pcbUserFoto
            // 
            this.pcbUserFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbUserFoto.Image = ((System.Drawing.Image)(resources.GetObject("pcbUserFoto.Image")));
            this.pcbUserFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbUserFoto.InitialImage")));
            this.pcbUserFoto.Location = new System.Drawing.Point(319, 12);
            this.pcbUserFoto.Name = "pcbUserFoto";
            this.pcbUserFoto.Size = new System.Drawing.Size(170, 129);
            this.pcbUserFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserFoto.TabIndex = 57;
            this.pcbUserFoto.TabStop = false;
            // 
            // frmCadastroIngles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "frmCadastroIngles";
            this.Text = "frmCadastroIngles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MarkedWaterTextBox tbxConfirmarSenha;
        private MarkedWaterTextBox tbxSenha;
        private MarkedWaterTextBox tbxUsuario;
        private MarkedWaterTextBox tbxNendereco;
        private MarkedWaterTextBox tbxEndereco;
        private MarkedWaterTextBox tbxSobrenome;
        private MarkedWaterTextBox tbxNome;
        private System.Windows.Forms.Label lblSenhaRegex;
        private System.Windows.Forms.Label lblSenhaAviso;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.CheckBox cbxAdm;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.PictureBox pcbUserFoto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace AirSystem.Views
{
    partial class frmTelaUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaUser));
            this.btnGerenciarRelatorio = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnListarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerenciarRelatorio
            // 
            this.btnGerenciarRelatorio.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarRelatorio.Location = new System.Drawing.Point(540, 236);
            this.btnGerenciarRelatorio.Name = "btnGerenciarRelatorio";
            this.btnGerenciarRelatorio.Size = new System.Drawing.Size(248, 87);
            this.btnGerenciarRelatorio.TabIndex = 8;
            this.btnGerenciarRelatorio.Text = "Gerenciar Relatórios";
            this.btnGerenciarRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarCompanhia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarCompanhia.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(241, 236);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(282, 87);
            this.btnGerenciarCompanhia.TabIndex = 7;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = false;
            // 
            // btnListarAviao
            // 
            this.btnListarAviao.BackColor = System.Drawing.Color.Black;
            this.btnListarAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAviao.ForeColor = System.Drawing.Color.White;
            this.btnListarAviao.Location = new System.Drawing.Point(246, 94);
            this.btnListarAviao.Name = "btnListarAviao";
            this.btnListarAviao.Size = new System.Drawing.Size(277, 87);
            this.btnListarAviao.TabIndex = 6;
            this.btnListarAviao.Text = "Listar Aviões";
            this.btnListarAviao.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarAviao.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarAviao.Location = new System.Drawing.Point(540, 94);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(248, 87);
            this.btnGerenciarAviao.TabIndex = 5;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 178);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerenciarRelatorio);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnListarAviao);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Name = "frmTelaUser";
            this.Text = "Tela Principal - AirSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGerenciarRelatorio;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnListarAviao;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
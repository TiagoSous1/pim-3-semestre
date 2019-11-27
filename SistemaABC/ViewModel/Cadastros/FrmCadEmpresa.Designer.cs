namespace SistemaABC.ViewModel
{
    partial class FrmCadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEmpresa));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.cmbEndereco = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(337, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(337, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Código";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 279);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(638, 22);
            this.txtTelefone.TabIndex = 38;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(334, 184);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(316, 22);
            this.txtEstado.TabIndex = 37;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(334, 136);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(316, 22);
            this.txtCodigo.TabIndex = 36;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(662, 96);
            this.panelTop.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // brnClear
            // 
            this.brnClear.BackColor = System.Drawing.Color.Black;
            this.brnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.brnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.brnClear.Location = new System.Drawing.Point(500, 319);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(150, 35);
            this.brnClear.TabIndex = 34;
            this.brnClear.Text = "Limpar Pesquisa";
            this.brnClear.UseVisualStyleBackColor = false;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnSave.Location = new System.Drawing.Point(12, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Razão";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(12, 184);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(316, 22);
            this.txtCnpj.TabIndex = 29;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(12, 136);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(316, 22);
            this.txtRazao.TabIndex = 28;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.lblEndereco.Location = new System.Drawing.Point(18, 208);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 19);
            this.lblEndereco.TabIndex = 45;
            this.lblEndereco.Text = "Endereço";
            // 
            // cmbEndereco
            // 
            this.cmbEndereco.FormattingEnabled = true;
            this.cmbEndereco.Location = new System.Drawing.Point(12, 230);
            this.cmbEndereco.Name = "cmbEndereco";
            this.cmbEndereco.Size = new System.Drawing.Size(638, 24);
            this.cmbEndereco.TabIndex = 44;
            // 
            // FrmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 375);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.cmbEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtRazao);
            this.Name = "FrmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadEmpresa";
            this.Load += new System.EventHandler(this.FrmCadEmpresa_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.ComboBox cmbEndereco;
    }
}
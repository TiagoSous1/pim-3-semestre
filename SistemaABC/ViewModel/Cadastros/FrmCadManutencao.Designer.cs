namespace SistemaABC.ViewModel
{
    partial class FrmCadManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadManutencao));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescManut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoPecas = new System.Windows.Forms.TextBox();
            this.txtCodPecas = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCar = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpDataMarcada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraMarcada = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "Descrição da Manutenção";
            // 
            // txtDescManut
            // 
            this.txtDescManut.Location = new System.Drawing.Point(12, 277);
            this.txtDescManut.Multiline = true;
            this.txtDescManut.Name = "txtDescManut";
            this.txtDescManut.Size = new System.Drawing.Size(638, 107);
            this.txtDescManut.TabIndex = 61;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(337, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Peça preço R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(337, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Código da peça";
            // 
            // txtPrecoPecas
            // 
            this.txtPrecoPecas.Location = new System.Drawing.Point(334, 183);
            this.txtPrecoPecas.Name = "txtPrecoPecas";
            this.txtPrecoPecas.Size = new System.Drawing.Size(316, 22);
            this.txtPrecoPecas.TabIndex = 56;
            // 
            // txtCodPecas
            // 
            this.txtCodPecas.Location = new System.Drawing.Point(334, 135);
            this.txtCodPecas.Name = "txtCodPecas";
            this.txtCodPecas.Size = new System.Drawing.Size(316, 22);
            this.txtCodPecas.TabIndex = 55;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(662, 96);
            this.panelTop.TabIndex = 54;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnClear.Location = new System.Drawing.Point(500, 514);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 35);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Limpar Pesquisa";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnSave.Location = new System.Drawing.Point(12, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Código Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Data";
            // 
            // txtCodEmpresa
            // 
            this.txtCodEmpresa.Location = new System.Drawing.Point(12, 230);
            this.txtCodEmpresa.Name = "txtCodEmpresa";
            this.txtCodEmpresa.Size = new System.Drawing.Size(638, 22);
            this.txtCodEmpresa.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Códico do carro";
            // 
            // txtCodCar
            // 
            this.txtCodCar.Location = new System.Drawing.Point(12, 135);
            this.txtCodCar.Name = "txtCodCar";
            this.txtCodCar.Size = new System.Drawing.Size(316, 22);
            this.txtCodCar.TabIndex = 48;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 392);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.Text = "Corretiva";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(116, 392);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 21);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "Preventiva";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(12, 182);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(316, 22);
            this.dtpData.TabIndex = 66;
            // 
            // dtpDataMarcada
            // 
            this.dtpDataMarcada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMarcada.Location = new System.Drawing.Point(540, 416);
            this.dtpDataMarcada.Name = "dtpDataMarcada";
            this.dtpDataMarcada.Size = new System.Drawing.Size(109, 22);
            this.dtpDataMarcada.TabIndex = 67;
            // 
            // dtpHoraMarcada
            // 
            this.dtpHoraMarcada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraMarcada.Location = new System.Drawing.Point(540, 469);
            this.dtpHoraMarcada.Name = "dtpHoraMarcada";
            this.dtpHoraMarcada.Size = new System.Drawing.Size(109, 22);
            this.dtpHoraMarcada.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(536, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 69;
            this.label7.Text = "Data Marcada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(536, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Hora Marcada";
            // 
            // FrmCadManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 564);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHoraMarcada);
            this.Controls.Add(this.dtpDataMarcada);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescManut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecoPecas);
            this.Controls.Add(this.txtCodPecas);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodCar);
            this.Name = "FrmCadManutencao";
            this.Text = "FrmCadManutencao";
            this.Load += new System.EventHandler(this.FrmCadManutencao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescManut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoPecas;
        private System.Windows.Forms.TextBox txtCodPecas;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpDataMarcada;
        private System.Windows.Forms.DateTimePicker dtpHoraMarcada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
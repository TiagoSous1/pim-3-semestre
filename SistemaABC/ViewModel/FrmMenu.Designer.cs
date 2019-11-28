namespace SistemaABC.ViewModel
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnParts = new System.Windows.Forms.Button();
            this.brnFines = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnInfraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelFull = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnFinances);
            this.panelMenu.Controls.Add(this.btnParts);
            this.panelMenu.Controls.Add(this.brnFines);
            this.panelMenu.Controls.Add(this.btnVehicle);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnCompany);
            this.panelMenu.Controls.Add(this.btnInfraction);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 636);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinances
            // 
            this.btnFinances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnFinances.Image = ((System.Drawing.Image)(resources.GetObject("btnFinances.Image")));
            this.btnFinances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinances.Location = new System.Drawing.Point(5, 515);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(271, 48);
            this.btnFinances.TabIndex = 15;
            this.btnFinances.Text = "     Finanças";
            this.btnFinances.UseVisualStyleBackColor = true;
            // 
            // btnParts
            // 
            this.btnParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnParts.Image = ((System.Drawing.Image)(resources.GetObject("btnParts.Image")));
            this.btnParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParts.Location = new System.Drawing.Point(5, 407);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(271, 48);
            this.btnParts.TabIndex = 7;
            this.btnParts.Text = "     Peças";
            this.btnParts.UseVisualStyleBackColor = true;
            this.btnParts.Click += new System.EventHandler(this.btnParts_Click);
            // 
            // brnFines
            // 
            this.brnFines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnFines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnFines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.brnFines.Image = ((System.Drawing.Image)(resources.GetObject("brnFines.Image")));
            this.brnFines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnFines.Location = new System.Drawing.Point(5, 353);
            this.brnFines.Name = "brnFines";
            this.brnFines.Size = new System.Drawing.Size(271, 48);
            this.brnFines.TabIndex = 5;
            this.brnFines.Text = "     Multas";
            this.brnFines.UseVisualStyleBackColor = true;
            this.brnFines.Click += new System.EventHandler(this.brnFines_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicle.Image")));
            this.btnVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.Location = new System.Drawing.Point(5, 299);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(271, 48);
            this.btnVehicle.TabIndex = 4;
            this.btnVehicle.Text = "     Veiculo";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(5, 461);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(271, 48);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "     Relatórios";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnCompany
            // 
            this.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.Image")));
            this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.Location = new System.Drawing.Point(5, 245);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(271, 48);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "     Empresa";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnInfraction
            // 
            this.btnInfraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfraction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnInfraction.Image = ((System.Drawing.Image)(resources.GetObject("btnInfraction.Image")));
            this.btnInfraction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfraction.Location = new System.Drawing.Point(5, 191);
            this.btnInfraction.Name = "btnInfraction";
            this.btnInfraction.Size = new System.Drawing.Size(271, 48);
            this.btnInfraction.TabIndex = 2;
            this.btnInfraction.Text = "     Infração";
            this.btnInfraction.UseVisualStyleBackColor = true;
            this.btnInfraction.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema ABC";
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(5, 137);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(271, 48);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "     Usuários";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // panelFull
            // 
            this.panelFull.BackColor = System.Drawing.Color.AliceBlue;
            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull.Location = new System.Drawing.Point(280, 0);
            this.panelFull.Name = "panelFull";
            this.panelFull.Size = new System.Drawing.Size(1062, 636);
            this.panelFull.TabIndex = 7;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 636);
            this.Controls.Add(this.panelFull);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnInfraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFull;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinances;
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Button brnFines;
        private System.Windows.Forms.Button btnVehicle;
    }
}
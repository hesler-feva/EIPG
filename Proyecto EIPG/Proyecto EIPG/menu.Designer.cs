namespace Proyecto_EIPG
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_NombreEIPG = new System.Windows.Forms.Label();
            this.Btn_Menu_Administrativo = new System.Windows.Forms.Button();
            this.Btn_Menu_Contable = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_NombreEIPG
            // 
            this.Lbl_NombreEIPG.AutoSize = true;
            this.Lbl_NombreEIPG.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NombreEIPG.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreEIPG.Location = new System.Drawing.Point(33, 140);
            this.Lbl_NombreEIPG.Name = "Lbl_NombreEIPG";
            this.Lbl_NombreEIPG.Size = new System.Drawing.Size(468, 30);
            this.Lbl_NombreEIPG.TabIndex = 8;
            this.Lbl_NombreEIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // Btn_Menu_Administrativo
            // 
            this.Btn_Menu_Administrativo.Location = new System.Drawing.Point(38, 200);
            this.Btn_Menu_Administrativo.Name = "Btn_Menu_Administrativo";
            this.Btn_Menu_Administrativo.Size = new System.Drawing.Size(222, 46);
            this.Btn_Menu_Administrativo.TabIndex = 9;
            this.Btn_Menu_Administrativo.Text = "Menu Administrativo";
            this.Btn_Menu_Administrativo.UseVisualStyleBackColor = true;
            this.Btn_Menu_Administrativo.Click += new System.EventHandler(this.btn_menu_administrativo_Click);
            // 
            // Btn_Menu_Contable
            // 
            this.Btn_Menu_Contable.Location = new System.Drawing.Point(279, 200);
            this.Btn_Menu_Contable.Name = "Btn_Menu_Contable";
            this.Btn_Menu_Contable.Size = new System.Drawing.Size(222, 46);
            this.Btn_Menu_Contable.TabIndex = 10;
            this.Btn_Menu_Contable.Text = "Menu Contable";
            this.Btn_Menu_Contable.UseVisualStyleBackColor = true;
            this.Btn_Menu_Contable.Click += new System.EventHandler(this.btn_menu_contable_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(164, 253);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(222, 46);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Cerrar Sesión";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Menu_Administrativo);
            this.Controls.Add(this.Btn_Menu_Contable);
            this.Controls.Add(this.Lbl_NombreEIPG);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_NombreEIPG;
        private System.Windows.Forms.Button Btn_Menu_Administrativo;
        private System.Windows.Forms.Button Btn_Menu_Contable;
        private System.Windows.Forms.Button Btn_Salir;
    }
}
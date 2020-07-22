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
            this.Lbl_NombreEIPG = new System.Windows.Forms.Label();
            this.Btn_Menu_Contable = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Mantenimiento_Academico = new System.Windows.Forms.Button();
            this.Btn_Menu_Administrativo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_NombreEIPG
            // 
            this.Lbl_NombreEIPG.AutoSize = true;
            this.Lbl_NombreEIPG.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NombreEIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreEIPG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NombreEIPG.Location = new System.Drawing.Point(61, 126);
            this.Lbl_NombreEIPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreEIPG.Name = "Lbl_NombreEIPG";
            this.Lbl_NombreEIPG.Size = new System.Drawing.Size(558, 38);
            this.Lbl_NombreEIPG.TabIndex = 8;
            this.Lbl_NombreEIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // Btn_Menu_Contable
            // 
            this.Btn_Menu_Contable.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Contable.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Contable.Image")));
            this.Btn_Menu_Contable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Menu_Contable.Location = new System.Drawing.Point(360, 177);
            this.Btn_Menu_Contable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Menu_Contable.Name = "Btn_Menu_Contable";
            this.Btn_Menu_Contable.Size = new System.Drawing.Size(296, 57);
            this.Btn_Menu_Contable.TabIndex = 10;
            this.Btn_Menu_Contable.Text = "Menu Contable";
            this.Btn_Menu_Contable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Contable.UseVisualStyleBackColor = true;
            this.Btn_Menu_Contable.Click += new System.EventHandler(this.btn_menu_contable_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Proyecto_EIPG.Properties.Resources.cerrar_sesion_2;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Salir.Location = new System.Drawing.Point(509, 313);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(190, 57);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Cerrar Sesión";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_Mantenimiento_Academico
            // 
            this.Btn_Mantenimiento_Academico.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mantenimiento_Academico.Image = global::Proyecto_EIPG.Properties.Resources.mantenimiento_6;
            this.Btn_Mantenimiento_Academico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Mantenimiento_Academico.Location = new System.Drawing.Point(198, 246);
            this.Btn_Mantenimiento_Academico.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Mantenimiento_Academico.Name = "Btn_Mantenimiento_Academico";
            this.Btn_Mantenimiento_Academico.Size = new System.Drawing.Size(296, 92);
            this.Btn_Mantenimiento_Academico.TabIndex = 16;
            this.Btn_Mantenimiento_Academico.Text = "Mantenimiento Academico";
            this.Btn_Mantenimiento_Academico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Mantenimiento_Academico.UseVisualStyleBackColor = true;
            this.Btn_Mantenimiento_Academico.Click += new System.EventHandler(this.Btn_Mantenimiento_Academico_Click);
            // 
            // Btn_Menu_Administrativo
            // 
            this.Btn_Menu_Administrativo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Administrativo.Image = global::Proyecto_EIPG.Properties.Resources.administrar_3;
            this.Btn_Menu_Administrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Administrativo.Location = new System.Drawing.Point(48, 177);
            this.Btn_Menu_Administrativo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Menu_Administrativo.Name = "Btn_Menu_Administrativo";
            this.Btn_Menu_Administrativo.Size = new System.Drawing.Size(296, 57);
            this.Btn_Menu_Administrativo.TabIndex = 9;
            this.Btn_Menu_Administrativo.Text = "Menu Administrativo";
            this.Btn_Menu_Administrativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Menu_Administrativo.UseVisualStyleBackColor = true;
            this.Btn_Menu_Administrativo.Click += new System.EventHandler(this.btn_menu_administrativo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(712, 383);
            this.Controls.Add(this.Btn_Mantenimiento_Academico);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Menu_Administrativo);
            this.Controls.Add(this.Btn_Menu_Contable);
            this.Controls.Add(this.Lbl_NombreEIPG);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button Btn_Mantenimiento_Academico;
    }
}
namespace Proyecto_EIPG
{
    partial class Menu_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Admin));
            this.Btn_Ingreso_Alum = new System.Windows.Forms.Button();
            this.lblEIPG = new System.Windows.Forms.Label();
            this.lblBienbenida = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lblIdentidad_Admin = new System.Windows.Forms.Label();
            this.lblNombre_admin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Btn_Cierre_de_año = new System.Windows.Forms.Button();
            this.Btn_Reporte_Docen = new System.Windows.Forms.Button();
            this.Btn_Reporte_Alum = new System.Windows.Forms.Button();
            this.Btn_Ingreso_Emple = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Mantenimiento_Academico = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Ingreso_Alum
            // 
            this.Btn_Ingreso_Alum.Location = new System.Drawing.Point(137, 201);
            this.Btn_Ingreso_Alum.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingreso_Alum.Name = "Btn_Ingreso_Alum";
            this.Btn_Ingreso_Alum.Size = new System.Drawing.Size(296, 57);
            this.Btn_Ingreso_Alum.TabIndex = 0;
            this.Btn_Ingreso_Alum.Text = "Ingresar Alumno Nuevo";
            this.Btn_Ingreso_Alum.UseVisualStyleBackColor = true;
            this.Btn_Ingreso_Alum.Click += new System.EventHandler(this.btnIngreso_Alum_Click);
            // 
            // lblEIPG
            // 
            this.lblEIPG.AutoSize = true;
            this.lblEIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEIPG.Location = new System.Drawing.Point(45, 62);
            this.lblEIPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEIPG.Name = "lblEIPG";
            this.lblEIPG.Size = new System.Drawing.Size(469, 29);
            this.lblEIPG.TabIndex = 6;
            this.lblEIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // lblBienbenida
            // 
            this.lblBienbenida.AutoSize = true;
            this.lblBienbenida.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienbenida.Location = new System.Drawing.Point(227, 96);
            this.lblBienbenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienbenida.Name = "lblBienbenida";
            this.lblBienbenida.Size = new System.Drawing.Size(153, 29);
            this.lblBienbenida.TabIndex = 7;
            this.lblBienbenida.Text = "Bienvenido";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.Btn_Mantenimiento_Academico);
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.btnSalir);
            this.pnlContenedor.Controls.Add(this.Btn_Cierre_de_año);
            this.pnlContenedor.Controls.Add(this.Btn_Reporte_Docen);
            this.pnlContenedor.Controls.Add(this.Btn_Reporte_Alum);
            this.pnlContenedor.Controls.Add(this.Btn_Ingreso_Emple);
            this.pnlContenedor.Controls.Add(this.lblBienbenida);
            this.pnlContenedor.Controls.Add(this.lblEIPG);
            this.pnlContenedor.Controls.Add(this.Btn_Ingreso_Alum);
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1067, 554);
            this.pnlContenedor.TabIndex = 8;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Cargo);
            this.panel1.Controls.Add(this.lblIdentidad_Admin);
            this.panel1.Controls.Add(this.lblNombre_admin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(585, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 156);
            this.panel1.TabIndex = 13;
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Location = new System.Drawing.Point(135, 100);
            this.lbl_Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(95, 17);
            this.lbl_Cargo.TabIndex = 3;
            this.lbl_Cargo.Text = "Administrador";
            // 
            // lblIdentidad_Admin
            // 
            this.lblIdentidad_Admin.AutoSize = true;
            this.lblIdentidad_Admin.Location = new System.Drawing.Point(123, 66);
            this.lblIdentidad_Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentidad_Admin.Name = "lblIdentidad_Admin";
            this.lblIdentidad_Admin.Size = new System.Drawing.Size(0, 17);
            this.lblIdentidad_Admin.TabIndex = 2;
            this.lblIdentidad_Admin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre_admin
            // 
            this.lblNombre_admin.AutoSize = true;
            this.lblNombre_admin.Location = new System.Drawing.Point(164, 32);
            this.lblNombre_admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre_admin.Name = "lblNombre_admin";
            this.lblNombre_admin.Size = new System.Drawing.Size(0, 17);
            this.lblNombre_admin.TabIndex = 1;
            this.lblNombre_admin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(716, 447);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(296, 57);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_Cierre_de_año
            // 
            this.Btn_Cierre_de_año.Location = new System.Drawing.Point(591, 375);
            this.Btn_Cierre_de_año.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cierre_de_año.Name = "Btn_Cierre_de_año";
            this.Btn_Cierre_de_año.Size = new System.Drawing.Size(296, 57);
            this.Btn_Cierre_de_año.TabIndex = 11;
            this.Btn_Cierre_de_año.Text = "Cierre de Año";
            this.Btn_Cierre_de_año.UseVisualStyleBackColor = true;
            this.Btn_Cierre_de_año.Visible = false;
            this.Btn_Cierre_de_año.Click += new System.EventHandler(this.btnReporte_Contable_Click);
            // 
            // Btn_Reporte_Docen
            // 
            this.Btn_Reporte_Docen.Location = new System.Drawing.Point(591, 289);
            this.Btn_Reporte_Docen.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Docen.Name = "Btn_Reporte_Docen";
            this.Btn_Reporte_Docen.Size = new System.Drawing.Size(296, 57);
            this.Btn_Reporte_Docen.TabIndex = 10;
            this.Btn_Reporte_Docen.Text = "Reporte de Empleados";
            this.Btn_Reporte_Docen.UseVisualStyleBackColor = true;
            this.Btn_Reporte_Docen.Click += new System.EventHandler(this.btnReporte_Docen_Click);
            // 
            // Btn_Reporte_Alum
            // 
            this.Btn_Reporte_Alum.Location = new System.Drawing.Point(137, 289);
            this.Btn_Reporte_Alum.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Alum.Name = "Btn_Reporte_Alum";
            this.Btn_Reporte_Alum.Size = new System.Drawing.Size(296, 57);
            this.Btn_Reporte_Alum.TabIndex = 9;
            this.Btn_Reporte_Alum.Text = "Reporte de Alumnos";
            this.Btn_Reporte_Alum.UseVisualStyleBackColor = true;
            this.Btn_Reporte_Alum.Click += new System.EventHandler(this.btnReporte_Alum_Click);
            // 
            // Btn_Ingreso_Emple
            // 
            this.Btn_Ingreso_Emple.Location = new System.Drawing.Point(591, 201);
            this.Btn_Ingreso_Emple.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingreso_Emple.Name = "Btn_Ingreso_Emple";
            this.Btn_Ingreso_Emple.Size = new System.Drawing.Size(296, 57);
            this.Btn_Ingreso_Emple.TabIndex = 8;
            this.Btn_Ingreso_Emple.Text = "Ingresar Empleado Nuevo";
            this.Btn_Ingreso_Emple.UseVisualStyleBackColor = true;
            this.Btn_Ingreso_Emple.Click += new System.EventHandler(this.btnIngreso_Emple_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 212);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_Mantenimiento_Academico
            // 
            this.Btn_Mantenimiento_Academico.Location = new System.Drawing.Point(137, 375);
            this.Btn_Mantenimiento_Academico.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Mantenimiento_Academico.Name = "Btn_Mantenimiento_Academico";
            this.Btn_Mantenimiento_Academico.Size = new System.Drawing.Size(296, 57);
            this.Btn_Mantenimiento_Academico.TabIndex = 15;
            this.Btn_Mantenimiento_Academico.Text = "Mantenimiento Academico";
            this.Btn_Mantenimiento_Academico.UseVisualStyleBackColor = true;
            this.Btn_Mantenimiento_Academico.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrativo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Admin_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Admin_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ingreso_Alum;
        private System.Windows.Forms.Label lblEIPG;
        private System.Windows.Forms.Label lblBienbenida;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button Btn_Cierre_de_año;
        private System.Windows.Forms.Button Btn_Reporte_Docen;
        private System.Windows.Forms.Button Btn_Reporte_Alum;
        private System.Windows.Forms.Button Btn_Ingreso_Emple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblNombre_admin;
        public System.Windows.Forms.Label lblIdentidad_Admin;
        private System.Windows.Forms.Button Btn_Mantenimiento_Academico;
    }
}
namespace Proyecto_EIPG
{
    partial class Menu_Contabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Contabilidad));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lblIdentidad_Conta = new System.Windows.Forms.Label();
            this.lblNombre_conta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Btn_Reporte_General_Conta = new System.Windows.Forms.Button();
            this.Btn_Reporte_Egresos_Conta = new System.Windows.Forms.Button();
            this.Btn_Reporte_Ingresos_Conta = new System.Windows.Forms.Button();
            this.Btn_Registro_Egreso_conta = new System.Windows.Forms.Button();
            this.Lbl_Bienbenida = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.Btn_Registro_Ingreso_Conta = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.btnSalir);
            this.pnlContenedor.Controls.Add(this.Btn_Reporte_General_Conta);
            this.pnlContenedor.Controls.Add(this.Btn_Reporte_Egresos_Conta);
            this.pnlContenedor.Controls.Add(this.Btn_Reporte_Ingresos_Conta);
            this.pnlContenedor.Controls.Add(this.Btn_Registro_Egreso_conta);
            this.pnlContenedor.Controls.Add(this.Lbl_Bienbenida);
            this.pnlContenedor.Controls.Add(this.Lbl_EIPG);
            this.pnlContenedor.Controls.Add(this.Btn_Registro_Ingreso_Conta);
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 9;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Cargo);
            this.panel1.Controls.Add(this.lblIdentidad_Conta);
            this.panel1.Controls.Add(this.lblNombre_conta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(462, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 127);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Location = new System.Drawing.Point(103, 81);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(65, 13);
            this.lbl_Cargo.TabIndex = 3;
            this.lbl_Cargo.Text = "Contabilidad";
            // 
            // lblIdentidad_Conta
            // 
            this.lblIdentidad_Conta.AutoSize = true;
            this.lblIdentidad_Conta.Location = new System.Drawing.Point(92, 54);
            this.lblIdentidad_Conta.Name = "lblIdentidad_Conta";
            this.lblIdentidad_Conta.Size = new System.Drawing.Size(0, 13);
            this.lblIdentidad_Conta.TabIndex = 2;
            // 
            // lblNombre_conta
            // 
            this.lblNombre_conta.AutoSize = true;
            this.lblNombre_conta.Location = new System.Drawing.Point(39, 26);
            this.lblNombre_conta.Name = "lblNombre_conta";
            this.lblNombre_conta.Size = new System.Drawing.Size(0, 13);
            this.lblNombre_conta.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(537, 363);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 46);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_Reporte_General_Conta
            // 
            this.Btn_Reporte_General_Conta.Location = new System.Drawing.Point(276, 305);
            this.Btn_Reporte_General_Conta.Name = "Btn_Reporte_General_Conta";
            this.Btn_Reporte_General_Conta.Size = new System.Drawing.Size(222, 46);
            this.Btn_Reporte_General_Conta.TabIndex = 11;
            this.Btn_Reporte_General_Conta.Text = "Reporte General";
            this.Btn_Reporte_General_Conta.UseVisualStyleBackColor = true;
            this.Btn_Reporte_General_Conta.Click += new System.EventHandler(this.btnReporteGeneral_Conta_Click);
            // 
            // Btn_Reporte_Egresos_Conta
            // 
            this.Btn_Reporte_Egresos_Conta.Location = new System.Drawing.Point(443, 235);
            this.Btn_Reporte_Egresos_Conta.Name = "Btn_Reporte_Egresos_Conta";
            this.Btn_Reporte_Egresos_Conta.Size = new System.Drawing.Size(222, 46);
            this.Btn_Reporte_Egresos_Conta.TabIndex = 10;
            this.Btn_Reporte_Egresos_Conta.Text = "Reporte de Egresos";
            this.Btn_Reporte_Egresos_Conta.UseVisualStyleBackColor = true;
            this.Btn_Reporte_Egresos_Conta.Click += new System.EventHandler(this.btnReporte_Egresos_Conta_Click);
            // 
            // Btn_Reporte_Ingresos_Conta
            // 
            this.Btn_Reporte_Ingresos_Conta.Location = new System.Drawing.Point(103, 235);
            this.Btn_Reporte_Ingresos_Conta.Name = "Btn_Reporte_Ingresos_Conta";
            this.Btn_Reporte_Ingresos_Conta.Size = new System.Drawing.Size(222, 46);
            this.Btn_Reporte_Ingresos_Conta.TabIndex = 9;
            this.Btn_Reporte_Ingresos_Conta.Text = "Reporte de Ingresos";
            this.Btn_Reporte_Ingresos_Conta.UseVisualStyleBackColor = true;
            this.Btn_Reporte_Ingresos_Conta.Click += new System.EventHandler(this.btnReporteIngresos_Conta_Click);
            // 
            // Btn_Registro_Egreso_conta
            // 
            this.Btn_Registro_Egreso_conta.Location = new System.Drawing.Point(443, 163);
            this.Btn_Registro_Egreso_conta.Name = "Btn_Registro_Egreso_conta";
            this.Btn_Registro_Egreso_conta.Size = new System.Drawing.Size(222, 46);
            this.Btn_Registro_Egreso_conta.TabIndex = 8;
            this.Btn_Registro_Egreso_conta.Text = "Registrar Nuevo Egreso";
            this.Btn_Registro_Egreso_conta.UseVisualStyleBackColor = true;
            this.Btn_Registro_Egreso_conta.Click += new System.EventHandler(this.btnRegistroEgreso_conta_Click);
            // 
            // Lbl_Bienbenida
            // 
            this.Lbl_Bienbenida.AutoSize = true;
            this.Lbl_Bienbenida.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bienbenida.Location = new System.Drawing.Point(170, 78);
            this.Lbl_Bienbenida.Name = "Lbl_Bienbenida";
            this.Lbl_Bienbenida.Size = new System.Drawing.Size(126, 24);
            this.Lbl_Bienbenida.TabIndex = 7;
            this.Lbl_Bienbenida.Text = "Bienvenido";
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.Location = new System.Drawing.Point(34, 50);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(385, 24);
            this.Lbl_EIPG.TabIndex = 6;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // Btn_Registro_Ingreso_Conta
            // 
            this.Btn_Registro_Ingreso_Conta.Location = new System.Drawing.Point(103, 163);
            this.Btn_Registro_Ingreso_Conta.Name = "Btn_Registro_Ingreso_Conta";
            this.Btn_Registro_Ingreso_Conta.Size = new System.Drawing.Size(222, 46);
            this.Btn_Registro_Ingreso_Conta.TabIndex = 0;
            this.Btn_Registro_Ingreso_Conta.Text = "Registrar Nuevo Ingreso";
            this.Btn_Registro_Ingreso_Conta.UseVisualStyleBackColor = true;
            this.Btn_Registro_Ingreso_Conta.Click += new System.EventHandler(this.btnRegistroIngreso_Conta_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(331, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Menu_Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Contabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Contabilidad";
            this.Load += new System.EventHandler(this.Menu_Contabilidad_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button Btn_Reporte_General_Conta;
        private System.Windows.Forms.Button Btn_Reporte_Egresos_Conta;
        private System.Windows.Forms.Button Btn_Reporte_Ingresos_Conta;
        private System.Windows.Forms.Button Btn_Registro_Egreso_conta;
        private System.Windows.Forms.Label Lbl_Bienbenida;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.Button Btn_Registro_Ingreso_Conta;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblNombre_conta;
        public System.Windows.Forms.Label lblIdentidad_Conta;
    }
}
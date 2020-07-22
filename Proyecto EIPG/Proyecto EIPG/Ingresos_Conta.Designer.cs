namespace Proyecto_EIPG
{
    partial class Ingresos_Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos_Conta));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Identidad_Conta = new System.Windows.Forms.Label();
            this.Lbl_Nombre_conta = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Registro_Ingreso_Otros = new System.Windows.Forms.Button();
            this.Lbl_Bienbenida = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.Btn_Registro_Ingreso_MatYmensu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.Btn_Regresar);
            this.pnlContenedor.Controls.Add(this.Btn_Registro_Ingreso_Otros);
            this.pnlContenedor.Controls.Add(this.Lbl_Bienbenida);
            this.pnlContenedor.Controls.Add(this.Lbl_EIPG);
            this.pnlContenedor.Controls.Add(this.Btn_Registro_Ingreso_MatYmensu);
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1067, 554);
            this.pnlContenedor.TabIndex = 10;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_Cargo);
            this.panel1.Controls.Add(this.Lbl_Identidad_Conta);
            this.panel1.Controls.Add(this.Lbl_Nombre_conta);
            this.panel1.Location = new System.Drawing.Point(585, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 156);
            this.panel1.TabIndex = 13;
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cargo.Location = new System.Drawing.Point(175, 104);
            this.Lbl_Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Size = new System.Drawing.Size(99, 19);
            this.Lbl_Cargo.TabIndex = 3;
            this.Lbl_Cargo.Text = "Contabilidad";
            // 
            // Lbl_Identidad_Conta
            // 
            this.Lbl_Identidad_Conta.AutoSize = true;
            this.Lbl_Identidad_Conta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Identidad_Conta.Location = new System.Drawing.Point(140, 70);
            this.Lbl_Identidad_Conta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Identidad_Conta.Name = "Lbl_Identidad_Conta";
            this.Lbl_Identidad_Conta.Size = new System.Drawing.Size(0, 21);
            this.Lbl_Identidad_Conta.TabIndex = 2;
            this.Lbl_Identidad_Conta.Click += new System.EventHandler(this.Lbl_Identidad_Conta_Click);
            // 
            // Lbl_Nombre_conta
            // 
            this.Lbl_Nombre_conta.AutoSize = true;
            this.Lbl_Nombre_conta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_conta.Location = new System.Drawing.Point(67, 33);
            this.Lbl_Nombre_conta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre_conta.Name = "Lbl_Nombre_conta";
            this.Lbl_Nombre_conta.Size = new System.Drawing.Size(0, 21);
            this.Lbl_Nombre_conta.TabIndex = 1;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = global::Proyecto_EIPG.Properties.Resources.cerrar_sesion4;
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(406, 379);
            this.Btn_Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(216, 92);
            this.Btn_Regresar.TabIndex = 12;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Btn_Registro_Ingreso_Otros
            // 
            this.Btn_Registro_Ingreso_Otros.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro_Ingreso_Otros.Image = global::Proyecto_EIPG.Properties.Resources.otros_pagos;
            this.Btn_Registro_Ingreso_Otros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Registro_Ingreso_Otros.Location = new System.Drawing.Point(591, 269);
            this.Btn_Registro_Ingreso_Otros.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Registro_Ingreso_Otros.Name = "Btn_Registro_Ingreso_Otros";
            this.Btn_Registro_Ingreso_Otros.Size = new System.Drawing.Size(316, 57);
            this.Btn_Registro_Ingreso_Otros.TabIndex = 8;
            this.Btn_Registro_Ingreso_Otros.Text = "Otros Ingresos";
            this.Btn_Registro_Ingreso_Otros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registro_Ingreso_Otros.UseVisualStyleBackColor = true;
            this.Btn_Registro_Ingreso_Otros.Click += new System.EventHandler(this.btnRegistroIngreso_Otros_Click);
            // 
            // Lbl_Bienbenida
            // 
            this.Lbl_Bienbenida.AutoSize = true;
            this.Lbl_Bienbenida.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bienbenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Bienbenida.Location = new System.Drawing.Point(176, 91);
            this.Lbl_Bienbenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Bienbenida.Name = "Lbl_Bienbenida";
            this.Lbl_Bienbenida.Size = new System.Drawing.Size(203, 49);
            this.Lbl_Bienbenida.TabIndex = 7;
            this.Lbl_Bienbenida.Text = "Ingresos";
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_EIPG.Location = new System.Drawing.Point(13, 56);
            this.Lbl_EIPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(560, 35);
            this.Lbl_EIPG.TabIndex = 6;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // Btn_Registro_Ingreso_MatYmensu
            // 
            this.Btn_Registro_Ingreso_MatYmensu.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro_Ingreso_MatYmensu.Image = global::Proyecto_EIPG.Properties.Resources.mensualidad_2;
            this.Btn_Registro_Ingreso_MatYmensu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registro_Ingreso_MatYmensu.Location = new System.Drawing.Point(117, 269);
            this.Btn_Registro_Ingreso_MatYmensu.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Registro_Ingreso_MatYmensu.Name = "Btn_Registro_Ingreso_MatYmensu";
            this.Btn_Registro_Ingreso_MatYmensu.Size = new System.Drawing.Size(316, 57);
            this.Btn_Registro_Ingreso_MatYmensu.TabIndex = 0;
            this.Btn_Registro_Ingreso_MatYmensu.Text = "Matricula y Mensualidades";
            this.Btn_Registro_Ingreso_MatYmensu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Registro_Ingreso_MatYmensu.UseVisualStyleBackColor = true;
            this.Btn_Registro_Ingreso_MatYmensu.Click += new System.EventHandler(this.btnRegistroIngreso_MatYmensu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 215);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Ingresos_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingresos_Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.Ingresos_Conta_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Identidad_Conta;
        private System.Windows.Forms.Label Lbl_Nombre_conta;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Registro_Ingreso_Otros;
        private System.Windows.Forms.Label Lbl_Bienbenida;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.Button Btn_Registro_Ingreso_MatYmensu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
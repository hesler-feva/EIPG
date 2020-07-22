namespace Proyecto_EIPG
{
    partial class Otros_ingresos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otros_ingresos));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha_Otro_ingreso = new System.Windows.Forms.Label();
            this.Msk_ID_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Txt_Descripcion_Ingreso = new System.Windows.Forms.TextBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Lbl_ID_Monto = new System.Windows.Forms.Label();
            this.Lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Pago = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Identidad_Conta = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Conta = new System.Windows.Forms.Label();
            this.Btn_Finalizar_Transac = new System.Windows.Forms.Button();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Lbl_Ingresos = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.lbl_fecha_Otro_ingreso);
            this.pnlContenedor.Controls.Add(this.Msk_ID_Cliente);
            this.pnlContenedor.Controls.Add(this.Lbl_Descripcion);
            this.pnlContenedor.Controls.Add(this.Txt_Descripcion_Ingreso);
            this.pnlContenedor.Controls.Add(this.Txt_Monto);
            this.pnlContenedor.Controls.Add(this.Lbl_ID_Monto);
            this.pnlContenedor.Controls.Add(this.Lbl_Id_Cliente);
            this.pnlContenedor.Controls.Add(this.Lbl_Fecha_Pago);
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.Btn_Finalizar_Transac);
            this.pnlContenedor.Controls.Add(this.Btn_Regresar);
            this.pnlContenedor.Controls.Add(this.Lbl_Ingresos);
            this.pnlContenedor.Controls.Add(this.Lbl_EIPG);
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1067, 554);
            this.pnlContenedor.TabIndex = 13;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 527);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "ingrese un monto en enteros";
            // 
            // lbl_fecha_Otro_ingreso
            // 
            this.lbl_fecha_Otro_ingreso.AutoSize = true;
            this.lbl_fecha_Otro_ingreso.Location = new System.Drawing.Point(289, 168);
            this.lbl_fecha_Otro_ingreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_Otro_ingreso.Name = "lbl_fecha_Otro_ingreso";
            this.lbl_fecha_Otro_ingreso.Size = new System.Drawing.Size(0, 17);
            this.lbl_fecha_Otro_ingreso.TabIndex = 101;
            // 
            // Msk_ID_Cliente
            // 
            this.Msk_ID_Cliente.Location = new System.Drawing.Point(141, 256);
            this.Msk_ID_Cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Msk_ID_Cliente.Mask = "0000-0000-00000";
            this.Msk_ID_Cliente.Name = "Msk_ID_Cliente";
            this.Msk_ID_Cliente.Size = new System.Drawing.Size(361, 22);
            this.Msk_ID_Cliente.TabIndex = 2;
            this.Msk_ID_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Msk_ID_Cliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_ID_Cliente_MaskInputRejected);
            this.Msk_ID_Cliente.Validated += new System.EventHandler(this.Msk_ID_Cliente_Validated);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(708, 374);
            this.Lbl_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(133, 17);
            this.Lbl_Descripcion.TabIndex = 100;
            this.Lbl_Descripcion.Text = "Descripción Ingreso";
            // 
            // Txt_Descripcion_Ingreso
            // 
            this.Txt_Descripcion_Ingreso.Location = new System.Drawing.Point(591, 202);
            this.Txt_Descripcion_Ingreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Descripcion_Ingreso.MaxLength = 200;
            this.Txt_Descripcion_Ingreso.Multiline = true;
            this.Txt_Descripcion_Ingreso.Name = "Txt_Descripcion_Ingreso";
            this.Txt_Descripcion_Ingreso.Size = new System.Drawing.Size(365, 170);
            this.Txt_Descripcion_Ingreso.TabIndex = 99;
            this.Txt_Descripcion_Ingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_ingreso_KeyPress);
            this.Txt_Descripcion_Ingreso.Validated += new System.EventHandler(this.txt_descripcion_ingreso_Validated);
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(141, 331);
            this.Txt_Monto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Monto.MaxLength = 5;
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(361, 22);
            this.Txt_Monto.TabIndex = 93;
            this.Txt_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // Lbl_ID_Monto
            // 
            this.Lbl_ID_Monto.AutoSize = true;
            this.Lbl_ID_Monto.Location = new System.Drawing.Point(289, 355);
            this.Lbl_ID_Monto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ID_Monto.Name = "Lbl_ID_Monto";
            this.Lbl_ID_Monto.Size = new System.Drawing.Size(47, 17);
            this.Lbl_ID_Monto.TabIndex = 90;
            this.Lbl_ID_Monto.Text = "Monto";
            // 
            // Lbl_Id_Cliente
            // 
            this.Lbl_Id_Cliente.AutoSize = true;
            this.Lbl_Id_Cliente.Location = new System.Drawing.Point(236, 281);
            this.Lbl_Id_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Cliente.Name = "Lbl_Id_Cliente";
            this.Lbl_Id_Cliente.Size = new System.Drawing.Size(159, 17);
            this.Lbl_Id_Cliente.TabIndex = 84;
            this.Lbl_Id_Cliente.Text = "No. de Identidad Cliente";
            // 
            // Lbl_Fecha_Pago
            // 
            this.Lbl_Fecha_Pago.AutoSize = true;
            this.Lbl_Fecha_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Pago.Location = new System.Drawing.Point(241, 199);
            this.Lbl_Fecha_Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Pago.Name = "Lbl_Fecha_Pago";
            this.Lbl_Fecha_Pago.Size = new System.Drawing.Size(169, 17);
            this.Lbl_Fecha_Pago.TabIndex = 81;
            this.Lbl_Fecha_Pago.Text = "Fecha de Transacción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_Cargo);
            this.panel1.Controls.Add(this.Lbl_Identidad_Conta);
            this.panel1.Controls.Add(this.Lbl_Nombre_Conta);
            this.panel1.Location = new System.Drawing.Point(585, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 156);
            this.panel1.TabIndex = 13;
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cargo.Location = new System.Drawing.Point(170, 104);
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
            // 
            // Lbl_Nombre_Conta
            // 
            this.Lbl_Nombre_Conta.AutoSize = true;
            this.Lbl_Nombre_Conta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Conta.Location = new System.Drawing.Point(67, 33);
            this.Lbl_Nombre_Conta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre_Conta.Name = "Lbl_Nombre_Conta";
            this.Lbl_Nombre_Conta.Size = new System.Drawing.Size(0, 21);
            this.Lbl_Nombre_Conta.TabIndex = 1;
            this.Lbl_Nombre_Conta.Click += new System.EventHandler(this.Lbl_Nombre_Conta_Click);
            // 
            // Btn_Finalizar_Transac
            // 
            this.Btn_Finalizar_Transac.Location = new System.Drawing.Point(591, 446);
            this.Btn_Finalizar_Transac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Finalizar_Transac.Name = "Btn_Finalizar_Transac";
            this.Btn_Finalizar_Transac.Size = new System.Drawing.Size(165, 57);
            this.Btn_Finalizar_Transac.TabIndex = 12;
            this.Btn_Finalizar_Transac.Text = "Finalizar transacción";
            this.Btn_Finalizar_Transac.UseVisualStyleBackColor = true;
            this.Btn_Finalizar_Transac.Click += new System.EventHandler(this.btnFinalizar_Transac_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(343, 446);
            this.Btn_Regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(165, 57);
            this.Btn_Regresar.TabIndex = 8;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Lbl_Ingresos
            // 
            this.Lbl_Ingresos.AutoSize = true;
            this.Lbl_Ingresos.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ingresos.Location = new System.Drawing.Point(194, 91);
            this.Lbl_Ingresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Ingresos.Name = "Lbl_Ingresos";
            this.Lbl_Ingresos.Size = new System.Drawing.Size(203, 49);
            this.Lbl_Ingresos.TabIndex = 7;
            this.Lbl_Ingresos.Text = "Ingresos";
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.Location = new System.Drawing.Point(13, 56);
            this.Lbl_EIPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(560, 35);
            this.Lbl_EIPG.TabIndex = 6;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 103);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Otros_ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Otros_ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otros Ingresos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Otros_ingresos_FormClosing);
            this.Load += new System.EventHandler(this.Otros_ingresos_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label Lbl_ID_Monto;
        private System.Windows.Forms.Label Lbl_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Fecha_Pago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Identidad_Conta;
        private System.Windows.Forms.Label Lbl_Nombre_Conta;
        private System.Windows.Forms.Button Btn_Finalizar_Transac;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Label Lbl_Ingresos;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.TextBox Txt_Descripcion_Ingreso;
        public System.Windows.Forms.MaskedTextBox Msk_ID_Cliente;
        private System.Windows.Forms.Label lbl_fecha_Otro_ingreso;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label1;
    }
}
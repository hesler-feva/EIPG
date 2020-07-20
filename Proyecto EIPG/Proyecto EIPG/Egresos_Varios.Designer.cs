namespace Proyecto_EIPG
{
    partial class Egresos_Varios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos_Varios));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Msk_Identidad = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Motivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Fecha_Egreso = new System.Windows.Forms.Label();
            this.lbl_fecha_transaccion = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Lbl_ID_Monto = new System.Windows.Forms.Label();
            this.Txt_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Pago = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Identidad_Conta = new System.Windows.Forms.Label();
            this.Lbl_Nombre_conta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Finalizar_Transac = new System.Windows.Forms.Button();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Lbl_Egresos = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
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
            this.pnlContenedor.Controls.Add(this.Btn_Limpiar);
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.Btn_Buscar);
            this.pnlContenedor.Controls.Add(this.Msk_Identidad);
            this.pnlContenedor.Controls.Add(this.Cmb_Motivo);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.lbl_Fecha_Egreso);
            this.pnlContenedor.Controls.Add(this.lbl_fecha_transaccion);
            this.pnlContenedor.Controls.Add(this.lbl_Descripcion);
            this.pnlContenedor.Controls.Add(this.Txt_Descripcion);
            this.pnlContenedor.Controls.Add(this.Txt_Monto);
            this.pnlContenedor.Controls.Add(this.Lbl_ID_Monto);
            this.pnlContenedor.Controls.Add(this.Txt_Nombre_Cliente);
            this.pnlContenedor.Controls.Add(this.Lbl_Nombre_Cliente);
            this.pnlContenedor.Controls.Add(this.Lbl_Id_Cliente);
            this.pnlContenedor.Controls.Add(this.Lbl_Fecha_Pago);
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.Btn_Finalizar_Transac);
            this.pnlContenedor.Controls.Add(this.Btn_Regresar);
            this.pnlContenedor.Controls.Add(this.Lbl_Egresos);
            this.pnlContenedor.Controls.Add(this.Lbl_EIPG);
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 14;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(367, 363);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(124, 46);
            this.Btn_Limpiar.TabIndex = 106;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "El monto debe ser un número entero";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(257, 199);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(81, 37);
            this.Btn_Buscar.TabIndex = 6;
            this.Btn_Buscar.Text = "Buscar Empleado";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Msk_Identidad
            // 
            this.Msk_Identidad.Location = new System.Drawing.Point(106, 243);
            this.Msk_Identidad.Mask = "0000-0000-00000";
            this.Msk_Identidad.Name = "Msk_Identidad";
            this.Msk_Identidad.Size = new System.Drawing.Size(272, 20);
            this.Msk_Identidad.TabIndex = 2;
            this.Msk_Identidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cmb_Motivo
            // 
            this.Cmb_Motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Motivo.FormattingEnabled = true;
            this.Cmb_Motivo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.Cmb_Motivo.Location = new System.Drawing.Point(106, 199);
            this.Cmb_Motivo.Name = "Cmb_Motivo";
            this.Cmb_Motivo.Size = new System.Drawing.Size(112, 21);
            this.Cmb_Motivo.TabIndex = 1;
            this.Cmb_Motivo.SelectedIndexChanged += new System.EventHandler(this.cmb_motivo_SelectedIndexChanged);
            this.Cmb_Motivo.RightToLeftChanged += new System.EventHandler(this.cmb_motivo_RightToLeftChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Motivo Egreso";
            // 
            // lbl_Fecha_Egreso
            // 
            this.lbl_Fecha_Egreso.AutoSize = true;
            this.lbl_Fecha_Egreso.Location = new System.Drawing.Point(217, 164);
            this.lbl_Fecha_Egreso.Name = "lbl_Fecha_Egreso";
            this.lbl_Fecha_Egreso.Size = new System.Drawing.Size(0, 13);
            this.lbl_Fecha_Egreso.TabIndex = 102;
            // 
            // lbl_fecha_transaccion
            // 
            this.lbl_fecha_transaccion.AutoSize = true;
            this.lbl_fecha_transaccion.Location = new System.Drawing.Point(207, 167);
            this.lbl_fecha_transaccion.Name = "lbl_fecha_transaccion";
            this.lbl_fecha_transaccion.Size = new System.Drawing.Size(0, 13);
            this.lbl_fecha_transaccion.TabIndex = 101;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(531, 306);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(99, 13);
            this.lbl_Descripcion.TabIndex = 100;
            this.lbl_Descripcion.Text = "Descripción Egreso";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(443, 164);
            this.Txt_Descripcion.MaxLength = 200;
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(275, 139);
            this.Txt_Descripcion.TabIndex = 5;
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(106, 323);
            this.Txt_Monto.MaxLength = 5;
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(272, 20);
            this.Txt_Monto.TabIndex = 4;
            this.Txt_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Monto.TextChanged += new System.EventHandler(this.tbxID_Padre_TextChanged);
            this.Txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxID_Padre_KeyPress);
            // 
            // Lbl_ID_Monto
            // 
            this.Lbl_ID_Monto.AutoSize = true;
            this.Lbl_ID_Monto.Location = new System.Drawing.Point(217, 347);
            this.Lbl_ID_Monto.Name = "Lbl_ID_Monto";
            this.Lbl_ID_Monto.Size = new System.Drawing.Size(37, 13);
            this.Lbl_ID_Monto.TabIndex = 90;
            this.Lbl_ID_Monto.Text = "Monto";
            // 
            // Txt_Nombre_Cliente
            // 
            this.Txt_Nombre_Cliente.Location = new System.Drawing.Point(103, 281);
            this.Txt_Nombre_Cliente.MaxLength = 200;
            this.Txt_Nombre_Cliente.Name = "Txt_Nombre_Cliente";
            this.Txt_Nombre_Cliente.Size = new System.Drawing.Size(275, 20);
            this.Txt_Nombre_Cliente.TabIndex = 3;
            this.Txt_Nombre_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Nombre_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_Cliente_KeyPress);
            this.Txt_Nombre_Cliente.Validated += new System.EventHandler(this.tbxNombre_Cliente_Validated);
            // 
            // Lbl_Nombre_Cliente
            // 
            this.Lbl_Nombre_Cliente.AutoSize = true;
            this.Lbl_Nombre_Cliente.Location = new System.Drawing.Point(187, 304);
            this.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente";
            this.Lbl_Nombre_Cliente.Size = new System.Drawing.Size(91, 13);
            this.Lbl_Nombre_Cliente.TabIndex = 86;
            this.Lbl_Nombre_Cliente.Text = "Nombre Completo";
            // 
            // Lbl_Id_Cliente
            // 
            this.Lbl_Id_Cliente.AutoSize = true;
            this.Lbl_Id_Cliente.Location = new System.Drawing.Point(177, 265);
            this.Lbl_Id_Cliente.Name = "Lbl_Id_Cliente";
            this.Lbl_Id_Cliente.Size = new System.Drawing.Size(121, 13);
            this.Lbl_Id_Cliente.TabIndex = 84;
            this.Lbl_Id_Cliente.Text = "No. de Identidad Cliente";
            // 
            // Lbl_Fecha_Pago
            // 
            this.Lbl_Fecha_Pago.AutoSize = true;
            this.Lbl_Fecha_Pago.Location = new System.Drawing.Point(182, 183);
            this.Lbl_Fecha_Pago.Name = "Lbl_Fecha_Pago";
            this.Lbl_Fecha_Pago.Size = new System.Drawing.Size(114, 13);
            this.Lbl_Fecha_Pago.TabIndex = 81;
            this.Lbl_Fecha_Pago.Text = "Fecha de Transacción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_Cargo);
            this.panel1.Controls.Add(this.Lbl_Identidad_Conta);
            this.panel1.Controls.Add(this.Lbl_Nombre_conta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(462, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 127);
            this.panel1.TabIndex = 38;
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Location = new System.Drawing.Point(105, 81);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Cargo.TabIndex = 37;
            this.Lbl_Cargo.Text = "Contabilidad";
            // 
            // Lbl_Identidad_Conta
            // 
            this.Lbl_Identidad_Conta.AutoSize = true;
            this.Lbl_Identidad_Conta.Location = new System.Drawing.Point(92, 54);
            this.Lbl_Identidad_Conta.Name = "Lbl_Identidad_Conta";
            this.Lbl_Identidad_Conta.Size = new System.Drawing.Size(91, 13);
            this.Lbl_Identidad_Conta.TabIndex = 36;
            this.Lbl_Identidad_Conta.Text = "0000-0000-00000";
            // 
            // Lbl_Nombre_conta
            // 
            this.Lbl_Nombre_conta.AutoSize = true;
            this.Lbl_Nombre_conta.Location = new System.Drawing.Point(39, 26);
            this.Lbl_Nombre_conta.Name = "Lbl_Nombre_conta";
            this.Lbl_Nombre_conta.Size = new System.Drawing.Size(186, 13);
            this.Lbl_Nombre_conta.TabIndex = 35;
            this.Lbl_Nombre_conta.Text = "Nombre1 Nombre2 Apellido1 Apelido2";
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
            // Btn_Finalizar_Transac
            // 
            this.Btn_Finalizar_Transac.Location = new System.Drawing.Point(534, 363);
            this.Btn_Finalizar_Transac.Name = "Btn_Finalizar_Transac";
            this.Btn_Finalizar_Transac.Size = new System.Drawing.Size(124, 46);
            this.Btn_Finalizar_Transac.TabIndex = 8;
            this.Btn_Finalizar_Transac.Text = "Finalizar transacción";
            this.Btn_Finalizar_Transac.UseVisualStyleBackColor = true;
            this.Btn_Finalizar_Transac.Click += new System.EventHandler(this.btnFinalizar_Transac_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(180, 363);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(124, 46);
            this.Btn_Regresar.TabIndex = 7;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Lbl_Egresos
            // 
            this.Lbl_Egresos.AutoSize = true;
            this.Lbl_Egresos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Egresos.Location = new System.Drawing.Point(181, 92);
            this.Lbl_Egresos.Name = "Lbl_Egresos";
            this.Lbl_Egresos.Size = new System.Drawing.Size(92, 24);
            this.Lbl_Egresos.TabIndex = 34;
            this.Lbl_Egresos.Text = "Egresos";
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.Location = new System.Drawing.Point(34, 50);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(385, 24);
            this.Lbl_EIPG.TabIndex = 33;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Egresos_Varios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Egresos_Varios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos Varios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Egresos_Varios_FormClosing);
            this.Load += new System.EventHandler(this.Egresos_Varios_Load);
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
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_ID_Monto;
        private System.Windows.Forms.Label Lbl_Nombre_Cliente;
        private System.Windows.Forms.Label Lbl_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Fecha_Pago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Identidad_Conta;
        private System.Windows.Forms.Label Lbl_Nombre_conta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Finalizar_Transac;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Label Lbl_Egresos;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_fecha_transaccion;
        private System.Windows.Forms.Label lbl_Fecha_Egreso;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Cmb_Motivo;
        private System.Windows.Forms.Button Btn_Buscar;
        public System.Windows.Forms.TextBox Txt_Nombre_Cliente;
        public System.Windows.Forms.MaskedTextBox Msk_Identidad;
        public System.Windows.Forms.TextBox Txt_Descripcion;
        public System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}
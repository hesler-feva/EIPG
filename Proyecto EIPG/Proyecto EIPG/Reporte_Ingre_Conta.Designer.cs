namespace Proyecto_EIPG
{
    partial class Reporte_Ingre_Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Ingre_Conta));
            this.pnlReporte_Conta = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_Final = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Inicial = new System.Windows.Forms.DateTimePicker();
            this.Btn_Buscar_Factura = new System.Windows.Forms.Button();
            this.Lbl_Cod_Factura = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Lbl_Total_Ingresos_Conta = new System.Windows.Forms.Label();
            this.dgvReporte_Ingre_Conta = new System.Windows.Forms.DataGridView();
            this.Btn_Generar_Reporte = new System.Windows.Forms.Button();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.PnlInfo_Usuario = new System.Windows.Forms.Panel();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Identidad_Conta = new System.Windows.Forms.Label();
            this.Lbl_Nombre_conta = new System.Windows.Forms.Label();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Ingresos = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.pnlReporte_Conta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte_Ingre_Conta)).BeginInit();
            this.PnlInfo_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReporte_Conta
            // 
            this.pnlReporte_Conta.Controls.Add(this.label3);
            this.pnlReporte_Conta.Controls.Add(this.label2);
            this.pnlReporte_Conta.Controls.Add(this.label1);
            this.pnlReporte_Conta.Controls.Add(this.Dtp_Final);
            this.pnlReporte_Conta.Controls.Add(this.Dtp_Inicial);
            this.pnlReporte_Conta.Controls.Add(this.Btn_Buscar_Factura);
            this.pnlReporte_Conta.Controls.Add(this.Lbl_Cod_Factura);
            this.pnlReporte_Conta.Controls.Add(this.Txt_total);
            this.pnlReporte_Conta.Controls.Add(this.Lbl_Total_Ingresos_Conta);
            this.pnlReporte_Conta.Controls.Add(this.dgvReporte_Ingre_Conta);
            this.pnlReporte_Conta.Controls.Add(this.Btn_Generar_Reporte);
            this.pnlReporte_Conta.Controls.Add(this.Btn_Regresar);
            this.pnlReporte_Conta.Controls.Add(this.PnlInfo_Usuario);
            this.pnlReporte_Conta.Controls.Add(this.Lbl_Ingresos);
            this.pnlReporte_Conta.Controls.Add(this.Lbl_EIPG);
            this.pnlReporte_Conta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReporte_Conta.Location = new System.Drawing.Point(0, 0);
            this.pnlReporte_Conta.Name = "pnlReporte_Conta";
            this.pnlReporte_Conta.Size = new System.Drawing.Size(800, 526);
            this.pnlReporte_Conta.TabIndex = 3;
            this.pnlReporte_Conta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReporte_Conta_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Fecha Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "a";
            // 
            // Dtp_Final
            // 
            this.Dtp_Final.Location = new System.Drawing.Point(424, 141);
            this.Dtp_Final.Name = "Dtp_Final";
            this.Dtp_Final.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Final.TabIndex = 105;
            // 
            // Dtp_Inicial
            // 
            this.Dtp_Inicial.Location = new System.Drawing.Point(207, 140);
            this.Dtp_Inicial.Name = "Dtp_Inicial";
            this.Dtp_Inicial.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Inicial.TabIndex = 104;
            // 
            // Btn_Buscar_Factura
            // 
            this.Btn_Buscar_Factura.Location = new System.Drawing.Point(651, 140);
            this.Btn_Buscar_Factura.Name = "Btn_Buscar_Factura";
            this.Btn_Buscar_Factura.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar_Factura.TabIndex = 103;
            this.Btn_Buscar_Factura.Text = "Buscar";
            this.Btn_Buscar_Factura.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Factura.Click += new System.EventHandler(this.btnBuscar_Factura_Click);
            // 
            // Lbl_Cod_Factura
            // 
            this.Lbl_Cod_Factura.AutoSize = true;
            this.Lbl_Cod_Factura.Location = new System.Drawing.Point(89, 146);
            this.Lbl_Cod_Factura.Name = "Lbl_Cod_Factura";
            this.Lbl_Cod_Factura.Size = new System.Drawing.Size(110, 13);
            this.Lbl_Cod_Factura.TabIndex = 102;
            this.Lbl_Cod_Factura.Text = "Busqueda Por Fecha:";
            // 
            // Txt_total
            // 
            this.Txt_total.Enabled = false;
            this.Txt_total.Location = new System.Drawing.Point(448, 445);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(100, 20);
            this.Txt_total.TabIndex = 86;
            // 
            // Lbl_Total_Ingresos_Conta
            // 
            this.Lbl_Total_Ingresos_Conta.AutoSize = true;
            this.Lbl_Total_Ingresos_Conta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total_Ingresos_Conta.Location = new System.Drawing.Point(292, 445);
            this.Lbl_Total_Ingresos_Conta.Name = "Lbl_Total_Ingresos_Conta";
            this.Lbl_Total_Ingresos_Conta.Size = new System.Drawing.Size(150, 20);
            this.Lbl_Total_Ingresos_Conta.TabIndex = 83;
            this.Lbl_Total_Ingresos_Conta.Text = "Total Ingresos:";
            // 
            // dgvReporte_Ingre_Conta
            // 
            this.dgvReporte_Ingre_Conta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte_Ingre_Conta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte_Ingre_Conta.Location = new System.Drawing.Point(101, 184);
            this.dgvReporte_Ingre_Conta.Name = "dgvReporte_Ingre_Conta";
            this.dgvReporte_Ingre_Conta.ReadOnly = true;
            this.dgvReporte_Ingre_Conta.Size = new System.Drawing.Size(596, 258);
            this.dgvReporte_Ingre_Conta.TabIndex = 81;
            // 
            // Btn_Generar_Reporte
            // 
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(675, 491);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(94, 23);
            this.Btn_Generar_Reporte.TabIndex = 77;
            this.Btn_Generar_Reporte.Text = "Generar Reporte";
            this.Btn_Generar_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Generar_Reporte.Click += new System.EventHandler(this.btnGenerar_Reporte_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(575, 491);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(94, 23);
            this.Btn_Regresar.TabIndex = 76;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // PnlInfo_Usuario
            // 
            this.PnlInfo_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Cargo);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Identidad_Conta);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Nombre_conta);
            this.PnlInfo_Usuario.Controls.Add(this.pbxUsuario);
            this.PnlInfo_Usuario.Location = new System.Drawing.Point(458, 8);
            this.PnlInfo_Usuario.Name = "PnlInfo_Usuario";
            this.PnlInfo_Usuario.Size = new System.Drawing.Size(334, 127);
            this.PnlInfo_Usuario.TabIndex = 14;
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Location = new System.Drawing.Point(101, 81);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Cargo.TabIndex = 3;
            this.Lbl_Cargo.Text = "Contabilidad";
            // 
            // Lbl_Identidad_Conta
            // 
            this.Lbl_Identidad_Conta.AutoSize = true;
            this.Lbl_Identidad_Conta.Location = new System.Drawing.Point(92, 54);
            this.Lbl_Identidad_Conta.Name = "Lbl_Identidad_Conta";
            this.Lbl_Identidad_Conta.Size = new System.Drawing.Size(91, 13);
            this.Lbl_Identidad_Conta.TabIndex = 2;
            this.Lbl_Identidad_Conta.Text = "0000-0000-00000";
            // 
            // Lbl_Nombre_conta
            // 
            this.Lbl_Nombre_conta.AutoSize = true;
            this.Lbl_Nombre_conta.Location = new System.Drawing.Point(39, 26);
            this.Lbl_Nombre_conta.Name = "Lbl_Nombre_conta";
            this.Lbl_Nombre_conta.Size = new System.Drawing.Size(186, 13);
            this.Lbl_Nombre_conta.TabIndex = 1;
            this.Lbl_Nombre_conta.Text = "Nombre1 Nombre2 Apellido1 Apelido2";
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(231, 15);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(100, 98);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 0;
            this.pbxUsuario.TabStop = false;
            // 
            // Lbl_Ingresos
            // 
            this.Lbl_Ingresos.AutoSize = true;
            this.Lbl_Ingresos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ingresos.Location = new System.Drawing.Point(124, 80);
            this.Lbl_Ingresos.Name = "Lbl_Ingresos";
            this.Lbl_Ingresos.Size = new System.Drawing.Size(201, 24);
            this.Lbl_Ingresos.TabIndex = 16;
            this.Lbl_Ingresos.Text = "Reportes Ingresos";
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.Location = new System.Drawing.Point(31, 43);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(385, 24);
            this.Lbl_EIPG.TabIndex = 15;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // Reporte_Ingre_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.pnlReporte_Conta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte_Ingre_Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Contable de Ingresos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporte_Ingre_Conta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_Ingre_Conta_FormClosed);
            this.Load += new System.EventHandler(this.Reporte_Ingre_Conta_Load);
            this.pnlReporte_Conta.ResumeLayout(false);
            this.pnlReporte_Conta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte_Ingre_Conta)).EndInit();
            this.PnlInfo_Usuario.ResumeLayout(false);
            this.PnlInfo_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReporte_Conta;
        private System.Windows.Forms.Label Lbl_Total_Ingresos_Conta;
        private System.Windows.Forms.DataGridView dgvReporte_Ingre_Conta;
        private System.Windows.Forms.Button Btn_Generar_Reporte;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Panel PnlInfo_Usuario;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Identidad_Conta;
        private System.Windows.Forms.Label Lbl_Nombre_conta;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.Label Lbl_Ingresos;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_Final;
        private System.Windows.Forms.DateTimePicker Dtp_Inicial;
        private System.Windows.Forms.Button Btn_Buscar_Factura;
        private System.Windows.Forms.Label Lbl_Cod_Factura;
    }
}
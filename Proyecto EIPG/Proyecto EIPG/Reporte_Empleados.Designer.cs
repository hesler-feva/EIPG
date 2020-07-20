namespace Proyecto_EIPG
{
    partial class Reporte_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Empleados));
            this.pnlReporte_Alum = new System.Windows.Forms.Panel();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar_Alum = new System.Windows.Forms.Button();
            this.Txt_NoIdentidad_empleado = new System.Windows.Forms.TextBox();
            this.Lbl_No_Identidad_Alum = new System.Windows.Forms.Label();
            this.Btn_Generar_Reporte = new System.Windows.Forms.Button();
            this.PnlInfo_Usuario = new System.Windows.Forms.Panel();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Identidad_Admin = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Admin = new System.Windows.Forms.Label();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Registro_Alum = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdbn_E_inactivo = new System.Windows.Forms.RadioButton();
            this.rdbn_E_activo = new System.Windows.Forms.RadioButton();
            this.pnlReporte_Alum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PnlInfo_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReporte_Alum
            // 
            this.pnlReporte_Alum.Controls.Add(this.rdbn_E_inactivo);
            this.pnlReporte_Alum.Controls.Add(this.rdbn_E_activo);
            this.pnlReporte_Alum.Controls.Add(this.Btn_refrescar);
            this.pnlReporte_Alum.Controls.Add(this.Btn_Regresar);
            this.pnlReporte_Alum.Controls.Add(this.label1);
            this.pnlReporte_Alum.Controls.Add(this.dataGridView1);
            this.pnlReporte_Alum.Controls.Add(this.Btn_Buscar_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Txt_NoIdentidad_empleado);
            this.pnlReporte_Alum.Controls.Add(this.Lbl_No_Identidad_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Btn_Generar_Reporte);
            this.pnlReporte_Alum.Controls.Add(this.PnlInfo_Usuario);
            this.pnlReporte_Alum.Controls.Add(this.Lbl_Registro_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Lbl_EIPG);
            this.pnlReporte_Alum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReporte_Alum.Location = new System.Drawing.Point(0, 0);
            this.pnlReporte_Alum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlReporte_Alum.Name = "pnlReporte_Alum";
            this.pnlReporte_Alum.Size = new System.Drawing.Size(1067, 662);
            this.pnlReporte_Alum.TabIndex = 2;
            this.pnlReporte_Alum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReporte_Alum_Paint);
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Location = new System.Drawing.Point(884, 175);
            this.Btn_refrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(100, 28);
            this.Btn_refrescar.TabIndex = 91;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            this.Btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(583, 613);
            this.Btn_Regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Regresar.TabIndex = 90;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 615);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 82;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 255);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 348);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Buscar_Alum
            // 
            this.Btn_Buscar_Alum.Location = new System.Drawing.Point(776, 175);
            this.Btn_Buscar_Alum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Buscar_Alum.Name = "Btn_Buscar_Alum";
            this.Btn_Buscar_Alum.Size = new System.Drawing.Size(100, 28);
            this.Btn_Buscar_Alum.TabIndex = 80;
            this.Btn_Buscar_Alum.Text = "Buscar";
            this.Btn_Buscar_Alum.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Alum.Click += new System.EventHandler(this.btnBuscar_Alum_Click);
            // 
            // Txt_NoIdentidad_empleado
            // 
            this.Txt_NoIdentidad_empleado.Location = new System.Drawing.Point(379, 177);
            this.Txt_NoIdentidad_empleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NoIdentidad_empleado.MaxLength = 50;
            this.Txt_NoIdentidad_empleado.Name = "Txt_NoIdentidad_empleado";
            this.Txt_NoIdentidad_empleado.Size = new System.Drawing.Size(365, 22);
            this.Txt_NoIdentidad_empleado.TabIndex = 79;
            this.Txt_NoIdentidad_empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNoIdentidad_empleado_KeyPress);
            // 
            // Lbl_No_Identidad_Alum
            // 
            this.Lbl_No_Identidad_Alum.AutoSize = true;
            this.Lbl_No_Identidad_Alum.Location = new System.Drawing.Point(12, 186);
            this.Lbl_No_Identidad_Alum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_No_Identidad_Alum.Name = "Lbl_No_Identidad_Alum";
            this.Lbl_No_Identidad_Alum.Size = new System.Drawing.Size(365, 17);
            this.Lbl_No_Identidad_Alum.TabIndex = 78;
            this.Lbl_No_Identidad_Alum.Text = "Buscar empleado por primer Nombre o No. de Identidad:";
            // 
            // Btn_Generar_Reporte
            // 
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(703, 613);
            this.Btn_Generar_Reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(125, 28);
            this.Btn_Generar_Reporte.TabIndex = 77;
            this.Btn_Generar_Reporte.Text = "Generar Reporte";
            this.Btn_Generar_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Generar_Reporte.Click += new System.EventHandler(this.btnGenerar_Reporte_Click);
            // 
            // PnlInfo_Usuario
            // 
            this.PnlInfo_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Cargo);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Identidad_Admin);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Nombre_Admin);
            this.PnlInfo_Usuario.Controls.Add(this.pbxUsuario);
            this.PnlInfo_Usuario.Location = new System.Drawing.Point(611, 10);
            this.PnlInfo_Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlInfo_Usuario.Name = "PnlInfo_Usuario";
            this.PnlInfo_Usuario.Size = new System.Drawing.Size(445, 156);
            this.PnlInfo_Usuario.TabIndex = 14;
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Location = new System.Drawing.Point(135, 100);
            this.Lbl_Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Size = new System.Drawing.Size(95, 17);
            this.Lbl_Cargo.TabIndex = 3;
            this.Lbl_Cargo.Text = "Administrador";
            // 
            // Lbl_Identidad_Admin
            // 
            this.Lbl_Identidad_Admin.AutoSize = true;
            this.Lbl_Identidad_Admin.Location = new System.Drawing.Point(123, 66);
            this.Lbl_Identidad_Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Identidad_Admin.Name = "Lbl_Identidad_Admin";
            this.Lbl_Identidad_Admin.Size = new System.Drawing.Size(122, 17);
            this.Lbl_Identidad_Admin.TabIndex = 2;
            this.Lbl_Identidad_Admin.Text = "0000-0000-00000";
            // 
            // Lbl_Nombre_Admin
            // 
            this.Lbl_Nombre_Admin.AutoSize = true;
            this.Lbl_Nombre_Admin.Location = new System.Drawing.Point(52, 32);
            this.Lbl_Nombre_Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre_Admin.Name = "Lbl_Nombre_Admin";
            this.Lbl_Nombre_Admin.Size = new System.Drawing.Size(249, 17);
            this.Lbl_Nombre_Admin.TabIndex = 1;
            this.Lbl_Nombre_Admin.Text = "Nombre1 Nombre2 Apellido1 Apelido2";
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(308, 18);
            this.pbxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(133, 121);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 0;
            this.pbxUsuario.TabStop = false;
            // 
            // Lbl_Registro_Alum
            // 
            this.Lbl_Registro_Alum.AutoSize = true;
            this.Lbl_Registro_Alum.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Registro_Alum.Location = new System.Drawing.Point(219, 91);
            this.Lbl_Registro_Alum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Registro_Alum.Name = "Lbl_Registro_Alum";
            this.Lbl_Registro_Alum.Size = new System.Drawing.Size(120, 29);
            this.Lbl_Registro_Alum.TabIndex = 16;
            this.Lbl_Registro_Alum.Text = "Registro";
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.Location = new System.Drawing.Point(41, 53);
            this.Lbl_EIPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(469, 29);
            this.Lbl_EIPG.TabIndex = 15;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // rdbn_E_inactivo
            // 
            this.rdbn_E_inactivo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdbn_E_inactivo.AutoSize = true;
            this.rdbn_E_inactivo.Location = new System.Drawing.Point(219, 216);
            this.rdbn_E_inactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbn_E_inactivo.Name = "rdbn_E_inactivo";
            this.rdbn_E_inactivo.Size = new System.Drawing.Size(158, 21);
            this.rdbn_E_inactivo.TabIndex = 94;
            this.rdbn_E_inactivo.Text = "Empleados Inactivos";
            this.rdbn_E_inactivo.UseVisualStyleBackColor = true;
            this.rdbn_E_inactivo.CheckedChanged += new System.EventHandler(this.rdbn_E_inactivo_CheckedChanged);
            // 
            // rdbn_E_activo
            // 
            this.rdbn_E_activo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdbn_E_activo.AutoSize = true;
            this.rdbn_E_activo.Location = new System.Drawing.Point(31, 216);
            this.rdbn_E_activo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbn_E_activo.Name = "rdbn_E_activo";
            this.rdbn_E_activo.Size = new System.Drawing.Size(148, 21);
            this.rdbn_E_activo.TabIndex = 93;
            this.rdbn_E_activo.Text = "Empleados Activos";
            this.rdbn_E_activo.UseVisualStyleBackColor = true;
            this.rdbn_E_activo.CheckedChanged += new System.EventHandler(this.rdbn_E_activo_CheckedChanged);
            // 
            // Reporte_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 662);
            this.Controls.Add(this.pnlReporte_Alum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporte_Empleados_FormClosing);
            this.Load += new System.EventHandler(this.Reporte_Empleados_Load);
            this.pnlReporte_Alum.ResumeLayout(false);
            this.pnlReporte_Alum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PnlInfo_Usuario.ResumeLayout(false);
            this.PnlInfo_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReporte_Alum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Buscar_Alum;
        private System.Windows.Forms.TextBox Txt_NoIdentidad_empleado;
        private System.Windows.Forms.Label Lbl_No_Identidad_Alum;
        private System.Windows.Forms.Button Btn_Generar_Reporte;
        private System.Windows.Forms.Panel PnlInfo_Usuario;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Identidad_Admin;
        private System.Windows.Forms.Label Lbl_Nombre_Admin;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.Label Lbl_Registro_Alum;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.RadioButton rdbn_E_inactivo;
        private System.Windows.Forms.RadioButton rdbn_E_activo;
    }
}
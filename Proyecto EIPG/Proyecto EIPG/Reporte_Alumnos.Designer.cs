namespace Proyecto_EIPG
{
    partial class Reporte_Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Alumnos));
            this.pnlReporte_Alum = new System.Windows.Forms.Panel();
            this.Rdbn_A_inactivos = new System.Windows.Forms.RadioButton();
            this.Rdbn_A_activos = new System.Windows.Forms.RadioButton();
            this.btn_alum_grado = new System.Windows.Forms.Button();
            this.Rdbn_Morosos = new System.Windows.Forms.RadioButton();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar_Alum = new System.Windows.Forms.Button();
            this.Txt_NoIdentidad_Alum = new System.Windows.Forms.TextBox();
            this.Lbl_No_Identidad_Alum = new System.Windows.Forms.Label();
            this.Btn_Generar_Reporte = new System.Windows.Forms.Button();
            this.PnlInfo_Usuario = new System.Windows.Forms.Panel();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Identidad_Admin = new System.Windows.Forms.Label();
            this.Lbl_Nombre_admin = new System.Windows.Forms.Label();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Registro_Alum = new System.Windows.Forms.Label();
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.reportalumTableAdapter1 = new Proyecto_EIPG.finalDataSetTableAdapters.reportalumTableAdapter();
            this.pnlReporte_Alum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PnlInfo_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReporte_Alum
            // 
            this.pnlReporte_Alum.Controls.Add(this.Rdbn_A_inactivos);
            this.pnlReporte_Alum.Controls.Add(this.Rdbn_A_activos);
            this.pnlReporte_Alum.Controls.Add(this.btn_alum_grado);
            this.pnlReporte_Alum.Controls.Add(this.Rdbn_Morosos);
            this.pnlReporte_Alum.Controls.Add(this.Btn_Regresar);
            this.pnlReporte_Alum.Controls.Add(this.dataGridView1);
            this.pnlReporte_Alum.Controls.Add(this.Btn_Buscar_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Txt_NoIdentidad_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Lbl_No_Identidad_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Btn_Generar_Reporte);
            this.pnlReporte_Alum.Controls.Add(this.PnlInfo_Usuario);
            this.pnlReporte_Alum.Controls.Add(this.Lbl_Registro_Alum);
            this.pnlReporte_Alum.Controls.Add(this.Lbl_EIPG);
            this.pnlReporte_Alum.Location = new System.Drawing.Point(0, 0);
            this.pnlReporte_Alum.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReporte_Alum.Name = "pnlReporte_Alum";
            this.pnlReporte_Alum.Size = new System.Drawing.Size(1067, 671);
            this.pnlReporte_Alum.TabIndex = 1;
            this.pnlReporte_Alum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReporte_Alum_Paint);
            // 
            // Rdbn_A_inactivos
            // 
            this.Rdbn_A_inactivos.AutoSize = true;
            this.Rdbn_A_inactivos.Location = new System.Drawing.Point(461, 132);
            this.Rdbn_A_inactivos.Margin = new System.Windows.Forms.Padding(4);
            this.Rdbn_A_inactivos.Name = "Rdbn_A_inactivos";
            this.Rdbn_A_inactivos.Size = new System.Drawing.Size(142, 21);
            this.Rdbn_A_inactivos.TabIndex = 98;
            this.Rdbn_A_inactivos.TabStop = true;
            this.Rdbn_A_inactivos.Text = "Alumnos Inactivos";
            this.Rdbn_A_inactivos.UseVisualStyleBackColor = true;
            this.Rdbn_A_inactivos.CheckedChanged += new System.EventHandler(this.Rdbn_A_inactivos_CheckedChanged);
            // 
            // Rdbn_A_activos
            // 
            this.Rdbn_A_activos.AutoSize = true;
            this.Rdbn_A_activos.Location = new System.Drawing.Point(289, 132);
            this.Rdbn_A_activos.Margin = new System.Windows.Forms.Padding(4);
            this.Rdbn_A_activos.Name = "Rdbn_A_activos";
            this.Rdbn_A_activos.Size = new System.Drawing.Size(132, 21);
            this.Rdbn_A_activos.TabIndex = 97;
            this.Rdbn_A_activos.TabStop = true;
            this.Rdbn_A_activos.Text = "Alumnos Activos";
            this.Rdbn_A_activos.UseVisualStyleBackColor = true;
            this.Rdbn_A_activos.CheckedChanged += new System.EventHandler(this.Rdbn_A_activos_CheckedChanged);
            // 
            // btn_alum_grado
            // 
            this.btn_alum_grado.Location = new System.Drawing.Point(743, 628);
            this.btn_alum_grado.Name = "btn_alum_grado";
            this.btn_alum_grado.Size = new System.Drawing.Size(149, 28);
            this.btn_alum_grado.TabIndex = 94;
            this.btn_alum_grado.Text = "Alumnos por Grado";
            this.btn_alum_grado.UseVisualStyleBackColor = true;
            this.btn_alum_grado.Click += new System.EventHandler(this.btn_alum_grado_Click);
            // 
            // Rdbn_Morosos
            // 
            this.Rdbn_Morosos.AutoSize = true;
            this.Rdbn_Morosos.Location = new System.Drawing.Point(16, 132);
            this.Rdbn_Morosos.Margin = new System.Windows.Forms.Padding(4);
            this.Rdbn_Morosos.Name = "Rdbn_Morosos";
            this.Rdbn_Morosos.Size = new System.Drawing.Size(253, 21);
            this.Rdbn_Morosos.TabIndex = 93;
            this.Rdbn_Morosos.TabStop = true;
            this.Rdbn_Morosos.Text = "Listar alumnos con saldo pendiente";
            this.Rdbn_Morosos.UseVisualStyleBackColor = true;
            this.Rdbn_Morosos.CheckedChanged += new System.EventHandler(this.rdbn_morosos_CheckedChanged);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(503, 628);
            this.Btn_Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Regresar.TabIndex = 89;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 412);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Buscar_Alum
            // 
            this.Btn_Buscar_Alum.Location = new System.Drawing.Point(511, 95);
            this.Btn_Buscar_Alum.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar_Alum.Name = "Btn_Buscar_Alum";
            this.Btn_Buscar_Alum.Size = new System.Drawing.Size(100, 28);
            this.Btn_Buscar_Alum.TabIndex = 80;
            this.Btn_Buscar_Alum.Text = "Buscar";
            this.Btn_Buscar_Alum.UseVisualStyleBackColor = true;
            this.Btn_Buscar_Alum.Click += new System.EventHandler(this.btnBuscar_Alum_Click);
            // 
            // Txt_NoIdentidad_Alum
            // 
            this.Txt_NoIdentidad_Alum.Location = new System.Drawing.Point(308, 95);
            this.Txt_NoIdentidad_Alum.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NoIdentidad_Alum.MaxLength = 50;
            this.Txt_NoIdentidad_Alum.Name = "Txt_NoIdentidad_Alum";
            this.Txt_NoIdentidad_Alum.Size = new System.Drawing.Size(168, 22);
            this.Txt_NoIdentidad_Alum.TabIndex = 79;
            this.Txt_NoIdentidad_Alum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoIdentidad_Alum_KeyPress);
            // 
            // Lbl_No_Identidad_Alum
            // 
            this.Lbl_No_Identidad_Alum.AutoSize = true;
            this.Lbl_No_Identidad_Alum.Location = new System.Drawing.Point(12, 101);
            this.Lbl_No_Identidad_Alum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_No_Identidad_Alum.Name = "Lbl_No_Identidad_Alum";
            this.Lbl_No_Identidad_Alum.Size = new System.Drawing.Size(304, 17);
            this.Lbl_No_Identidad_Alum.TabIndex = 78;
            this.Lbl_No_Identidad_Alum.Text = "Buscar Alumno por primer Nombre o Identidad:";
            // 
            // Btn_Generar_Reporte
            // 
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(611, 628);
            this.Btn_Generar_Reporte.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(125, 28);
            this.Btn_Generar_Reporte.TabIndex = 29;
            this.Btn_Generar_Reporte.Text = "Generar Reporte";
            this.Btn_Generar_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Generar_Reporte.Click += new System.EventHandler(this.btnGenerar_Reporte_Click);
            // 
            // PnlInfo_Usuario
            // 
            this.PnlInfo_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.PnlInfo_Usuario.Controls.Add(this.Btn_Refrescar);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Cargo);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Identidad_Admin);
            this.PnlInfo_Usuario.Controls.Add(this.Lbl_Nombre_admin);
            this.PnlInfo_Usuario.Controls.Add(this.pbxUsuario);
            this.PnlInfo_Usuario.Location = new System.Drawing.Point(611, 10);
            this.PnlInfo_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.PnlInfo_Usuario.Name = "PnlInfo_Usuario";
            this.PnlInfo_Usuario.Size = new System.Drawing.Size(445, 126);
            this.PnlInfo_Usuario.TabIndex = 14;
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.Location = new System.Drawing.Point(8, 85);
            this.Btn_Refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Refrescar.TabIndex = 90;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Location = new System.Drawing.Point(139, 81);
            this.Lbl_Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Size = new System.Drawing.Size(95, 17);
            this.Lbl_Cargo.TabIndex = 3;
            this.Lbl_Cargo.Text = "Administrador";
            // 
            // Lbl_Identidad_Admin
            // 
            this.Lbl_Identidad_Admin.AutoSize = true;
            this.Lbl_Identidad_Admin.Location = new System.Drawing.Point(123, 43);
            this.Lbl_Identidad_Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Identidad_Admin.Name = "Lbl_Identidad_Admin";
            this.Lbl_Identidad_Admin.Size = new System.Drawing.Size(122, 17);
            this.Lbl_Identidad_Admin.TabIndex = 2;
            this.Lbl_Identidad_Admin.Text = "0000-0000-00000";
            // 
            // Lbl_Nombre_admin
            // 
            this.Lbl_Nombre_admin.AutoSize = true;
            this.Lbl_Nombre_admin.Location = new System.Drawing.Point(52, 18);
            this.Lbl_Nombre_admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre_admin.Name = "Lbl_Nombre_admin";
            this.Lbl_Nombre_admin.Size = new System.Drawing.Size(249, 17);
            this.Lbl_Nombre_admin.TabIndex = 1;
            this.Lbl_Nombre_admin.Text = "Nombre1 Nombre2 Apellido1 Apelido2";
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(308, 18);
            this.pbxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(133, 92);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 0;
            this.pbxUsuario.TabStop = false;
            // 
            // Lbl_Registro_Alum
            // 
            this.Lbl_Registro_Alum.AutoSize = true;
            this.Lbl_Registro_Alum.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Registro_Alum.Location = new System.Drawing.Point(224, 53);
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
            this.Lbl_EIPG.Location = new System.Drawing.Point(41, 17);
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
            // reportalumTableAdapter1
            // 
            this.reportalumTableAdapter1.ClearBeforeFill = true;
            // 
            // Reporte_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 671);
            this.Controls.Add(this.pnlReporte_Alum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Alumnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporte_Alumnos_FormClosing);
            this.Load += new System.EventHandler(this.Reporte_Alumnos_Load);
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
        private System.Windows.Forms.Button Btn_Generar_Reporte;
        private System.Windows.Forms.Panel PnlInfo_Usuario;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Identidad_Admin;
        private System.Windows.Forms.Label Lbl_Nombre_admin;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.Label Lbl_Registro_Alum;
        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Buscar_Alum;
        private System.Windows.Forms.TextBox Txt_NoIdentidad_Alum;
        private System.Windows.Forms.Label Lbl_No_Identidad_Alum;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.RadioButton Rdbn_Morosos;
        private System.Windows.Forms.Button btn_alum_grado;
        private System.Windows.Forms.RadioButton Rdbn_A_inactivos;
        private System.Windows.Forms.RadioButton Rdbn_A_activos;
        private finalDataSetTableAdapters.reportalumTableAdapter reportalumTableAdapter1;
    }
}
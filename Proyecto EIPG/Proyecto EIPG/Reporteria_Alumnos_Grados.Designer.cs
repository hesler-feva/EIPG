namespace Proyecto_EIPG
{
    partial class Reporteria_Alumnos_Grados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporteria_Alumnos_Grados));
            this.Lbl_EIPG = new System.Windows.Forms.Label();
            this.Lbl_Registro_Alum = new System.Windows.Forms.Label();
            this.Cmb_Grado = new System.Windows.Forms.ComboBox();
            this.lbl_grado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_generar_rep = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.pnl_cont_report_grados = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_EIPG
            // 
            this.Lbl_EIPG.AutoSize = true;
            this.Lbl_EIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EIPG.Location = new System.Drawing.Point(59, 22);
            this.Lbl_EIPG.Name = "Lbl_EIPG";
            this.Lbl_EIPG.Size = new System.Drawing.Size(385, 24);
            this.Lbl_EIPG.TabIndex = 16;
            this.Lbl_EIPG.Text = "Escuela e Instituto Privado Gualaco";
            // 
            // Lbl_Registro_Alum
            // 
            this.Lbl_Registro_Alum.AutoSize = true;
            this.Lbl_Registro_Alum.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Registro_Alum.Location = new System.Drawing.Point(230, 53);
            this.Lbl_Registro_Alum.Name = "Lbl_Registro_Alum";
            this.Lbl_Registro_Alum.Size = new System.Drawing.Size(347, 24);
            this.Lbl_Registro_Alum.TabIndex = 17;
            this.Lbl_Registro_Alum.Text = "Reportes de Alumnos por Grado";
            // 
            // Cmb_Grado
            // 
            this.Cmb_Grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Grado.FormattingEnabled = true;
            this.Cmb_Grado.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.Cmb_Grado.Location = new System.Drawing.Point(85, 88);
            this.Cmb_Grado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Grado.Name = "Cmb_Grado";
            this.Cmb_Grado.Size = new System.Drawing.Size(92, 21);
            this.Cmb_Grado.TabIndex = 18;
            this.Cmb_Grado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_grado
            // 
            this.lbl_grado.AutoSize = true;
            this.lbl_grado.Location = new System.Drawing.Point(40, 90);
            this.lbl_grado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_grado.Name = "lbl_grado";
            this.lbl_grado.Size = new System.Drawing.Size(39, 13);
            this.lbl_grado.TabIndex = 19;
            this.lbl_grado.Text = "Grado:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 335);
            this.dataGridView1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_generar_rep
            // 
            this.btn_generar_rep.Location = new System.Drawing.Point(456, 486);
            this.btn_generar_rep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_generar_rep.Name = "btn_generar_rep";
            this.btn_generar_rep.Size = new System.Drawing.Size(94, 23);
            this.btn_generar_rep.TabIndex = 22;
            this.btn_generar_rep.Text = "Generar Reporte";
            this.btn_generar_rep.UseVisualStyleBackColor = true;
            this.btn_generar_rep.Click += new System.EventHandler(this.btn_generar_rep_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(562, 486);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(94, 23);
            this.btn_regresar.TabIndex = 23;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // pnl_cont_report_grados
            // 
            this.pnl_cont_report_grados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cont_report_grados.Location = new System.Drawing.Point(0, 0);
            this.pnl_cont_report_grados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_cont_report_grados.Name = "pnl_cont_report_grados";
            this.pnl_cont_report_grados.Size = new System.Drawing.Size(800, 545);
            this.pnl_cont_report_grados.TabIndex = 24;
            this.pnl_cont_report_grados.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_cont_report_grados_Paint);
            // 
            // Reporteria_Alumnos_Grados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_generar_rep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_grado);
            this.Controls.Add(this.Cmb_Grado);
            this.Controls.Add(this.Lbl_Registro_Alum);
            this.Controls.Add(this.Lbl_EIPG);
            this.Controls.Add(this.pnl_cont_report_grados);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reporteria_Alumnos_Grados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporteria_Alumnos_Grados";
            this.Load += new System.EventHandler(this.Reporteria_Alumnos_Grados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_EIPG;
        private System.Windows.Forms.Label Lbl_Registro_Alum;
        private System.Windows.Forms.Label lbl_grado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_generar_rep;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel pnl_cont_report_grados;
        private System.Windows.Forms.ComboBox Cmb_Grado;
    }
}
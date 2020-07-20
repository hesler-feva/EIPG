namespace Proyecto_EIPG
{
    partial class panel_cargar_mensualidad
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
            this.Lbl_No_Movil = new System.Windows.Forms.Label();
            this.Cmb_Nivel_Academico = new System.Windows.Forms.ComboBox();
            this.Lbl_Grado = new System.Windows.Forms.Label();
            this.Lbl_Infor_Personal_Emple = new System.Windows.Forms.Label();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_No_Movil
            // 
            this.Lbl_No_Movil.AutoSize = true;
            this.Lbl_No_Movil.Location = new System.Drawing.Point(37, 155);
            this.Lbl_No_Movil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_No_Movil.Name = "Lbl_No_Movil";
            this.Lbl_No_Movil.Size = new System.Drawing.Size(139, 17);
            this.Lbl_No_Movil.TabIndex = 112;
            this.Lbl_No_Movil.Text = "Porcentaje a Cargar:";
            // 
            // Cmb_Nivel_Academico
            // 
            this.Cmb_Nivel_Academico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Nivel_Academico.FormattingEnabled = true;
            this.Cmb_Nivel_Academico.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.Cmb_Nivel_Academico.Location = new System.Drawing.Point(199, 218);
            this.Cmb_Nivel_Academico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Nivel_Academico.Name = "Cmb_Nivel_Academico";
            this.Cmb_Nivel_Academico.Size = new System.Drawing.Size(148, 24);
            this.Cmb_Nivel_Academico.TabIndex = 110;
            // 
            // Lbl_Grado
            // 
            this.Lbl_Grado.AutoSize = true;
            this.Lbl_Grado.Location = new System.Drawing.Point(71, 222);
            this.Lbl_Grado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Grado.Name = "Lbl_Grado";
            this.Lbl_Grado.Size = new System.Drawing.Size(116, 17);
            this.Lbl_Grado.TabIndex = 109;
            this.Lbl_Grado.Text = "Nivel Académico:";
            // 
            // Lbl_Infor_Personal_Emple
            // 
            this.Lbl_Infor_Personal_Emple.AutoSize = true;
            this.Lbl_Infor_Personal_Emple.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Infor_Personal_Emple.Location = new System.Drawing.Point(108, 27);
            this.Lbl_Infor_Personal_Emple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Infor_Personal_Emple.Name = "Lbl_Infor_Personal_Emple";
            this.Lbl_Infor_Personal_Emple.Size = new System.Drawing.Size(230, 26);
            this.Lbl_Infor_Personal_Emple.TabIndex = 108;
            this.Lbl_Infor_Personal_Emple.Text = "Cargar Mensualidad";
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(172, 306);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Actualizar.TabIndex = 107;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(304, 306);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 28);
            this.btn_Cancelar.TabIndex = 114;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
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
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(199, 143);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 115;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 186);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel_cargar_mensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.Lbl_No_Movil);
            this.Controls.Add(this.Cmb_Nivel_Academico);
            this.Controls.Add(this.Lbl_Grado);
            this.Controls.Add(this.Lbl_Infor_Personal_Emple);
            this.Controls.Add(this.Btn_Actualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "panel_cargar_mensualidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "panel_cargar_mensualidad";
            this.Load += new System.EventHandler(this.panel_cargar_mensualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_No_Movil;
        public System.Windows.Forms.ComboBox Cmb_Nivel_Academico;
        private System.Windows.Forms.Label Lbl_Grado;
        private System.Windows.Forms.Label Lbl_Infor_Personal_Emple;
        public System.Windows.Forms.Button Btn_Actualizar;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
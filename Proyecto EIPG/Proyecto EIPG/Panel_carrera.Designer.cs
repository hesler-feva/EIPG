namespace Proyecto_EIPG
{
    partial class Panel_carrera
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
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Lbl_Infor_Personal_Emple = new System.Windows.Forms.Label();
            this.Cmb_Nivel_Academico = new System.Windows.Forms.ComboBox();
            this.Lbl_Grado = new System.Windows.Forms.Label();
            this.Txt_Nombre_Carrera = new System.Windows.Forms.TextBox();
            this.Lbl_No_Movil_Padre = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(80, 298);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Agregar.TabIndex = 100;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Infor_Personal_Emple
            // 
            this.Lbl_Infor_Personal_Emple.AutoSize = true;
            this.Lbl_Infor_Personal_Emple.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Infor_Personal_Emple.Location = new System.Drawing.Point(75, 41);
            this.Lbl_Infor_Personal_Emple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Infor_Personal_Emple.Name = "Lbl_Infor_Personal_Emple";
            this.Lbl_Infor_Personal_Emple.Size = new System.Drawing.Size(270, 26);
            this.Lbl_Infor_Personal_Emple.TabIndex = 101;
            this.Lbl_Infor_Personal_Emple.Text = "Información de Carrera";
            // 
            // Cmb_Nivel_Academico
            // 
            this.Cmb_Nivel_Academico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cmb_Nivel_Academico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Nivel_Academico.FormattingEnabled = true;
            this.Cmb_Nivel_Academico.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.Cmb_Nivel_Academico.Location = new System.Drawing.Point(175, 201);
            this.Cmb_Nivel_Academico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Nivel_Academico.Name = "Cmb_Nivel_Academico";
            this.Cmb_Nivel_Academico.Size = new System.Drawing.Size(148, 24);
            this.Cmb_Nivel_Academico.TabIndex = 103;
            // 
            // Lbl_Grado
            // 
            this.Lbl_Grado.AutoSize = true;
            this.Lbl_Grado.Location = new System.Drawing.Point(54, 204);
            this.Lbl_Grado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Grado.Name = "Lbl_Grado";
            this.Lbl_Grado.Size = new System.Drawing.Size(116, 17);
            this.Lbl_Grado.TabIndex = 102;
            this.Lbl_Grado.Text = "Nivel Académico:";
            // 
            // Txt_Nombre_Carrera
            // 
            this.Txt_Nombre_Carrera.Location = new System.Drawing.Point(161, 134);
            this.Txt_Nombre_Carrera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Nombre_Carrera.MaxLength = 76;
            this.Txt_Nombre_Carrera.Name = "Txt_Nombre_Carrera";
            this.Txt_Nombre_Carrera.ShortcutsEnabled = false;
            this.Txt_Nombre_Carrera.Size = new System.Drawing.Size(217, 22);
            this.Txt_Nombre_Carrera.TabIndex = 104;
            // 
            // Lbl_No_Movil_Padre
            // 
            this.Lbl_No_Movil_Padre.AutoSize = true;
            this.Lbl_No_Movil_Padre.Location = new System.Drawing.Point(14, 134);
            this.Lbl_No_Movil_Padre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_No_Movil_Padre.Name = "Lbl_No_Movil_Padre";
            this.Lbl_No_Movil_Padre.Size = new System.Drawing.Size(140, 17);
            this.Lbl_No_Movil_Padre.TabIndex = 105;
            this.Lbl_No_Movil_Padre.Text = "Nombre/Descripción:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(240, 298);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 106;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Panel_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 402);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.Txt_Nombre_Carrera);
            this.Controls.Add(this.Lbl_No_Movil_Padre);
            this.Controls.Add(this.Cmb_Nivel_Academico);
            this.Controls.Add(this.Lbl_Grado);
            this.Controls.Add(this.Lbl_Infor_Personal_Emple);
            this.Controls.Add(this.Btn_Agregar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Panel_carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel_carrera";
            this.Load += new System.EventHandler(this.Panel_carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label Lbl_Infor_Personal_Emple;
        public System.Windows.Forms.ComboBox Cmb_Nivel_Academico;
        private System.Windows.Forms.Label Lbl_Grado;
        public System.Windows.Forms.TextBox Txt_Nombre_Carrera;
        private System.Windows.Forms.Label Lbl_No_Movil_Padre;
        public System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
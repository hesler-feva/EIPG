namespace Proyecto_EIPG
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Recuperar_Contrasena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Correo_Electronico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Recuperar_Contrasena
            // 
            this.Btn_Recuperar_Contrasena.Location = new System.Drawing.Point(173, 163);
            this.Btn_Recuperar_Contrasena.Name = "Btn_Recuperar_Contrasena";
            this.Btn_Recuperar_Contrasena.Size = new System.Drawing.Size(75, 23);
            this.Btn_Recuperar_Contrasena.TabIndex = 14;
            this.Btn_Recuperar_Contrasena.Text = "Recuperar";
            this.Btn_Recuperar_Contrasena.UseVisualStyleBackColor = true;
            this.Btn_Recuperar_Contrasena.Click += new System.EventHandler(this.btnRecuperarContrasena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Correo";
            // 
            // Txt_Correo_Electronico
            // 
            this.Txt_Correo_Electronico.Location = new System.Drawing.Point(67, 165);
            this.Txt_Correo_Electronico.MaxLength = 76;
            this.Txt_Correo_Electronico.Name = "Txt_Correo_Electronico";
            this.Txt_Correo_Electronico.Size = new System.Drawing.Size(100, 20);
            this.Txt_Correo_Electronico.TabIndex = 12;
            this.Txt_Correo_Electronico.Leave += new System.EventHandler(this.txtCorreoElectronico_Leave);
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Recuperar_Contrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Correo_Electronico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olvido Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Recuperar_Contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Correo_Electronico;
    }
}
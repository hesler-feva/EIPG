namespace Proyecto_EIPG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Contrasena = new System.Windows.Forms.TextBox();
            this.Lbl_Contrasena = new System.Windows.Forms.Label();
            this.Lbl_NombreEIPG = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Link_Olvido_Contrasena = new System.Windows.Forms.LinkLabel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Location = new System.Drawing.Point(301, 326);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Ingresar.TabIndex = 3;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Usuario.Location = new System.Drawing.Point(310, 234);
            this.Lbl_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(76, 21);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "Usuario";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(183, 210);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Usuario.MaxLength = 76;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.ShortcutsEnabled = false;
            this.Txt_Usuario.Size = new System.Drawing.Size(315, 22);
            this.Txt_Usuario.TabIndex = 1;
            this.Txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUsuario_KeyPress);
            this.Txt_Usuario.Validated += new System.EventHandler(this.txtboxUsuario_Validated);
            // 
            // Txt_Contrasena
            // 
            this.Txt_Contrasena.Location = new System.Drawing.Point(183, 264);
            this.Txt_Contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Contrasena.MaxLength = 32;
            this.Txt_Contrasena.Name = "Txt_Contrasena";
            this.Txt_Contrasena.PasswordChar = '*';
            this.Txt_Contrasena.ShortcutsEnabled = false;
            this.Txt_Contrasena.Size = new System.Drawing.Size(315, 22);
            this.Txt_Contrasena.TabIndex = 2;
            this.Txt_Contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxContrasena_KeyPress);
            // 
            // Lbl_Contrasena
            // 
            this.Lbl_Contrasena.AutoSize = true;
            this.Lbl_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contrasena.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contrasena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Contrasena.Location = new System.Drawing.Point(295, 288);
            this.Lbl_Contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Contrasena.Name = "Lbl_Contrasena";
            this.Lbl_Contrasena.Size = new System.Drawing.Size(107, 21);
            this.Lbl_Contrasena.TabIndex = 3;
            this.Lbl_Contrasena.Text = "Contraseña";
            // 
            // Lbl_NombreEIPG
            // 
            this.Lbl_NombreEIPG.AutoSize = true;
            this.Lbl_NombreEIPG.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NombreEIPG.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreEIPG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NombreEIPG.Location = new System.Drawing.Point(44, 160);
            this.Lbl_NombreEIPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreEIPG.Name = "Lbl_NombreEIPG";
            this.Lbl_NombreEIPG.Size = new System.Drawing.Size(593, 38);
            this.Lbl_NombreEIPG.TabIndex = 5;
            this.Lbl_NombreEIPG.Text = "Escuela e Instituto Privado Gualaco";
            this.Lbl_NombreEIPG.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Link_Olvido_Contrasena
            // 
            this.Link_Olvido_Contrasena.AutoSize = true;
            this.Link_Olvido_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.Link_Olvido_Contrasena.LinkColor = System.Drawing.Color.Red;
            this.Link_Olvido_Contrasena.Location = new System.Drawing.Point(271, 356);
            this.Link_Olvido_Contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Link_Olvido_Contrasena.Name = "Link_Olvido_Contrasena";
            this.Link_Olvido_Contrasena.Size = new System.Drawing.Size(158, 17);
            this.Link_Olvido_Contrasena.TabIndex = 4;
            this.Link_Olvido_Contrasena.TabStop = true;
            this.Link_Olvido_Contrasena.Text = "¿Olvido su contraseña?";
            this.Link_Olvido_Contrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Proyecto_EIPG.Properties.Resources.fondo_menu;
            this.ClientSize = new System.Drawing.Size(712, 383);
            this.Controls.Add(this.Link_Olvido_Contrasena);
            this.Controls.Add(this.Lbl_NombreEIPG);
            this.Controls.Add(this.Txt_Contrasena);
            this.Controls.Add(this.Lbl_Contrasena);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Contrasena;
        private System.Windows.Forms.Label Lbl_Contrasena;
        private System.Windows.Forms.Label Lbl_NombreEIPG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Link_Olvido_Contrasena;
        private System.Windows.Forms.ErrorProvider error;
    }
}


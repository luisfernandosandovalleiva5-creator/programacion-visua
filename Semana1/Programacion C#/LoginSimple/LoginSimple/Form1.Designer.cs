namespace LoginSimple
{
    partial class Form1
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
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.CotraseñaLabel = new System.Windows.Forms.Label();
            this.TbContraseña = new System.Windows.Forms.TextBox();
            this.BtLogear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbUsuario
            // 
            this.TbUsuario.Location = new System.Drawing.Point(273, 166);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(232, 20);
            this.TbUsuario.TabIndex = 1;
            this.TbUsuario.TextChanged += new System.EventHandler(this.TbUsuario_TextChanged);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Location = new System.Drawing.Point(224, 166);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario";
            this.UsuarioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UsuarioLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CotraseñaLabel
            // 
            this.CotraseñaLabel.AutoSize = true;
            this.CotraseñaLabel.Location = new System.Drawing.Point(206, 208);
            this.CotraseñaLabel.Name = "CotraseñaLabel";
            this.CotraseñaLabel.Size = new System.Drawing.Size(61, 13);
            this.CotraseñaLabel.TabIndex = 2;
            this.CotraseñaLabel.Text = "Contraseña";
            // 
            // TbContraseña
            // 
            this.TbContraseña.Location = new System.Drawing.Point(273, 205);
            this.TbContraseña.Name = "TbContraseña";
            this.TbContraseña.PasswordChar = '*';
            this.TbContraseña.Size = new System.Drawing.Size(232, 20);
            this.TbContraseña.TabIndex = 3;
            // 
            // BtLogear
            // 
            this.BtLogear.Location = new System.Drawing.Point(273, 231);
            this.BtLogear.Name = "BtLogear";
            this.BtLogear.Size = new System.Drawing.Size(232, 37);
            this.BtLogear.TabIndex = 4;
            this.BtLogear.Text = "Login";
            this.BtLogear.UseVisualStyleBackColor = true;
            this.BtLogear.Click += new System.EventHandler(this.BtLogear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtLogear);
            this.Controls.Add(this.TbContraseña);
            this.Controls.Add(this.CotraseñaLabel);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.UsuarioLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label CotraseñaLabel;
        private System.Windows.Forms.TextBox TbContraseña;
        private System.Windows.Forms.Button BtLogear;
    }
}


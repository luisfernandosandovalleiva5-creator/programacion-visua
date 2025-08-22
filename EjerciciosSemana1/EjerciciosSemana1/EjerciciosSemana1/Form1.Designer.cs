namespace EjerciciosSemana1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtLogin = new Button();
            TbContraseña = new TextBox();
            label3 = new Label();
            TbUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            BtCalcular = new Button();
            TbPeso = new TextBox();
            label4 = new Label();
            TbAltura = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            CbConversion = new ComboBox();
            BtConvertir = new Button();
            TbTemperatura = new TextBox();
            label7 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            BtReset = new Button();
            BtClick = new Button();
            Display = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(351, 264);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtLogin);
            tabPage1.Controls.Add(TbContraseña);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(TbUsuario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(343, 236);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtLogin
            // 
            BtLogin.BackColor = Color.Firebrick;
            BtLogin.ForeColor = SystemColors.ButtonHighlight;
            BtLogin.Location = new Point(101, 184);
            BtLogin.Margin = new Padding(3, 2, 3, 2);
            BtLogin.Name = "BtLogin";
            BtLogin.Size = new Size(139, 36);
            BtLogin.TabIndex = 5;
            BtLogin.Text = "Iniciar Sesion";
            BtLogin.UseVisualStyleBackColor = false;
            BtLogin.Click += BtLogin_Click;
            // 
            // TbContraseña
            // 
            TbContraseña.Location = new Point(56, 134);
            TbContraseña.Margin = new Padding(3, 2, 3, 2);
            TbContraseña.Name = "TbContraseña";
            TbContraseña.PasswordChar = '*';
            TbContraseña.Size = new Size(226, 23);
            TbContraseña.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 116);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // TbUsuario
            // 
            TbUsuario.Location = new Point(56, 87);
            TbUsuario.Margin = new Padding(3, 2, 3, 2);
            TbUsuario.Name = "TbUsuario";
            TbUsuario.Size = new Size(226, 23);
            TbUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 70);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 16);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 0;
            label1.Text = "Login Simple";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtCalcular);
            tabPage2.Controls.Add(TbPeso);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TbAltura);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(343, 236);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "IMC";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtCalcular
            // 
            BtCalcular.BackColor = Color.Firebrick;
            BtCalcular.ForeColor = SystemColors.ButtonHighlight;
            BtCalcular.Location = new Point(105, 185);
            BtCalcular.Margin = new Padding(3, 2, 3, 2);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(139, 36);
            BtCalcular.TabIndex = 11;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = false;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // TbPeso
            // 
            TbPeso.Location = new Point(60, 134);
            TbPeso.Margin = new Padding(3, 2, 3, 2);
            TbPeso.Name = "TbPeso";
            TbPeso.Size = new Size(226, 23);
            TbPeso.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 117);
            label4.Name = "label4";
            label4.Size = new Size(100, 16);
            label4.TabIndex = 9;
            label4.Text = "Ingrese su peso en kg";
            // 
            // TbAltura
            // 
            TbAltura.Location = new Point(60, 88);
            TbAltura.Margin = new Padding(3, 2, 3, 2);
            TbAltura.Name = "TbAltura";
            TbAltura.Size = new Size(226, 23);
            TbAltura.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 70);
            label5.Name = "label5";
            label5.Size = new Size(120, 16);
            label5.TabIndex = 7;
            label5.Text = "Ingrese su altura en metros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 21);
            label6.Name = "label6";
            label6.Size = new Size(254, 29);
            label6.TabIndex = 6;
            label6.Text = "Calculadora de IMC";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(CbConversion);
            tabPage3.Controls.Add(BtConvertir);
            tabPage3.Controls.Add(TbTemperatura);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(343, 236);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Conversor";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CbConversion
            // 
            CbConversion.FormattingEnabled = true;
            CbConversion.Items.AddRange(new object[] { "Celcius a Farenheit", "Farenheit a Celcius" });
            CbConversion.Location = new Point(46, 55);
            CbConversion.Margin = new Padding(3, 2, 3, 2);
            CbConversion.Name = "CbConversion";
            CbConversion.Size = new Size(266, 23);
            CbConversion.TabIndex = 18;
            CbConversion.Text = "Seleccione su tipo de conversion";
            // 
            // BtConvertir
            // 
            BtConvertir.BackColor = Color.Firebrick;
            BtConvertir.ForeColor = SystemColors.ButtonHighlight;
            BtConvertir.Location = new Point(96, 190);
            BtConvertir.Margin = new Padding(3, 2, 3, 2);
            BtConvertir.Name = "BtConvertir";
            BtConvertir.Size = new Size(139, 36);
            BtConvertir.TabIndex = 17;
            BtConvertir.Text = "Convertir";
            BtConvertir.UseVisualStyleBackColor = false;
            BtConvertir.Click += button1_Click;
            // 
            // TbTemperatura
            // 
            TbTemperatura.Location = new Point(107, 136);
            TbTemperatura.Margin = new Padding(3, 2, 3, 2);
            TbTemperatura.Name = "TbTemperatura";
            TbTemperatura.Size = new Size(117, 23);
            TbTemperatura.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 109);
            label7.Name = "label7";
            label7.Size = new Size(99, 16);
            label7.TabIndex = 15;
            label7.Text = "Ingrese la temperatura";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 15);
            label9.Name = "label9";
            label9.Size = new Size(292, 23);
            label9.TabIndex = 12;
            label9.Text = "Conversor de Temperatura";
            label9.Click += label9_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BtReset);
            tabPage4.Controls.Add(BtClick);
            tabPage4.Controls.Add(Display);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(343, 236);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Contador";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtReset
            // 
            BtReset.BackColor = Color.Black;
            BtReset.ForeColor = SystemColors.ButtonHighlight;
            BtReset.Location = new Point(199, 107);
            BtReset.Margin = new Padding(3, 2, 3, 2);
            BtReset.Name = "BtReset";
            BtReset.Size = new Size(92, 30);
            BtReset.TabIndex = 2;
            BtReset.Text = "Reset";
            BtReset.UseVisualStyleBackColor = false;
            BtReset.Click += BtReset_Click;
            // 
            // BtClick
            // 
            BtClick.BackColor = Color.Firebrick;
            BtClick.ForeColor = SystemColors.ButtonHighlight;
            BtClick.Location = new Point(57, 107);
            BtClick.Margin = new Padding(3, 2, 3, 2);
            BtClick.Name = "BtClick";
            BtClick.Size = new Size(92, 30);
            BtClick.TabIndex = 1;
            BtClick.Text = "Click";
            BtClick.UseVisualStyleBackColor = false;
            BtClick.Click += BtClick_Click;
            // 
            // Display
            // 
            Display.AutoSize = true;
            Display.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display.Location = new Point(165, 55);
            Display.Name = "Display";
            Display.Size = new Size(24, 27);
            Display.TabIndex = 0;
            Display.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 267);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox TbContraseña;
        private Label label3;
        private TextBox TbUsuario;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button BtLogin;
        private Button BtCalcular;
        private TextBox TbPeso;
        private Label label4;
        private TextBox TbAltura;
        private Label label5;
        private Label label6;
        private Button BtConvertir;
        private TextBox TbTemperatura;
        private Label label7;
        private Label label9;
        private ComboBox CbConversion;
        private Button BtReset;
        private Button BtClick;
        private Label Display;
    }
}

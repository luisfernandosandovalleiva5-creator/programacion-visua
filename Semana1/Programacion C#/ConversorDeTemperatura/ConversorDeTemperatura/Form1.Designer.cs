namespace ConversorDeTemperatura
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
            Title = new Label();
            SelectConversion = new ComboBox();
            TBTemperatura = new TextBox();
            BtConvertir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(121, 35);
            Title.Name = "Title";
            Title.Size = new Size(294, 24);
            Title.TabIndex = 0;
            Title.Text = "Conversor de Temperaturas";
            Title.Click += label1_Click;
            // 
            // SelectConversion
            // 
            SelectConversion.BackColor = SystemColors.Window;
            SelectConversion.ForeColor = SystemColors.MenuText;
            SelectConversion.FormattingEnabled = true;
            SelectConversion.Items.AddRange(new object[] { "Celsius a Fahrenheit", "Fahrenheit a Celsius" });
            SelectConversion.Location = new Point(121, 79);
            SelectConversion.Name = "SelectConversion";
            SelectConversion.Size = new Size(294, 23);
            SelectConversion.TabIndex = 1;
            SelectConversion.Text = "Selecciona el tipo de conversión";
            SelectConversion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TBTemperatura
            // 
            TBTemperatura.Location = new Point(257, 133);
            TBTemperatura.Name = "TBTemperatura";
            TBTemperatura.Size = new Size(125, 23);
            TBTemperatura.TabIndex = 2;
            // 
            // BtConvertir
            // 
            BtConvertir.Location = new Point(212, 184);
            BtConvertir.Name = "BtConvertir";
            BtConvertir.Size = new Size(84, 42);
            BtConvertir.TabIndex = 3;
            BtConvertir.Text = "Convertir";
            BtConvertir.UseVisualStyleBackColor = true;
            BtConvertir.Click += BtConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 136);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingresa la temperatura";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 322);
            Controls.Add(label1);
            Controls.Add(BtConvertir);
            Controls.Add(TBTemperatura);
            Controls.Add(SelectConversion);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ComboBox SelectConversion;
        private TextBox TBTemperatura;
        private Button BtConvertir;
        private Label label1;
    }
}

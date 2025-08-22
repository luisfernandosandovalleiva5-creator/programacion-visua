namespace CalculadoraDeIMC
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
            label1 = new Label();
            TbPeso = new TextBox();
            TbAltura = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BtCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(166, 18);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de IMC";
            label1.Click += label1_Click;
            // 
            // TbPeso
            // 
            TbPeso.Location = new Point(198, 62);
            TbPeso.Name = "TbPeso";
            TbPeso.Size = new Size(167, 23);
            TbPeso.TabIndex = 1;
            // 
            // TbAltura
            // 
            TbAltura.Location = new Point(198, 109);
            TbAltura.Name = "TbAltura";
            TbAltura.Size = new Size(167, 23);
            TbAltura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 65);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingresa tu peso en kg.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 112);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 4;
            label3.Text = "Ingresa tu altura en metros.";
            // 
            // BtCalcular
            // 
            BtCalcular.Location = new Point(389, 79);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(144, 38);
            BtCalcular.TabIndex = 5;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 161);
            Controls.Add(BtCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TbAltura);
            Controls.Add(TbPeso);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbPeso;
        private TextBox TbAltura;
        private Label label2;
        private Label label3;
        private Button BtCalcular;
    }
}

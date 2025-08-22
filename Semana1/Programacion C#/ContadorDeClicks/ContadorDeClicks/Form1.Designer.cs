namespace ContadorDeClicks
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
            BtClick = new Button();
            Display = new Label();
            BtReset = new Button();
            SuspendLayout();
            // 
            // BtClick
            // 
            BtClick.FlatStyle = FlatStyle.System;
            BtClick.Location = new Point(12, 33);
            BtClick.Name = "BtClick";
            BtClick.Size = new Size(78, 55);
            BtClick.TabIndex = 0;
            BtClick.Text = "Click";
            BtClick.UseVisualStyleBackColor = true;
            BtClick.Click += BtClick_Click;
            // 
            // Display
            // 
            Display.AutoSize = true;
            Display.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display.Location = new Point(120, 45);
            Display.Name = "Display";
            Display.Size = new Size(22, 25);
            Display.TabIndex = 1;
            Display.Text = "0";
            Display.Click += label1_Click;
            // 
            // BtReset
            // 
            BtReset.FlatStyle = FlatStyle.System;
            BtReset.Location = new Point(173, 33);
            BtReset.Name = "BtReset";
            BtReset.Size = new Size(76, 55);
            BtReset.TabIndex = 2;
            BtReset.Text = "Reset";
            BtReset.UseVisualStyleBackColor = true;
            BtReset.Click += BtReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 123);
            Controls.Add(BtReset);
            Controls.Add(Display);
            Controls.Add(BtClick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtClick;
        private Label Display;
        private Button BtReset;
    }
}

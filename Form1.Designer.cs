﻿namespace Marcihelp
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 105);
            button1.Name = "button1";
            button1.Size = new Size(164, 46);
            button1.TabIndex = 0;
            button1.Text = "Ügyfelek címei";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 27);
            label1.Name = "label1";
            label1.Size = new Size(356, 28);
            label1.TabIndex = 1;
            label1.Text = "Marci adatbáziskezelő programja";
            // 
            // button2
            // 
            button2.Location = new Point(28, 172);
            button2.Name = "button2";
            button2.Size = new Size(164, 47);
            button2.TabIndex = 2;
            button2.Text = "Termekkategoriák";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 244);
            button3.Name = "button3";
            button3.Size = new Size(164, 50);
            button3.TabIndex = 3;
            button3.Text = "Rendelések kezelése";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 584);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}

﻿namespace Visualization
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.decorateBtn = new System.Windows.Forms.Button();
            this.undecorateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "СГЕНЕРИРОВАТЬ ОБЫЧНУЮ МАТРИЦУ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateNormalBtn_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 216);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "СГЕНЕРИРОВАТЬ РАЗРЕЖЕННУЮ МАТРИЦУ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateSparseBtn_click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(305, 259);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Рисовать границу";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.DrawBorderChkBox_CheckedChanged);
            // 
            // decorateBtn
            // 
            this.decorateBtn.Location = new System.Drawing.Point(189, 310);
            this.decorateBtn.Name = "decorateBtn";
            this.decorateBtn.Size = new System.Drawing.Size(176, 30);
            this.decorateBtn.TabIndex = 3;
            this.decorateBtn.Text = "ПЕРЕНУМЕРОВАТЬ";
            this.decorateBtn.UseVisualStyleBackColor = true;
            this.decorateBtn.Click += new System.EventHandler(this.DecorateBtn_Click);
            // 
            // undecorateBtn
            // 
            this.undecorateBtn.Location = new System.Drawing.Point(413, 310);
            this.undecorateBtn.Name = "undecorateBtn";
            this.undecorateBtn.Size = new System.Drawing.Size(162, 30);
            this.undecorateBtn.TabIndex = 4;
            this.undecorateBtn.Text = "ВОССТАНОВИТЬ";
            this.undecorateBtn.UseVisualStyleBackColor = true;
            this.undecorateBtn.Click += new System.EventHandler(this.UndecorateBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 474);
            this.Controls.Add(this.undecorateBtn);
            this.Controls.Add(this.decorateBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button decorateBtn;
        private System.Windows.Forms.Button undecorateBtn;
    }
}


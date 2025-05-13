namespace Project3._1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Add Flour and Egg.";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 208);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 1;
            label2.Text = "The mixing process is in progress.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 275);
            label3.Name = "label3";
            label3.Size = new Size(239, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingredients are added and mixed.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 343);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 3;
            label4.Text = "Pasta is being cooked.";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 164);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(306, 41);
            progressBar1.TabIndex = 8;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 231);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(306, 41);
            progressBar2.TabIndex = 9;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 298);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(306, 41);
            progressBar3.TabIndex = 10;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 366);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(306, 41);
            progressBar4.TabIndex = 11;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 174);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 242);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 309);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 377);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Azonix", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(48, 25);
            label9.Name = "label9";
            label9.Size = new Size(239, 30);
            label9.TabIndex = 16;
            label9.Text = "CakeBaking";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Azonix", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(12, 78);
            label10.Name = "label10";
            label10.Size = new Size(155, 13);
            label10.TabIndex = 17;
            label10.Text = "Tracking Screen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(338, 412);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Baking Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}

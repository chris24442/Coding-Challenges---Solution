namespace SoloLearn_Coding_Challenges
{
    partial class NBonacciNumberFinder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BonacciCalculate = new System.Windows.Forms.Button();
            this.ReturnToMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What order Bonacci sequence would you like to examine?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "What digit would you like to retrieve?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(362, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BonacciCalculate
            // 
            this.BonacciCalculate.Location = new System.Drawing.Point(362, 187);
            this.BonacciCalculate.Name = "BonacciCalculate";
            this.BonacciCalculate.Size = new System.Drawing.Size(100, 23);
            this.BonacciCalculate.TabIndex = 4;
            this.BonacciCalculate.Text = "Calculate";
            this.BonacciCalculate.UseVisualStyleBackColor = true;
            this.BonacciCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnToMainPage
            // 
            this.ReturnToMainPage.Location = new System.Drawing.Point(12, 12);
            this.ReturnToMainPage.Name = "ReturnToMainPage";
            this.ReturnToMainPage.Size = new System.Drawing.Size(71, 48);
            this.ReturnToMainPage.TabIndex = 5;
            this.ReturnToMainPage.Text = "Return to Main Page";
            this.ReturnToMainPage.UseVisualStyleBackColor = true;
            this.ReturnToMainPage.Click += new System.EventHandler(this.ReturnToMainPage_Click);
            // 
            // NBonacciNumberFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.ReturnToMainPage);
            this.Controls.Add(this.BonacciCalculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NBonacciNumberFinder";
            this.Text = "NBonacciNumberFinder";
            this.Load += new System.EventHandler(this.NBonacciNumberFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BonacciCalculate;
        private System.Windows.Forms.Button ReturnToMainPage;
    }
}
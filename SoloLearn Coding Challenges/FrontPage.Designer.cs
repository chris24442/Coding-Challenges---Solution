namespace SoloLearn_Coding_Challenges
{
    partial class SoloLearnCodingChallenges
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
            this.NBonacciNumberFinder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NBonacciNumberFinder
            // 
            this.NBonacciNumberFinder.Location = new System.Drawing.Point(55, 33);
            this.NBonacciNumberFinder.Name = "NBonacciNumberFinder";
            this.NBonacciNumberFinder.Size = new System.Drawing.Size(187, 23);
            this.NBonacciNumberFinder.TabIndex = 0;
            this.NBonacciNumberFinder.Text = "N-Bonacci Number Finder";
            this.NBonacciNumberFinder.UseVisualStyleBackColor = true;
            this.NBonacciNumberFinder.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Summations Calculator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SoloLearnCodingChallenges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NBonacciNumberFinder);
            this.Name = "SoloLearnCodingChallenges";
            this.Text = "SoloLearn Coding Challenges";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NBonacciNumberFinder;
        private System.Windows.Forms.Button button1;
    }
}


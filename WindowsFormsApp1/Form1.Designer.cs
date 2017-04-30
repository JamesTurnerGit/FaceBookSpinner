namespace WindowsFormsApp1
{
    partial class Spinner
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NamesForSpinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(54, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(902, 549);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NamesForSpinner
            // 
            this.NamesForSpinner.AutoSize = true;
            this.NamesForSpinner.Location = new System.Drawing.Point(51, 20);
            this.NamesForSpinner.Name = "NamesForSpinner";
            this.NamesForSpinner.Size = new System.Drawing.Size(97, 13);
            this.NamesForSpinner.TabIndex = 2;
            this.NamesForSpinner.Text = "Names For Spinner";
            this.NamesForSpinner.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Spinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NamesForSpinner);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spinner";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NamesForSpinner;
        private System.Windows.Forms.Button button1;
    }
}


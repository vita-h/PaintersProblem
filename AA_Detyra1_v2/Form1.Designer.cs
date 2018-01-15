namespace AA_Detyra1_v2
{
    partial class Form1
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
            this.nupNrPainters = new System.Windows.Forms.NumericUpDown();
            this.lblNrPainters = new System.Windows.Forms.Label();
            this.rtbRez = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupNrPainters)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nupNrPainters
            // 
            this.nupNrPainters.Location = new System.Drawing.Point(15, 29);
            this.nupNrPainters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNrPainters.Name = "nupNrPainters";
            this.nupNrPainters.Size = new System.Drawing.Size(95, 22);
            this.nupNrPainters.TabIndex = 3;
            this.nupNrPainters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNrPainters
            // 
            this.lblNrPainters.AutoSize = true;
            this.lblNrPainters.Location = new System.Drawing.Point(12, 9);
            this.lblNrPainters.Name = "lblNrPainters";
            this.lblNrPainters.Size = new System.Drawing.Size(98, 17);
            this.lblNrPainters.TabIndex = 1;
            this.lblNrPainters.Text = "Nr. of painters";
            // 
            // rtbRez
            // 
            this.rtbRez.Location = new System.Drawing.Point(15, 66);
            this.rtbRez.Name = "rtbRez";
            this.rtbRez.Size = new System.Drawing.Size(498, 320);
            this.rtbRez.TabIndex = 4;
            this.rtbRez.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 401);
            this.Controls.Add(this.rtbRez);
            this.Controls.Add(this.lblNrPainters);
            this.Controls.Add(this.nupNrPainters);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Painter\'s Problem";
            ((System.ComponentModel.ISupportInitialize)(this.nupNrPainters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nupNrPainters;
        private System.Windows.Forms.Label lblNrPainters;
        private System.Windows.Forms.RichTextBox rtbRez;
    }
}


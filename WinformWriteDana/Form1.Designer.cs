namespace WinformWriteDana
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
            this.lblTriangle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTriangle
            // 
            this.lblTriangle.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblTriangle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTriangle.Location = new System.Drawing.Point(12, 373);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(571, 120);
            this.lblTriangle.TabIndex = 0;
            this.lblTriangle.Text = "Start";
            this.lblTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTriangle.Click += new System.EventHandler(this.lblTriangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 492);
            this.Controls.Add(this.lblTriangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTriangle;
    }
}


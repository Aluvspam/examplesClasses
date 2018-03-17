namespace Solid_Examples
{
    partial class WriteDanaWinforms
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
            this.lblTriangle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangle.Location = new System.Drawing.Point(13, 13);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(613, 479);
            this.lblTriangle.TabIndex = 0;
            this.lblTriangle.Text = "Start";
            this.lblTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTriangle.Click += new System.EventHandler(this.lblTriangle_Click);
            // 
            // WriteDanaWinforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 489);
            this.Controls.Add(this.lblTriangle);
            this.Name = "WriteDanaWinforms";
            this.Text = "WriteDanaWinforms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTriangle;
    }
}
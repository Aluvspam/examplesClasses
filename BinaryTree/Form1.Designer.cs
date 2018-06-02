namespace BinaryTree
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbOriginalList = new System.Windows.Forms.Label();
            this.lbOrderedList = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.lbArray1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(33, 29);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(127, 20);
            this.tbNumber.TabIndex = 0;
            // 
            // lbOriginalList
            // 
            this.lbOriginalList.AutoSize = true;
            this.lbOriginalList.Location = new System.Drawing.Point(44, 67);
            this.lbOriginalList.Name = "lbOriginalList";
            this.lbOriginalList.Size = new System.Drawing.Size(64, 13);
            this.lbOriginalList.TabIndex = 1;
            this.lbOriginalList.Text = "Original List:";
            // 
            // lbOrderedList
            // 
            this.lbOrderedList.AutoSize = true;
            this.lbOrderedList.Location = new System.Drawing.Point(151, 102);
            this.lbOrderedList.Name = "lbOrderedList";
            this.lbOrderedList.Size = new System.Drawing.Size(54, 13);
            this.lbOrderedList.TabIndex = 2;
            this.lbOrderedList.Text = "pending...";
            // 
            // btGenerate
            // 
            this.btGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGenerate.Location = new System.Drawing.Point(166, 29);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbArray1
            // 
            this.lbArray1.AutoSize = true;
            this.lbArray1.Location = new System.Drawing.Point(151, 67);
            this.lbArray1.Name = "lbArray1";
            this.lbArray1.Size = new System.Drawing.Size(54, 13);
            this.lbArray1.TabIndex = 4;
            this.lbArray1.Text = "pending...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "InOrder Traversal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbArray1);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lbOrderedList);
            this.Controls.Add(this.lbOriginalList);
            this.Controls.Add(this.tbNumber);
            this.Name = "Form1";
            this.Text = "Binary Tree App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbOriginalList;
        private System.Windows.Forms.Label lbOrderedList;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label lbArray1;
        private System.Windows.Forms.Label label1;
    }
}
namespace FoundationClass
{
    partial class Frmexammoveit
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(67, 85);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(0, 13);
            this.lab1.TabIndex = 0;
            this.lab1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.lab1.Click += new System.EventHandler(this.lab1_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(99, 85);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(0, 13);
            this.lab2.TabIndex = 1;
            this.lab2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lab2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove_1);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frmexammoveit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Name = "Frmexammoveit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move it Exam";
            this.Load += new System.EventHandler(this.Frmexammoveit_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmexammoveit_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label1;

    }
}
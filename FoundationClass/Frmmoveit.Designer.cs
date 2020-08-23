namespace FoundationClass
{
    partial class Frmmoveit
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
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butHide = new System.Windows.Forms.Button();
            this.butHover = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(163, 46);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 20);
            this.txtx.TabIndex = 0;
            this.txtx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(163, 98);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(100, 20);
            this.txty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // butHide
            // 
            this.butHide.Location = new System.Drawing.Point(70, 193);
            this.butHide.Name = "butHide";
            this.butHide.Size = new System.Drawing.Size(75, 22);
            this.butHide.TabIndex = 4;
            this.butHide.Text = "Hide";
            this.butHide.UseVisualStyleBackColor = true;
            this.butHide.Click += new System.EventHandler(this.butHide_Click);
            // 
            // butHover
            // 
            this.butHover.Location = new System.Drawing.Point(188, 193);
            this.butHover.Name = "butHover";
            this.butHover.Size = new System.Drawing.Size(75, 22);
            this.butHover.TabIndex = 5;
            this.butHover.Text = "Hover";
            this.butHover.UseVisualStyleBackColor = true;
            this.butHover.MouseLeave += new System.EventHandler(this.butHover_MouseLeave);
            this.butHover.MouseHover += new System.EventHandler(this.butHover_MouseHover);
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(298, 193);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 22);
            this.butShow.TabIndex = 6;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Focus1";
            this.label3.MouseCaptureChanged += new System.EventHandler(this.label3_MouseCaptureChanged);
            this.label3.RegionChanged += new System.EventHandler(this.label3_RegionChanged);
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.CursorChanged += new System.EventHandler(this.label3_CursorChanged);
            this.label3.RightToLeftChanged += new System.EventHandler(this.label3_RightToLeftChanged);
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label3_MouseClick);
            this.label3.Enter += new System.EventHandler(this.label3_Enter);
            this.label3.TabIndexChanged += new System.EventHandler(this.label3_TabIndexChanged);
            this.label3.BindingContextChanged += new System.EventHandler(this.label3_BindingContextChanged);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.label3_DragEnter);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Focus2";
            this.label4.Enter += new System.EventHandler(this.label4_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Focus3";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.Enter += new System.EventHandler(this.label5_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Focus4";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.Enter += new System.EventHandler(this.label6_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Enter += new System.EventHandler(this.button3_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(307, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Enter += new System.EventHandler(this.button4_Enter);
            // 
            // Frmmoveit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 345);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butHover);
            this.Controls.Add(this.butHide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Name = "Frmmoveit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move it Project";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmmoveit_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butHide;
        private System.Windows.Forms.Button butHover;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
namespace FoundationClass
{
    partial class Frmdoit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.butDoIt = new System.Windows.Forms.Button();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoMul = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDiv);
            this.groupBox1.Controls.Add(this.rdoMul);
            this.groupBox1.Controls.Add(this.rdoSub);
            this.groupBox1.Controls.Add(this.rdoAdd);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "num1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(148, 148);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(148, 190);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "num2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(148, 228);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 6;
            // 
            // butDoIt
            // 
            this.butDoIt.Location = new System.Drawing.Point(132, 283);
            this.butDoIt.Name = "butDoIt";
            this.butDoIt.Size = new System.Drawing.Size(75, 23);
            this.butDoIt.TabIndex = 7;
            this.butDoIt.Text = "Do It";
            this.butDoIt.UseVisualStyleBackColor = true;
            this.butDoIt.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(19, 35);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(63, 17);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Addition";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(152, 35);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(84, 17);
            this.rdoSub.TabIndex = 1;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "Substraction";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoMul
            // 
            this.rdoMul.AutoSize = true;
            this.rdoMul.Location = new System.Drawing.Point(19, 76);
            this.rdoMul.Name = "rdoMul";
            this.rdoMul.Size = new System.Drawing.Size(86, 17);
            this.rdoMul.TabIndex = 2;
            this.rdoMul.TabStop = true;
            this.rdoMul.Text = "Multiplication";
            this.rdoMul.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(152, 76);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(62, 17);
            this.rdoDiv.TabIndex = 3;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "Division";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // Frmdoit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 338);
            this.Controls.Add(this.butDoIt);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmdoit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmdoit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button butDoIt;
        private System.Windows.Forms.RadioButton rdoDiv;
        private System.Windows.Forms.RadioButton rdoMul;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoAdd;
    }
}
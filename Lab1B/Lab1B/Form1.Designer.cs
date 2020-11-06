namespace Lab1B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalClassB = new System.Windows.Forms.TextBox();
            this.totalClassC = new System.Windows.Forms.TextBox();
            this.totalRevenue = new System.Windows.Forms.TextBox();
            this.totalClassA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtClassC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClassA);
            this.groupBox1.Controls.Add(this.txtClassB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "for each class of seats.";
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(104, 127);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(100, 22);
            this.txtClassC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(104, 71);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(100, 22);
            this.txtClassA.TabIndex = 1;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(104, 99);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(100, 22);
            this.txtClassB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalClassB);
            this.groupBox2.Controls.Add(this.totalClassC);
            this.groupBox2.Controls.Add(this.totalRevenue);
            this.groupBox2.Controls.Add(this.totalClassA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 169);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // totalClassB
            // 
            this.totalClassB.Location = new System.Drawing.Point(112, 69);
            this.totalClassB.Name = "totalClassB";
            this.totalClassB.ReadOnly = true;
            this.totalClassB.Size = new System.Drawing.Size(122, 22);
            this.totalClassB.TabIndex = 0;
            this.totalClassB.TabStop = false;
            // 
            // totalClassC
            // 
            this.totalClassC.Location = new System.Drawing.Point(112, 97);
            this.totalClassC.Name = "totalClassC";
            this.totalClassC.ReadOnly = true;
            this.totalClassC.Size = new System.Drawing.Size(122, 22);
            this.totalClassC.TabIndex = 0;
            this.totalClassC.TabStop = false;
            // 
            // totalRevenue
            // 
            this.totalRevenue.Location = new System.Drawing.Point(112, 125);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.ReadOnly = true;
            this.totalRevenue.Size = new System.Drawing.Size(122, 22);
            this.totalRevenue.TabIndex = 0;
            this.totalRevenue.TabStop = false;
            // 
            // totalClassA
            // 
            this.totalClassA.Location = new System.Drawing.Point(112, 41);
            this.totalClassA.Name = "totalClassA";
            this.totalClassA.ReadOnly = true;
            this.totalClassA.Size = new System.Drawing.Size(122, 22);
            this.totalClassA.TabIndex = 0;
            this.totalClassA.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class B:";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(161, 219);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(114, 57);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "&Calculate Revenue";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(281, 219);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(114, 57);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(487, 246);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(63, 30);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(562, 288);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Statium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalClassB;
        private System.Windows.Forms.TextBox totalClassC;
        private System.Windows.Forms.TextBox totalRevenue;
        private System.Windows.Forms.TextBox totalClassA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}


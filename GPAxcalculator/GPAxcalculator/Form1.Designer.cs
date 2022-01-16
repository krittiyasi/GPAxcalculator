namespace GPAxcalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMinname = new System.Windows.Forms.TextBox();
            this.textBoxMaxname = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxGPX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxALLDATA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA INPUT";
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Location = new System.Drawing.Point(117, 23);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(115, 23);
            this.textBoxName_input.TabIndex = 0;
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Location = new System.Drawing.Point(238, 23);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPA_input.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxMinname);
            this.groupBox1.Controls.Add(this.textBoxMaxname);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.textBoxGPX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 85);
            this.button2.TabIndex = 8;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMinname
            // 
            this.textBoxMinname.Location = new System.Drawing.Point(88, 81);
            this.textBoxMinname.Name = "textBoxMinname";
            this.textBoxMinname.ReadOnly = true;
            this.textBoxMinname.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinname.TabIndex = 7;
            // 
            // textBoxMaxname
            // 
            this.textBoxMaxname.Location = new System.Drawing.Point(88, 51);
            this.textBoxMaxname.Name = "textBoxMaxname";
            this.textBoxMaxname.ReadOnly = true;
            this.textBoxMaxname.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxname.TabIndex = 6;
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(205, 81);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.ReadOnly = true;
            this.textBoxMinGPA.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinGPA.TabIndex = 5;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(205, 51);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.ReadOnly = true;
            this.textBoxMaxGPA.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxGPA.TabIndex = 4;
            // 
            // textBoxGPX
            // 
            this.textBoxGPX.Location = new System.Drawing.Point(205, 18);
            this.textBoxGPX.Name = "textBoxGPX";
            this.textBoxGPX.ReadOnly = true;
            this.textBoxGPX.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPX.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "MIN GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "MAX GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "GPAX";
            // 
            // textBoxALLDATA
            // 
            this.textBoxALLDATA.Location = new System.Drawing.Point(43, 222);
            this.textBoxALLDATA.Multiline = true;
            this.textBoxALLDATA.Name = "textBoxALLDATA";
            this.textBoxALLDATA.ReadOnly = true;
            this.textBoxALLDATA.Size = new System.Drawing.Size(411, 104);
            this.textBoxALLDATA.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 350);
            this.Controls.Add(this.textBoxALLDATA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxName_input;
        private TextBox textBoxGPA_input;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBoxMinname;
        private TextBox textBoxMaxname;
        private TextBox textBoxMinGPA;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxGPX;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxALLDATA;
    }
}
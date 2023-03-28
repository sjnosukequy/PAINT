namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeDWLabel = new System.Windows.Forms.Label();
            this.SizeUPLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.SizeDWLabel);
            this.panel1.Controls.Add(this.SizeUPLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 672);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt2_Recv);
            // 
            // SizeDWLabel
            // 
            this.SizeDWLabel.AutoSize = true;
            this.SizeDWLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeDWLabel.Location = new System.Drawing.Point(18, 478);
            this.SizeDWLabel.Name = "SizeDWLabel";
            this.SizeDWLabel.Size = new System.Drawing.Size(76, 23);
            this.SizeDWLabel.TabIndex = 19;
            this.SizeDWLabel.Text = "[ :  - Size";
            this.SizeDWLabel.Visible = false;
            // 
            // SizeUPLabel
            // 
            this.SizeUPLabel.AutoSize = true;
            this.SizeUPLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeUPLabel.Location = new System.Drawing.Point(131, 478);
            this.SizeUPLabel.Name = "SizeUPLabel";
            this.SizeUPLabel.Size = new System.Drawing.Size(71, 23);
            this.SizeUPLabel.TabIndex = 18;
            this.SizeUPLabel.Text = "] : +Size";
            this.SizeUPLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(45, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Mode: OFF";
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label2_key);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.comboBox1.Location = new System.Drawing.Point(48, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.TabStop = false;
            this.comboBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CBchoice);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(48, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 54);
            this.button6.TabIndex = 15;
            this.button6.TabStop = false;
            this.button6.Text = "Color";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 27);
            this.textBox2.TabIndex = 13;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Width";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt2_Cls);
            this.textBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt2Wid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Brush settings";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(131, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 56);
            this.button8.TabIndex = 4;
            this.button8.TabStop = false;
            this.button8.Text = "Filled polygon";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(131, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 29);
            this.button9.TabIndex = 4;
            this.button9.TabStop = false;
            this.button9.Text = "Polygon";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(131, 89);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 51);
            this.button10.TabIndex = 4;
            this.button10.TabStop = false;
            this.button10.Text = "Arc";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(131, 54);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 29);
            this.button11.TabIndex = 4;
            this.button11.TabStop = false;
            this.button11.Text = "Filled circle";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(131, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 29);
            this.button12.TabIndex = 4;
            this.button12.TabStop = false;
            this.button12.Text = "Circle";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 56);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "Filled rectangle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "Rectangle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 51);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "Filled ellipse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "Ellipse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 665);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MUDW);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MUMOV);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MUUP);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.SZChange);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox textBox2;
        private ColorDialog colorDialog1;
        private Button button6;
        private ComboBox comboBox1;
        private Label label2;
        private Label SizeDWLabel;
        private Label SizeUPLabel;
    }
}
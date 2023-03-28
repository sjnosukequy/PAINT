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
            this.label3 = new System.Windows.Forms.Label();
            this.SizeDWLabel = new System.Windows.Forms.Label();
            this.SizeUPLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PolygonF_BTT = new System.Windows.Forms.Button();
            this.Polygon_BTT = new System.Windows.Forms.Button();
            this.Arc_BTT = new System.Windows.Forms.Button();
            this.CircleF_BTT = new System.Windows.Forms.Button();
            this.CirceL_BTT = new System.Windows.Forms.Button();
            this.RectangleF_BTT = new System.Windows.Forms.Button();
            this.Rectangle_BTT = new System.Windows.Forms.Button();
            this.EllipseF_BTT = new System.Windows.Forms.Button();
            this.EllipseL_BTT = new System.Windows.Forms.Button();
            this.Line_BTT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cordinate = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SizeDWLabel);
            this.panel1.Controls.Add(this.SizeUPLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PolygonF_BTT);
            this.panel1.Controls.Add(this.Polygon_BTT);
            this.panel1.Controls.Add(this.Arc_BTT);
            this.panel1.Controls.Add(this.CircleF_BTT);
            this.panel1.Controls.Add(this.CirceL_BTT);
            this.panel1.Controls.Add(this.RectangleF_BTT);
            this.panel1.Controls.Add(this.Rectangle_BTT);
            this.panel1.Controls.Add(this.EllipseF_BTT);
            this.panel1.Controls.Add(this.EllipseL_BTT);
            this.panel1.Controls.Add(this.Line_BTT);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 714);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt2_Recv);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 161);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ctrl: to select objects\r\n[ : to increase size\r\n] : to decrease size\r\nG : to group" +
    " objects\r\nU : to ungroup objects\r\nEsc : to cancel operations\r\nDel: to Delete obj" +
    "ects";
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
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.CBchoice);
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
            // PolygonF_BTT
            // 
            this.PolygonF_BTT.Location = new System.Drawing.Point(131, 181);
            this.PolygonF_BTT.Name = "PolygonF_BTT";
            this.PolygonF_BTT.Size = new System.Drawing.Size(94, 56);
            this.PolygonF_BTT.TabIndex = 4;
            this.PolygonF_BTT.TabStop = false;
            this.PolygonF_BTT.Text = "Filled polygon";
            this.PolygonF_BTT.UseVisualStyleBackColor = true;
            this.PolygonF_BTT.Click += new System.EventHandler(this.PolyF_BTT_Click);
            // 
            // Polygon_BTT
            // 
            this.Polygon_BTT.Location = new System.Drawing.Point(131, 146);
            this.Polygon_BTT.Name = "Polygon_BTT";
            this.Polygon_BTT.Size = new System.Drawing.Size(94, 29);
            this.Polygon_BTT.TabIndex = 4;
            this.Polygon_BTT.TabStop = false;
            this.Polygon_BTT.Text = "Polygon";
            this.Polygon_BTT.UseVisualStyleBackColor = true;
            this.Polygon_BTT.Click += new System.EventHandler(this.Poly_BTT_Click);
            // 
            // Arc_BTT
            // 
            this.Arc_BTT.Location = new System.Drawing.Point(131, 89);
            this.Arc_BTT.Name = "Arc_BTT";
            this.Arc_BTT.Size = new System.Drawing.Size(94, 51);
            this.Arc_BTT.TabIndex = 4;
            this.Arc_BTT.TabStop = false;
            this.Arc_BTT.Text = "Arc";
            this.Arc_BTT.UseVisualStyleBackColor = true;
            this.Arc_BTT.Click += new System.EventHandler(this.Arc_BTT_Click);
            // 
            // CircleF_BTT
            // 
            this.CircleF_BTT.Location = new System.Drawing.Point(131, 54);
            this.CircleF_BTT.Name = "CircleF_BTT";
            this.CircleF_BTT.Size = new System.Drawing.Size(94, 29);
            this.CircleF_BTT.TabIndex = 4;
            this.CircleF_BTT.TabStop = false;
            this.CircleF_BTT.Text = "Filled circle";
            this.CircleF_BTT.UseVisualStyleBackColor = true;
            this.CircleF_BTT.Click += new System.EventHandler(this.CircleF_BTT_Click);
            // 
            // CirceL_BTT
            // 
            this.CirceL_BTT.Location = new System.Drawing.Point(131, 19);
            this.CirceL_BTT.Name = "CirceL_BTT";
            this.CirceL_BTT.Size = new System.Drawing.Size(94, 29);
            this.CirceL_BTT.TabIndex = 4;
            this.CirceL_BTT.TabStop = false;
            this.CirceL_BTT.Text = "Circle";
            this.CirceL_BTT.UseVisualStyleBackColor = true;
            this.CirceL_BTT.Click += new System.EventHandler(this.Circle_BTT_Click);
            // 
            // RectangleF_BTT
            // 
            this.RectangleF_BTT.Location = new System.Drawing.Point(18, 181);
            this.RectangleF_BTT.Name = "RectangleF_BTT";
            this.RectangleF_BTT.Size = new System.Drawing.Size(94, 56);
            this.RectangleF_BTT.TabIndex = 4;
            this.RectangleF_BTT.TabStop = false;
            this.RectangleF_BTT.Text = "Filled rectangle";
            this.RectangleF_BTT.UseVisualStyleBackColor = true;
            this.RectangleF_BTT.Click += new System.EventHandler(this.RecF_BTT_Click);
            // 
            // Rectangle_BTT
            // 
            this.Rectangle_BTT.Location = new System.Drawing.Point(18, 146);
            this.Rectangle_BTT.Name = "Rectangle_BTT";
            this.Rectangle_BTT.Size = new System.Drawing.Size(94, 29);
            this.Rectangle_BTT.TabIndex = 4;
            this.Rectangle_BTT.TabStop = false;
            this.Rectangle_BTT.Text = "Rectangle";
            this.Rectangle_BTT.UseVisualStyleBackColor = true;
            this.Rectangle_BTT.Click += new System.EventHandler(this.Rec_BTT_Click);
            // 
            // EllipseF_BTT
            // 
            this.EllipseF_BTT.Location = new System.Drawing.Point(18, 89);
            this.EllipseF_BTT.Name = "EllipseF_BTT";
            this.EllipseF_BTT.Size = new System.Drawing.Size(94, 51);
            this.EllipseF_BTT.TabIndex = 4;
            this.EllipseF_BTT.TabStop = false;
            this.EllipseF_BTT.Text = "Filled ellipse";
            this.EllipseF_BTT.UseVisualStyleBackColor = true;
            this.EllipseF_BTT.Click += new System.EventHandler(this.EllipseF_BTT_Click);
            // 
            // EllipseL_BTT
            // 
            this.EllipseL_BTT.Location = new System.Drawing.Point(18, 54);
            this.EllipseL_BTT.Name = "EllipseL_BTT";
            this.EllipseL_BTT.Size = new System.Drawing.Size(94, 29);
            this.EllipseL_BTT.TabIndex = 4;
            this.EllipseL_BTT.TabStop = false;
            this.EllipseL_BTT.Text = "Ellipse";
            this.EllipseL_BTT.UseVisualStyleBackColor = true;
            this.EllipseL_BTT.Click += new System.EventHandler(this.Ellipse_BTT_Click);
            // 
            // Line_BTT
            // 
            this.Line_BTT.Location = new System.Drawing.Point(18, 19);
            this.Line_BTT.Name = "Line_BTT";
            this.Line_BTT.Size = new System.Drawing.Size(94, 29);
            this.Line_BTT.TabIndex = 4;
            this.Line_BTT.TabStop = false;
            this.Line_BTT.Text = "Line";
            this.Line_BTT.UseVisualStyleBackColor = true;
            this.Line_BTT.Click += new System.EventHandler(this.Line_BTT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.Cordinate);
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 707);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MUDW);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MUMOV);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MUUP);
            // 
            // Cordinate
            // 
            this.Cordinate.AutoSize = true;
            this.Cordinate.Location = new System.Drawing.Point(974, 684);
            this.Cordinate.Name = "Cordinate";
            this.Cordinate.Size = new System.Drawing.Size(50, 20);
            this.Cordinate.TabIndex = 0;
            this.Cordinate.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.SZChange);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button PolygonF_BTT;
        private Button Polygon_BTT;
        private Button Arc_BTT;
        private Button CircleF_BTT;
        private Button CirceL_BTT;
        private Button RectangleF_BTT;
        private Button Rectangle_BTT;
        private Button EllipseF_BTT;
        private Button EllipseL_BTT;
        private Button Line_BTT;
        private Panel panel2;
        private TextBox textBox2;
        private ColorDialog colorDialog1;
        private Button button6;
        private ComboBox comboBox1;
        private Label label2;
        private Label SizeDWLabel;
        private Label SizeUPLabel;
        private Label label3;
        private Label Cordinate;
    }
}
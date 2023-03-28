using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        //GLOBAL VARIBLE
        Color Mycolor;
        int width;
        //start flags
        bool start = false;
        bool start2 = false;

        // selecting flags
        bool Iselect = false;
        List<int> SEindex = new List<int>();
        bool Selected = false;
        Point Bef = new Point();
        Point Aft = new Point();

        int style = 0;

        //Flag ploy
        bool IsPoly = false;

        //shapes
        List<Line> Shapes = new List<Line>();

        //WINDOW HEIGHT/WIDTH
        float firstWidth;
        float firstHeight;


        //FORM

        public Form1()
        {
            InitializeComponent();
            this.panel2.DBUFFER();
            Mycolor = Color.Black;
            width = 10;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

        }

        //Textbox Click Functions
        private void txt2_Cls(object sender, MouseEventArgs e)
        {
            if (textBox2.Text.Contains("Width"))
                this.textBox2.Clear();
        }
        private void txt2_Recv(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "")
                this.textBox2.Text = "Width";
            //check
            if(textBox2.Text != "Width")
            {
                bool isNumeric = int.TryParse(this.textBox2.Text, out int n);
                if (n <= 0)
                    isNumeric = false;
                if (isNumeric)
                    width = Convert.ToInt32(this.textBox2.Text);
                else
                    MessageBox.Show("Hay nhap mot so nguyen lon hon 0");
            }
            textBox2.Focus();
            textBox2.Select(textBox2.Text.Length, 0);
        }

        //Brush button Function
        private void Color_click(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Mycolor = colorDialog1.Color;
                if(start == true)
                {
                    Shapes[Shapes.Count() - 1].Color = Mycolor;
                }
                if (Selected == true)
                {
                    foreach (int i in SEindex)
                        Shapes[i].Color = Mycolor;
                    panel2.Refresh();
                }
            }
            this.button6.Text = Convert.ToString(Mycolor);
        }
        private void txt2Wid(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("widthtxt");
            if (e.KeyCode == Keys.Enter)
            {
                bool isNumeric = int.TryParse(this.textBox2.Text, out int n);
                if (n <= 0)
                    isNumeric = false;
                if (isNumeric)
                {
                    width = Convert.ToInt32(this.textBox2.Text);
                    if (Selected == true)
                    {
                        foreach (int i in SEindex)
                            Shapes[i].Width = width;
                        panel2.Refresh();
                    }
                    this.label2.Focus();
                }
                else
                    MessageBox.Show("Hay nhap mot so nguyen lon hon 0");
            }
        }
        private void CBchoice(object sender,MouseEventArgs e)
        {
            if (start == false)
            {
                if (Convert.ToString(this.comboBox1.SelectedItem) == "Solid")
                    style = 0;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "Dash")
                    style = 1;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "Dot")
                    style = 2;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "DashDot")
                    style = 3;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "DashDotDot")
                    style = 4;
            }
            else
            {
                if (Convert.ToString(this.comboBox1.SelectedItem) == "Solid")
                    style = 0;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "Dash")
                    style = 1;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "Dot")
                    style = 2;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "DashDot")
                    style = 3;
                else if (Convert.ToString(this.comboBox1.SelectedItem) == "DashDotDot")
                    style = 4;
                switch(style)
                {
                    case 0:
                        Shapes[Shapes.Count() - 1].Style = 0 ; break;
                    case 1:
                        Shapes[Shapes.Count() - 1].Style = 1; break;
                    case 2:
                        Shapes[Shapes.Count() - 1].Style = 2; break;
                    case 3:
                        Shapes[Shapes.Count() - 1].Style = 3; break;
                    case 4:
                        Shapes[Shapes.Count() - 1].Style = 4; break;
                }
            }
        }

        //Panel
        private void MUDW(object sender, MouseEventArgs e)
        {
            Console.WriteLine("click");
            if (Iselect == true)
            {
                int len = Shapes.Count();
                Console.WriteLine("LEN: " + len);
                if (len >0)
                    for (int i = len - 1; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                        if (Shapes[i].CContains(panel2, e) == true)
                        {
                            SEindex.Add(i);
                            Console.WriteLine("IN");
                            break;
                        }

                    }
                //removing duplicants
                if (SEindex.Count > 1)
                    for (int i = 0; i < SEindex.Count();i++)
                    {
                        Line temp = Shapes[SEindex[i]];
                        for (int k = i + 1; k < SEindex.Count(); k++)
                            if (Shapes[SEindex[k]] == temp)
                            {
                                SEindex.RemoveAt(k);
                                break;
                            }
                    }

                Console.Write("SE: ");
                for (int i = 0; i < SEindex.Count(); i++)
                    Console.Write(SEindex[i] + ", ");
                Console.Write("\n");
                if (SEindex.Count() > 0)
                {
                    this.label2.ForeColor = System.Drawing.Color.DarkGreen;
                    this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Bold);
                    string temp = Convert.ToString(SEindex.Count());
                    this.label2.Text = "Select Mode: ON\n     Selected: " + temp;
                    Selected = true;
                    Label_SEE(1);
                }
                else
                {
                    this.label2.ForeColor = System.Drawing.Color.OrangeRed;
                    this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                    this.label2.Text = "Select Mode: OFF";
                    Label_SEE(0);
                }
                Iselect = false;
            }
            else if (Selected == true)
            {
                Console.WriteLine("pivot");
                start2 = true;
                Bef = new Point(e.Location.X, e.Location.Y);
                foreach (int i in SEindex)
                {
                    Shapes[i].SetPivot();
                }
                this.SizeDWLabel.ForeColor = System.Drawing.Color.Black;
                this.SizeUPLabel.ForeColor = System.Drawing.Color.Black;
                this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
            }
            else if (IsPoly == true)
            {
                if (start == true)
                {
                    Point b = new Point(e.X, e.Y);
                    Shapes[Shapes.Count() - 1].P1 = b;
                    Shapes[Shapes.Count() - 1].Points.Add(b);
                }
                Shapes[Shapes.Count() - 1].Points.Add(Shapes[Shapes.Count() - 1].P1);
                start2 = true;
                Console.WriteLine("clickPoly");
            }
            else
            {
                if (start == true)
                {
                    Point b = new Point(e.X, e.Y);
                    Shapes[Shapes.Count() - 1].P1 = b;
                    start2 = true;
                }
            }
        }
        private void MUMOV(object sender, MouseEventArgs e)
        {
            if(Selected == true)
            {
                if (start2 == true)
                {
                    Aft = new Point(e.Location.X, e.Location.Y);
                    int x = Aft.X - Bef.X;
                    int y = Aft.Y - Bef.Y;

                    // DEBUG
                    //Graphics gp = this.panel2.CreateGraphics();
                    //Pen tmp = new Pen(Color.Red, 5);
                    //Point p3 = new Point(Bef.X + x, Bef.Y + y);
                    //gp.DrawLine(tmp, Bef, p3);
                    // DEBUG

                    foreach (int i in SEindex)
                    {

                        if (Shapes[i].Name.Equals("Poly"))
                        {
                            Console.WriteLine("poly");
                            int len = Shapes[i].Points.Count();
                            for (int j = 0; j < len; j++)
                            {
                                PointF p = new PointF(Shapes[i].PointM[j].X + x, Shapes[i].PointM[j].Y + y);
                                Shapes[i].Points[j] = p;
                            }
                            Shapes[i].P1 = Shapes[i].Points[0];
                            this.panel2.Refresh();
                        }
                        else if(Shapes[i].Name.Equals("Combine"))
                        {
                            Console.WriteLine("Combine");
                            int len = Shapes[i].gshapes.Count();
                            for (int k = 0; k < len; k++)
                                if (Shapes[i].gshapes[k].Name.Equals("Poly"))
                                {
                                    int len2 = Shapes[i].gshapes[k].Points.Count();
                                    for (int j = 0; j < len2; j++)
                                    {
                                        PointF p = new PointF(Shapes[i].gshapes[k].PointM[j].X + x, Shapes[i].gshapes[k].PointM[j].Y + y);
                                        Shapes[i].gshapes[k].Points[j] = p;
                                    }
                                    Shapes[i].gshapes[k].P1 = Shapes[i].gshapes[k].Points[0];
                                }
                                else
                                {
                                    PointF p1 = new PointF(Shapes[i].gshapes[k].PointM[0].X + x, Shapes[i].gshapes[k].PointM[0].Y + y);
                                    PointF p2 = new PointF(Shapes[i].gshapes[k].PointM[1].X + x, Shapes[i].gshapes[k].PointM[1].Y + y);
                                    Shapes[i].gshapes[k].P1 = p1;
                                    Shapes[i].gshapes[k].P2 = p2;
                                }
                            this.panel2.Refresh();
                        }
                        else
                        {
                            Console.WriteLine("No poly");
                            PointF p1 = new PointF(Shapes[i].PointM[0].X + x, Shapes[i].PointM[0].Y + y);
                            PointF p2 = new PointF(Shapes[i].PointM[1].X + x, Shapes[i].PointM[1].Y + y);
                            Shapes[i].P1 = p1;
                            Shapes[i].P2 = p2;
                            this.panel2.Refresh();
                        }
                    }
                }
            }
            else if(IsPoly == true)
            {
                if (start2 == true)
                {
                    PointF b = new PointF(e.X, e.Y);
                    Shapes[Shapes.Count() - 1].P2 = b;
                    Shapes[Shapes.Count() - 1].Points[Shapes[Shapes.Count() - 1].Points.Count() - 1] = b;
                    this.panel2.Refresh();
                }
            }
            else
            {
                if (start2 == true)
                {
                    PointF b = new PointF(e.X, e.Y);
                    Shapes[Shapes.Count() - 1].P2 = b;
                    this.panel2.Refresh();
                }
            }
        }
        private void MUUP(object sender, MouseEventArgs e)
        { 
            if(start2 == true)
            {
                start = false;
                start2 = false;
                Iselect = false;
                Selected = false;
                SEindex.Clear();
                this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                this.label2.ForeColor = System.Drawing.Color.OrangeRed;
                this.label2.Text = "Select Mode: OFF";
                Label_SEE(0);
            }
            //Selected = false;
            this.label2.Focus();
        }
        private void label2_key(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Console.WriteLine("Exit");
                        if (IsPoly == true)
                        {
                            start = false;
                            start2 = false;
                            IsPoly = false;
                        }
                        this.panel2.Refresh();
                        SEindex.Clear();
                        Iselect = false;
                        Selected = false;
                        this.SizeDWLabel.ForeColor = System.Drawing.Color.Black;
                        this.SizeUPLabel.ForeColor = System.Drawing.Color.Black;
                        this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.label2.ForeColor = System.Drawing.Color.OrangeRed;
                        this.label2.Text = "Select Mode: OFF";
                        Label_SEE(0);
                        break;
                    }
                case Keys.ControlKey:
                    {
                        Console.WriteLine("Select");
                        Iselect = true;
                        Selected = false;
                        this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Bold);
                        this.label2.Text = "Select Mode: ON";
                        this.label2.ForeColor = System.Drawing.Color.DarkGreen;
                        if (IsPoly == true)
                        {
                            start = false;
                            start2 = false;
                            IsPoly = false;
                        }
                        break;
                    }
                case Keys.OemOpenBrackets:
                    {
                        if(Selected == true)
                        {
                            this.SizeDWLabel.ForeColor = System.Drawing.Color.DarkGreen;
                            this.SizeUPLabel.ForeColor = System.Drawing.Color.Black;
                            this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                            this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Bold);
                            Console.WriteLine("Size decrease");
                            foreach (int i in SEindex)
                            {
                                Shapes[i].SizeDW();
                            }
                            this.panel2.Refresh();
                        }
                        break;
                    }
                case Keys.OemCloseBrackets:
                    {
                        if (Selected == true)
                        {
                            this.SizeUPLabel.ForeColor = System.Drawing.Color.DarkGreen;
                            this.SizeDWLabel.ForeColor = System.Drawing.Color.Black;
                            this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Bold);
                            this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                            Console.WriteLine("Size increase");
                            foreach (int i in SEindex)
                            {
                                Shapes[i].SizeUP();
                            }
                            this.panel2.Refresh();
                        }
                        break;
                    }
                case Keys.Back:
                    {
                        if(Selected == true)
                        {
                            Console.WriteLine("Deletion");
                            SEindex.Sort();
                            SEindex.Reverse();
                            foreach (int i in SEindex)
                            {
                                Shapes.RemoveAt(i);
                            }
                        }
                        SEindex.Clear();
                        Iselect = false;
                        Selected = false;
                        this.SizeDWLabel.ForeColor = System.Drawing.Color.Black;
                        this.SizeUPLabel.ForeColor = System.Drawing.Color.Black;
                        this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.label2.ForeColor = System.Drawing.Color.OrangeRed;
                        this.label2.Text = "Select Mode: OFF";
                        Label_SEE(0);
                        this.panel2.Refresh();
                        break;
                    }
                case Keys.G:
                    {
                        if(Selected == true)
                        {
                            Console.WriteLine("Group");
                            SEindex.Sort();
                            SEindex.Reverse();
                            bool flag = true;
                            foreach (int i in SEindex)
                                if (Shapes[i].Name.Equals("Combine"))
                                    flag = false;
                            if (flag == true)
                            {
                                Combine a = new Combine(Mycolor, width, style, Shapes, SEindex);
                                Shapes.Add(a);
                                foreach (int i in SEindex)
                                {
                                    Shapes.RemoveAt(i);
                                }
                            }
                            else
                                MessageBox.Show("Ungroup First");

                        }
                        SEindex.Clear();
                        Iselect = false;
                        Selected = false;
                        this.SizeDWLabel.ForeColor = System.Drawing.Color.Black;
                        this.SizeUPLabel.ForeColor = System.Drawing.Color.Black;
                        this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.label2.ForeColor = System.Drawing.Color.OrangeRed;
                        this.label2.Text = "Select Mode: OFF";
                        Label_SEE(0);
                        this.panel2.Refresh();
                        break;
                    }
                case Keys.U:
                    {
                        if (Selected == true)
                        {
                            Console.WriteLine("Group");
                            bool flag = true;
                            if (SEindex.Count() > 1)
                                flag = false;
                            if (!Shapes[SEindex[0]].Name.Equals("Combine"))
                                flag = false;
                            if (flag == true)
                            {
                                int len = Shapes[SEindex[0]].gshapes.Count();
                                for (int i = 0; i < len; i++)
                                    Shapes.Add(Shapes[SEindex[0]].gshapes[i]);
                                Shapes.RemoveAt(SEindex[0]);
                            }
                            else
                                MessageBox.Show("Cannot ungroup Ungrouped objetcs");

                        }
                        SEindex.Clear();
                        Iselect = false;
                        Selected = false;
                        this.SizeDWLabel.ForeColor = System.Drawing.Color.Black;
                        this.SizeUPLabel.ForeColor = System.Drawing.Color.Black;
                        this.label2.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeUPLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.SizeDWLabel.Font = new System.Drawing.Font(this.SizeUPLabel.Font, System.Drawing.FontStyle.Regular);
                        this.label2.ForeColor = System.Drawing.Color.OrangeRed;
                        this.label2.Text = "Select Mode: OFF";
                        Label_SEE(0);
                        this.panel2.Refresh();
                        break;
                    }
            }
        }
        private void paint(object sender, PaintEventArgs e)
        {
            int ls = Shapes.Count();
            for (int i = 0; i < ls; i++)
                Shapes[i].Paint(e);
        }

        //Button click
        private void button1_Click(object sender, EventArgs e)
        {
            Line a = new Line(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ellipse a = new Ellipse(Mycolor,width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FEllipse a = new FEllipse(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Rec a = new Rec(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FRec a = new FRec(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Circle a = new Circle(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            FCircle a = new FCircle(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Arc a = new Arc(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            IsPoly = false;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            IsPoly = true;
            Poly a = new Poly(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            IsPoly = true;
            FPoly a = new FPoly(Mycolor, width, style);
            Shapes.Add(a);
            start = true;
            Iselect = false;
            Selected = false;
            SEindex.Clear();
            this.label2.Focus();
        }

        //Label Control
        private void Label_SEE(int i)
        {
            if (i == 1)
            {
                this.SizeUPLabel.Visible = true;
                this.SizeDWLabel.Visible = true;
            }
            else if (i == 0)
            {
                this.SizeUPLabel.Visible = false;
                this.SizeDWLabel.Visible = false;
            }
        }

        //Size Change
        private void SZChange(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                float size1 = this.Size.Width / firstWidth;
                float size2 = this.Size.Height / firstHeight;

                SizeF scale = new SizeF(size1, size2);
                firstWidth = this.Size.Width;
                firstHeight = this.Size.Height;

                foreach (Control control in this.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));
                    control.Scale(scale);
                }
                foreach (Control control in this.panel1.Controls)
                    if (control.GetType().FullName.Equals("System.Windows.Forms.Label"))
                    {
                        control.Font = new Font(control.Font.FontFamily, control.Font.Size * size1);
                        //control.Scale(scale);
                    }
            }
        }

    }
}
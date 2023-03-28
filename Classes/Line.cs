using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/* Dash Styles
  Solid = 0,
  Dash = 1,
  Dot = 2,
  DashDot = 3,
  DashDotDot = 4,
*/

public class Line
{
    private List<Line> Gshapes;
    private PointF p1;
    private PointF p2;
    private int width;
    private Color color;
    private Pen pen;
    private SolidBrush brush;
    private int style;
    private List<PointF> points;
    private List<PointF> pointM;
    private string name;
    private float dx;
    //
    public Line(Color color, int width, int style)
    {
        pen = new Pen(color, width);
        brush = new SolidBrush(color);
        this.color = color;
        this.width = width;
        this.Style = style;
        PointM = new List<PointF>();
        Points = new List<PointF>();
        this.Dx = 0;
        Name = "Line";
    }
    public float Dx
    {
        get { return dx; }
        set { dx = value; }
    }
    public List<Line> gshapes
    {
        get { return Gshapes; }
        set { Gshapes = value; }
    }
    public PointF P1
    {
        get { return p1; }
        set { p1 = value; }
    }
    public PointF P2
    {
        get { return p2; }
        set { p2 = value; }
    }
    public int Width
    {
        get { return width; }
        set { width = value; }
    }
    public Color Color
    {
        get { return color; }
        set { color = value; }
    }
    public Pen Pen
    {

        get { return pen; }
        set { pen = value; }
    }
    public SolidBrush Brush
    {
        get { return brush; }
        set { brush = value; }
    }
    public int Style
    {
        get { return style; }
        set { style = value; }
    }
    public List<PointF> Points
    {
        get { return points; }
        set { points = value; }
    }
    public List<PointF> PointM
    {
        get { return pointM; }
        set { pointM = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    //Functions
    public virtual void Paint(PaintEventArgs e)
    {
        pen = new Pen(color, width);
        brush = new SolidBrush(color);
        switch (Style)
        {
            case 0:
                {
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                }
            case 1:
                {
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                }
            case 2:
                {
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                }
            case 3:
                {
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                }
            case 4:
                {
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
                }
        }
        e.Graphics.DrawLine(pen, P1, P2);
    }
    public virtual bool CContains(Panel a,MouseEventArgs e)
    {
        PointF Mouse = new PointF(e.Location.X, e.Location.Y);
        float x = MathF.Min(P1.X, P2.X);
        float y = MathF.Min(P1.Y, P2.Y);
        float height = MathF.Abs(P2.Y - P1.Y);
        float width = MathF.Abs(P2.X - P1.X);
        if (width == 0)
        {
            width = this.Width;
            x -= 5;
        }
        else if (height == 0)
        {
            height = this.Width;
            y -= 5;
        }
        RectangleF box = new RectangleF(x, y, width, height);
        if(box.Contains(Mouse))
        {
            if(this.Color != Color.Red)
            {
                Graphics gp = a.CreateGraphics();
                Pen tmp = new Pen(Color.Red, 10);
                gp.DrawRectangle(tmp, Rectangle.Round(box));
            }
            else
            {
                Graphics gp = a.CreateGraphics();
                Pen tmp = new Pen(Color.Black, 10);
                gp.DrawRectangle(tmp, Rectangle.Round(box));
            }
        }
        return box.Contains(Mouse);
    }
    public virtual RectangleF GetContains()
    {
        float x = MathF.Min(P1.X, P2.X);
        float y = MathF.Min(P1.Y, P2.Y);
        float height = MathF.Abs(P2.Y - P1.Y);
        float width = MathF.Abs(P2.X - P1.X);
        if (width == 0)
        {
            width = this.Width;
            x -= 5;
        }
        else if (height == 0)
        {
            height = this.Width;
            y -= 5;
        }
        RectangleF box = new RectangleF(x, y, width, height);
        return box;
    }
    public virtual void SetPivot()         //Set Pivot,  At i = 0: we save P1,  At i = 1: we save P2
    {
        if (PointM.Count() == 0)
        {
            PointM.Add(P1);
            PointM.Add(P2);
        }
        else
        {
            PointM[0] = P1;
            PointM[1] = P2;
        }
    }
    public virtual void SizeUP()
    {
        if (this.Dx == 0)
        {
            float x = -this.P1.Y + this.P2.Y;
            float y = this.P1.X - this.P2.X;
            Console.WriteLine(x);
            Console.WriteLine(y);
            this.Dx = (float)x / y;
        }
        //PointF p1 = new PointF(Centr.X - (width / 2) + 3, Centr.Y - (height / 2) - (3 * m));
        if (this.P2.X > this.P1.X)
        {
            PointF p2 = new PointF(this.P2.X + 3, this.P2.Y - (3 * this.Dx));
            Console.WriteLine("P1: " + this.P1);
            Console.WriteLine("P2: " + this.P2);
            //Console.WriteLine("pa1: " + p1);
            Console.WriteLine("pa2: " + p2);
            Console.WriteLine(Dx);

            //
            float n = (-this.P1.Y + p2.Y) / (this.P1.X - p2.X);
            Console.WriteLine(n);

            this.P2 = p2;
        }
        else
        {
            PointF p1 = new PointF(this.P1.X + 3, this.P1.Y - (3 * this.Dx));
            Console.WriteLine("P1: " + this.P1);
            Console.WriteLine("P2: " + this.P2);
            //Console.WriteLine("pa1: " + p1);
            Console.WriteLine("pa2: " + p1);
            Console.WriteLine(Dx);

            //
            float n = (-this.P1.Y + p1.Y) / (this.P1.X - p1.X);
            Console.WriteLine(n);

            this.P1 = p1;
        }

        //DEBUGGING
       
        //this.width += 1;
    }
    public virtual void SizeDW()
    {

        if (this.Dx == 0)
        {
            float x = -this.P1.Y + this.P2.Y;
            float y = this.P1.X - this.P2.X;
            Console.WriteLine(x);
            Console.WriteLine(y);
            this.Dx = (float)x / y;
        }
        //PointF p1 = new PointF(Centr.X - (width / 2) + 3, Centr.Y - (height / 2) - (3 * m));
        if(this.P2.X > this.P1.X)
        {
            PointF p2 = new PointF(this.P2.X - 3, this.P2.Y + (3 * this.Dx));

            //DEBUGGING
            Console.WriteLine("P1: " + this.P1);
            Console.WriteLine("P2: " + this.P2);
            //Console.WriteLine("pa1: " + p1);
            Console.WriteLine("pa2: " + p2);
            Console.WriteLine(Dx);

            //
            float n = (-this.P1.Y + p2.Y) / (this.P1.X - p2.X);
            Console.WriteLine(n);

            float check = p2.X - this.P1.X;
            int check2 = this.Width - 1;
            if (check > 5 && check2 >= 1)
            {
                this.P2 = p2;
                //this.width -= 1;
            }
        }
        else
        {
            PointF p1 = new PointF(this.P1.X - 3, this.P1.Y + (3 * this.Dx));

            //DEBUGGING
            Console.WriteLine("P1: " + this.P1);
            Console.WriteLine("P2: " + this.P2);
            //Console.WriteLine("pa1: " + p1);
            Console.WriteLine("pa2: " + p1);
            Console.WriteLine(Dx);

            //
            float n = (-this.P1.Y + p1.Y) / (this.P1.X - p1.X);
            Console.WriteLine(n);

            float check = p1.X - this.P2.X;
            int check2 = this.Width - 1;
            if (check > 5 && check2 >= 1)
            {
                this.P1 = p1;
                //this.width -= 1;
            }
        }
       
    }
}

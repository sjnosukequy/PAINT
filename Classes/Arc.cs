using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

public class Arc : Line
{
    public Arc(Color color, int width, int style) : base(color, width, style)
    {
        Name = "Arc";
    }
    public override void Paint(PaintEventArgs e)
    {
        Pen = new Pen(Color, Width);
        Brush = new SolidBrush(Color);
        switch (this.Style)
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
        // Draw the arc
        int space = Width * 10;
        PointF Centr = new PointF(P1.X - space, P1.Y - space/2);
        RectangleF rect = new RectangleF(Centr.X, Centr.Y ,space , space);
        Centr = new PointF(P1.X - space / 2, P1.Y);
        double angle = Math.Atan2(P2.Y - Centr.Y, P2.X - Centr.X) * 180/Math.PI;
        float ang = (float)angle;
        //Console.WriteLine(angle);
        e.Graphics.DrawArc(Pen, rect, 0, ang);
    }
    public override bool CContains(Panel a, MouseEventArgs e)
    {
        PointF Mouse = new PointF(e.Location.X, e.Location.Y);
        int space = Width * 10;
        float x = P1.X - space;
        float y = P1.Y - space/2;
        int height = space;
        int width = space;
        RectangleF box = new RectangleF(x, y, width, height);
        if (box.Contains(Mouse))
        {
            if (this.Color != Color.Red)
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
    public override RectangleF GetContains()
    {
        int space = Width * 10;
        float x = P1.X - space;
        float y = P1.Y - space / 2;
        int height = space;
        int width = space;
        RectangleF box = new RectangleF(x, y, width, height);
        return box;
    }
    public override void SizeDW()
    {
        int check = this.Width;
        check -= 3;
        int space = this.Width * 10;
        float tab = (10 * this.Width - 10 * (this.Width - 1)) / 2;
        //debug
        PointF Centr = new PointF(P1.X - space / 2, P1.Y);
        Console.WriteLine("cen: " + Centr);

        PointF T1 = new PointF(this.P1.X - tab, this.P1.Y);

        Console.WriteLine("T1: " + T1);

        if (check > 3)
        {
            this.P1 = T1;
            this.Width -= 1;
        }
    }
    public override void SizeUP()
    {
        int space = this.Width * 10;
        float tab = (10 * this.Width - 10 * (this.Width - 1)) / 2;
        //debug
        PointF Centr = new PointF(P1.X - space / 2, P1.Y);
        Console.WriteLine("cen: " + Centr);

        PointF T1 = new PointF(this.P1.X + tab, this.P1.Y);

        Console.WriteLine("T1: " + T1);

        this.P1 = T1;
        this.Width += 1;
    }
}

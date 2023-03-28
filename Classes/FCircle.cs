using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

public class FCircle : Line
{
    public FCircle(Color color, int width,int style) : base(color, width,style)
    {
        Name = "Circle";
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
        float radius = (float)Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        // Then to rotate, prepending rotation matrix.
        e.Graphics.FillEllipse(Brush, P1.X - radius, P1.Y - radius, 2 * radius, 2 * radius);
    }
    public override bool CContains(Panel a, MouseEventArgs e)
    {
        PointF Mouse = new PointF(e.Location.X, e.Location.Y);
        float radius = (float)Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        float x = P1.X - radius;
        float y = P1.Y - radius;
        float height = 2 * radius;
        float width = 2 * radius;
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
        float radius = (float)Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        float x = P1.X - radius;
        float y = P1.Y - radius;
        float height = 2 * radius;
        float width = 2 * radius;
        RectangleF box = new RectangleF(x, y, width, height);
        return box;
    }
}

using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class FPoly : Line
{
    public FPoly(Color color, int width, int style) : base(color, width, style)
    {
        Name = "Poly";
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
        // Draw the Polygon
        e.Graphics.DrawPolygon(Pen, Points.ToArray());
        e.Graphics.FillPolygon(Brush, Points.ToArray());
    }
    public override bool CContains(Panel a, MouseEventArgs e)
    {
        Point Mouse = new Point(e.Location.X, e.Location.Y);
        int len = Points.Count();
        float x = P1.X;
        float y = P1.Y;
        float maxw = 0;
        float maxh = 0;
        //Finding the first point
        for (int i = 0; i < len; i++)
        {
            if (Points[i].Y < y)
            {
                y = Points[i].Y;
            }
            if (Points[i].X < x)
            {
                x = Points[i].X;
            }
        }
        //finding the limits 
        for (int i = 0; i < len; i++)
        {
            if (Points[i].X > maxw)
                maxw = Points[i].X;
            if (Points[i].Y > maxh)
                maxh = Points[i].Y;
        }
        maxh -= y;
        maxw -= x;
        RectangleF box = new RectangleF(x, y, maxw, maxh);
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
    public override void SetPivot()         //Set Pivot,  At i = 0: we save P1,  At i = 1: we save P2
    {
        if (PointM.Count() == 0)
        {
            int len = Points.Count();
            for (int i = 0; i < len; i++)
            {
                PointM.Add(Points[i]);
            }
        }
        else
        {
            int len = Points.Count();
            for (int i = 0; i < len; i++)
            {
                PointM[i] = Points[i];
            }
        }
    }
    public override RectangleF GetContains()
    {
        int len = Points.Count();
        float x = P1.X;
        float y = P1.Y;
        float maxw = 0;
        float maxh = 0;
        //Finding the first point
        for (int i = 0; i < len; i++)
        {
            if (Points[i].Y < y)
            {
                y = Points[i].Y;
            }
            if (Points[i].X < x)
            {
                x = Points[i].X;
            }
        }
        //finding the limits 
        for (int i = 0; i < len; i++)
        {
            if (Points[i].X > maxw)
                maxw = Points[i].X;
            if (Points[i].Y > maxh)
                maxh = Points[i].Y;
        }
        maxh -= y;
        maxw -= x;
        RectangleF box = new RectangleF(x, y, maxw, maxh);
        return box;
    }
    public override void SizeUP()
    {
        List<PointF> tmp = new List<PointF>();
        tmp.Add(Points[0]);
        Console.WriteLine("p[" + 0 + "]: " + Points[0]);
        int len = Points.Count();
        if (len > 2)
        {
            for (int i = 1; i < len; i++)
            {
                Console.WriteLine("p[" + i + "]: " + Points[i]);
                //finding dx [0] and [i]
                float x = -Points[0].Y + Points[i].Y;
                float y = Points[0].X - Points[i].X;
                float dx1 = (float)x / y;
                Console.WriteLine("Dx1 0-" + i + ": " + dx1);
                if (i == 1)
                {
                    PointF p2 = new PointF(this.Points[i].X + 3, this.Points[i].Y - (3 * dx1));
                    tmp.Add(p2);
                    Console.WriteLine("p[" + i + "]': " + tmp[i]);
                }
                else
                {
                    x = -Points[i - 1].Y + Points[i].Y;
                    y = Points[i - 1].X - Points[i].X;
                    float dx2 = (float)x / y;
                    Console.WriteLine("Dx1 " + (i - 1) + " - " + i + ": " + dx2);
                    x = dx2 * (-tmp[i - 1].X) - tmp[i - 1].Y + dx1 * (Points[0].X) + Points[0].Y;
                    x /= (dx1 - dx2);
                    Console.WriteLine(x);
                    y = -dx1 * (x - Points[0].X) + Points[0].Y;
                    Console.WriteLine(y);
                    PointF p2 = new PointF(x, y);
                    tmp.Add(p2);
                    Console.WriteLine("p[" + i + "]': " + tmp[i]);
                }
            }
            for (int i = 0; i < len; i++)
                Points[i] = tmp[i];
        }
        else
        {
            float x = -Points[0].Y + Points[1].Y;
            float y = Points[0].X - Points[1].X;
            float dx1 = (float)x / y;
            Console.WriteLine("Dx1 0-" + 1 + ": " + dx1);
            PointF p2 = new PointF(this.Points[1].X + 3, this.Points[1].Y - (3 * dx1));
            Points[1] = p2;
        }
    }
    public override void SizeDW()
    {
        bool flag = true;
        List<PointF> tmp = new List<PointF>();
        tmp.Add(Points[0]);
        Console.WriteLine("p[" + 0 + "]: " + Points[0]);
        int len = Points.Count();
        if (len > 2)
        {
            for (int i = 1; i < len; i++)
            {
                Console.WriteLine("p[" + i + "]: " + Points[i]);
                //finding dx [0] and [i]
                float x = -Points[0].Y + Points[i].Y;
                float y = Points[0].X - Points[i].X;
                float dx1 = (float)x / y;
                Console.WriteLine("Dx1 0-" + i + ": " + dx1);
                if (i == 1)
                {
                    PointF p2 = new PointF(this.Points[i].X - 3, this.Points[i].Y + (3 * dx1));
                    float check = this.Points[i].X - 10 - this.Points[0].X;
                    if (check > 5)
                    {
                        tmp.Add(p2);
                        Console.WriteLine("p[" + i + "]': " + tmp[i]);
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    x = -Points[i - 1].Y + Points[i].Y;
                    y = Points[i - 1].X - Points[i].X;
                    float dx2 = (float)x / y;
                    Console.WriteLine("Dx1 " + (i - 1) + " - " + i + ": " + dx2);
                    x = dx2 * (-tmp[i - 1].X) - tmp[i - 1].Y + dx1 * (Points[0].X) + Points[0].Y;
                    x /= (dx1 - dx2);
                    Console.WriteLine(x);
                    y = -dx1 * (x - Points[0].X) + Points[0].Y;
                    Console.WriteLine(y);
                    PointF p2 = new PointF(x, y);
                    tmp.Add(p2);
                    Console.WriteLine("p[" + i + "]': " + tmp[i]);
                }
            }
            if (flag == true)
                for (int i = 0; i < len; i++)
                    Points[i] = tmp[i];
        }
        else
        {
            float check = this.Points[1].X - 10 - this.Points[0].X;
            if (check > 5)
            {
                float x = -Points[0].Y + Points[1].Y;
                float y = Points[0].X - Points[1].X;
                float dx1 = (float)x / y;
                Console.WriteLine("Dx1 0-" + 1 + ": " + dx1);
                PointF p2 = new PointF(this.Points[1].X - 3, this.Points[1].Y + (3 * dx1));
                Points[1] = p2;
            }
        }
    }
    public override void DrawBox(Panel a, bool flag)
    {
        if(flag)
        {
            int len = Points.Count();
            float x = P1.X;
            float y = P1.Y;
            float maxw = 0;
            float maxh = 0;
            //Finding the first point
            for (int i = 0; i < len; i++)
            {
                if (Points[i].Y < y)
                {
                    y = Points[i].Y;
                }
                if (Points[i].X < x)
                {
                    x = Points[i].X;
                }
            }
            //finding the limits 
            for (int i = 0; i < len; i++)
            {
                if (Points[i].X > maxw)
                    maxw = Points[i].X;
                if (Points[i].Y > maxh)
                    maxh = Points[i].Y;
            }
            maxh -= y;
            maxw -= x;
            RectangleF box = new RectangleF(x, y, maxw, maxh);
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
    }
}

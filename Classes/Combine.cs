using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

public class Combine : Line
{
    private PointF StPoint;
    private PointF EDPoint;
    public Combine(Color color, int width, int style, List<Line> Shapes, List<int> SEindex) : base(color, width, style)
    {
        gshapes = new List<Line>();
        foreach (int i in SEindex)
            gshapes.Add(Shapes[i]);
        Name = "Combine";
    }
    public override void Paint(PaintEventArgs e)
    {
        foreach(Line i in gshapes)
        {
            i.Paint(e);
        }
    }
    public override bool CContains(Panel a, MouseEventArgs e)
    {
        PointF Mouse = new PointF(e.Location.X, e.Location.Y);
        List<PointF> ptemp = new List<PointF>();
        List<RectangleF> Rec = new List<RectangleF>();
        foreach( Line i in gshapes)
        {
            RectangleF temp = i.GetContains();
            Rec.Add(temp);
            ptemp.Add(temp.Location);
        }
        //Finding the first point
        float x = ptemp[0].X;
        float y = ptemp[0].Y;
        int len = ptemp.Count();
        for (int i = 0; i < len; i++)
        {
            if (ptemp[i].Y < y)
            {
                y = ptemp[i].Y;
            }
            if (ptemp[i].X < x)
            {
                x = ptemp[i].X;
            }
        }
        StPoint = new PointF(x, y);
        //finding the limits
        float maxh = 0;
        float maxw = 0;
        for (int i = 0; i < len; i++)
        {
            if (ptemp[i].X + Rec[i].Width > maxw)
                maxw = ptemp[i].X + Rec[i].Width;
            if (ptemp[i].Y +  Rec[i].Height > maxh)
                maxh = ptemp[i].Y + Rec[i].Height;
        }
        EDPoint = new PointF(maxw, maxh);
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
        foreach (Line i in gshapes)
        {
            i.SetPivot();
        }
    }
    public override void SizeDW()
    {
        foreach (Line i in gshapes)
        {
            i.SizeDW();
        }
    }
    public override void SizeUP()
    {
        foreach (Line i in gshapes)
        {
            i.SizeUP();
        }
    }
}

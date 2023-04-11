using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class Ellipse : Line
{
    public Ellipse(Color color, int width,int style) : base(color, width, style)
    {
        Name = "Ellipse";
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
        float x = MathF.Min(P1.X, P2.X);
        float y = MathF.Min(P1.Y, P2.Y);
        float height = MathF.Abs(P2.Y - P1.Y);
        float width = MathF.Abs(P2.X - P1.X);

        e.Graphics.DrawEllipse(Pen, x, y, width, height);
    }
}

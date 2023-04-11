using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

/* Dash Styles
  Solid = 0,
  Dash = 1,
  Dot = 2,
  DashDot = 3,
  DashDotDot = 4,
*/

public interface Shape
{
    //Varible Declaration;
    float Dx
    {
        get;
        set;
    }
     List<Shape> gshapes
    {
        get;
        set;
    }
     PointF P1
    {
        get;
        set;
    }
     PointF P2
    {
        get;
        set;
    }
     int Width
    {
        get;
        set;
    }
     Color Color
    {
        get;
        set;
    }
     Pen Pen
    {

        get;
        set;
    }
     SolidBrush Brush
    {
        get;
        set;
    }
     int Style
    {
        get;
        set;
    }
     List<PointF> Points
    {
        get;
        set;
    }
     List<PointF> PointM
    {
        get;
        set;
    }
     string Name
    {
        get;
        set;
    }

    //Functions
     void Paint(PaintEventArgs e);
     bool CContains(Panel a, MouseEventArgs e);
     void SetPivot();        //Set Pivot,  At i = 0: we save P1,  At i = 1: we save P2
     RectangleF GetContains();
     void SizeDW();
     void SizeUP();
     void DrawBox(Panel a, bool flag);

}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* Dash Styles
  Solid = 0,
  Dash = 1,
  Dot = 2,
  DashDot = 3,
  DashDotDot = 4,
*/

interface Shape
{
    //Varible Declaration;
    public List<Line> gshapes
    {
        get;
        set;
    }
    public PointF P1
    {
        get;
        set;
    }
    public PointF P2
    {
        get;
        set;
    }
    public int Width
    {
        get;
        set;
    }
    public Color Color
    {
        get;
        set;
    }
    public Pen Pen
    {

        get;
        set;
    }
    public SolidBrush Brush
    {
        get;
        set;
    }
    public int Style
    {
        get;
        set;
    }
    public List<PointF> Points
    {
        get;
        set;
    }
    public List<PointF> PointM
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }

    //Functions
    public void Paint(PaintEventArgs e);
    public bool CContains(Panel a, MouseEventArgs e);
    public void SetPivot();        //Set Pivot,  At i = 0: we save P1,  At i = 1: we save P2
    public RectangleF GetContains();
    public void SizeDW();
    public void SizeUP();
    public void DrawBox(Panel a, bool flag);

}

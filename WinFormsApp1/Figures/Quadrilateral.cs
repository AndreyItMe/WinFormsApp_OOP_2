using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_OOP_2.Visitors;

namespace WinFormsApp_OOP_1.GraphicsFigures.Figures
{
    //internal class Quadrilateral : Line, IFigure
    [Serializable]
    public class Quadrilateral : IFigure
    {
        private Graphics graphics;

        public Quadrilateral() { }

        public System.Drawing.Point StartPoint { get; set; }
        public System.Drawing.Point EndPoint { get; set; }

        public Color color { get; set; }

        public Quadrilateral(System.Drawing.Point startPoint, System.Drawing.Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            color = Color.Black;
        }

        public new void Draw(IVisitor visitor)
        {
            visitor.VisitQuadrilateral(this);
        }

        public void Accept(Quadrilateral quadrilateral)
        {

            int x1 = quadrilateral.StartPoint.X;
            int y1 = quadrilateral.StartPoint.Y;
            int x2 = quadrilateral.EndPoint.X;
            int y2 = quadrilateral.EndPoint.Y;

            System.Drawing.Point[] vertices = new System.Drawing.Point[]
            {
                new System.Drawing.Point(x1, y1),
                new System.Drawing.Point(x2, y1),
                new System.Drawing.Point(x1, y2),
                new System.Drawing.Point(x2, y2)
            };
            graphics.DrawPolygon(new Pen(Color.Black), vertices);
        }

        public override string ToString()
        {
            return $"Quadrilateral ({StartPoint}, {EndPoint})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_OOP_2.Visitors;

namespace WinFormsApp_OOP_1.GraphicsFigures.Figures
{
    //internal class Rectangle : Point, IFigure
    [Serializable] //для сериализации
    public class Rectangle : Point, IFigure
    {
        public Rectangle() { }

        /*public new System.Drawing.Point StartPoint { get; set; }*/
        /*public new System.Drawing.Point EndPoint { get; set; }*/

        public Rectangle(System.Drawing.Point startPoint, System.Drawing.Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            color = Color.Black;
        }
        public new void Draw(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
        public override string ToString()
        {
            return $"Rectangle ({StartPoint}, {EndPoint})";
        }
    }
}

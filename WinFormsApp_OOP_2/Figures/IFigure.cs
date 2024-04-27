using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_OOP_2.Visitors;

namespace WinFormsApp_OOP_1.GraphicsFigures.Figures
{
    //internal interface IFigure
    public interface IFigure
    {
        void Change(IVisitor visitor);
        void Accept(IVisitor visitor);
    }
} 

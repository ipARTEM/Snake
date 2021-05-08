using System;
using System.Collections.Generic;

namespace Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            HorizontalLine leftLine = new HorizontalLine(0, 24, 0, '+');
            HorizontalLine rightLine = new HorizontalLine(0, 24, 78, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисовка точек
            Point p = new Point(4,5,'*');
            p.Draw();

            
            

        }
    }
}

using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006Fractal
{
    class Program
    {
        // http://ru.wikipedia.org/wiki/Кривая_Коха
        static int brok = 0;
        static void Main(string[] args)
        {
            GraphicsWindow.Show();

            GraphicsWindow.MouseDown += GraphicsWindow_MouseDown;
        }

        private static void GraphicsWindow_MouseDown()
        {
            
            int x1 = GraphicsWindow.Width / 2, y1 = 10;
            int x2 = 400, y2 = GraphicsWindow.Height - 350;
            int x3 = GraphicsWindow.Width-400, y3 = GraphicsWindow.Height - 350;

            GraphicsWindow.PenWidth = 2;
            GraphicsWindow.DrawLine(x1, y1, x2, y2);
            GraphicsWindow.DrawLine(x2, y2, x3, y3);
            GraphicsWindow.DrawLine(x3, y3, x1, y1);

            Koch(x1, y1, x2, y2, x3, y3, brok);
            Koch(x2, y2, x3, y3, x1, y1, brok);
            Koch(x3, y3, x1, y1, x2, y2, brok);
            brok++;

        }

        static void Koch(int X1, int Y1, int X2, int Y2, int X3, int Y3, int Step)
        {
            if (Step >= 0)   
            {
                var x4 = (int)((X2 + 2 * X1) / 3);
                var y4 = (int)((Y2 + 2 * Y1) / 3);

                var x5 = (int)((2 * X2 + X1) / 3);
                var y5 = (int)((Y1 + 2 * Y2) / 3);

                var xs = (int)((X2 + X1) / 2);
                var ys = (int)((Y2 + Y1) / 2);
                var xn = (int)((4 * xs - X3) / 3);
                var yn = (int)((4 * ys - Y3) / 3);
               
                GraphicsWindow.DrawLine(x4, y4, xn, yn);
                GraphicsWindow.DrawLine(x5, y5, xn, yn);
                GraphicsWindow.DrawLine(x4, y4, x5, y5);

                Koch(x4, y4, xn, yn, x5, y5, Step - 1);
                Koch(xn, yn, x5, y5, x4, y4, Step - 1);

                Koch(X1, Y1, x4, y4, (int)((2 * X1 + X3) / 3), (int)((2 * Y1 + Y3) / 3) + 1, Step - 1);
                Koch(x5, y5, X2, Y2, (int)((2 * X2 + X3) / 3), (int)((2 * Y2 + Y3) / 3) + 1, Step - 1);

            }
             
        }
    }
}

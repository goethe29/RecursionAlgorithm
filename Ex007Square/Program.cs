using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex007Square
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.MouseDown += () =>
            {
                int x = 10;
                int y = 10;
                int w = 1000;
                int h = 1000;

                DrawSquare(100, x, y, x + w, y, x + w, y + h, x, y + h);
            };
        }
        
        static void DrawSquare(int Deep, params int[] P)
        {
            double alpha = 0.5;
            for (int i = 0; i < 8; i+=2)
            {
                GraphicsWindow.DrawLine(P[i%8], P[(i+1) % 8], P[(i + 2) % 8], P[(i + 3) % 8]);
            }
            
            if (Deep>0)
            {
                int x1 = (int)(P[0] * (1 - alpha) + P[2] * alpha);
                int x2 = (int)(P[2] * (1 - alpha) + P[4] * alpha);
                int x3 = (int)(P[4] * (1 - alpha) + P[6] * alpha);
                int x4 = (int)(P[6] * (1 - alpha) + P[0] * alpha);

                int y1 = (int)(P[1] * (1 - alpha) + P[3] * alpha);
                int y2 = (int)(P[3] * (1 - alpha) + P[5] * alpha);
                int y3 = (int)(P[5] * (1 - alpha) + P[7] * alpha);
                int y4 = (int)(P[7] * (1 - alpha) + P[1] * alpha);

                DrawSquare(Deep - 1, x1, y1, x2, y2, x3, y3, x4, y4);

            }

        }


    }
}

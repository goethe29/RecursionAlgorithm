using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex007Square
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1;
            GraphicsWindow.MouseDown += () =>
            {
                GraphicsWindow.Clear();
                int s = 20;
                int x = s;
                int y = s;
                int w = GraphicsWindow.Width - 2*x - 10;
                int h = GraphicsWindow.Height - 2*x - 10;

                
                DrawSquare(100,a, x, y, x + w, y, x + w, y + h, x, y + h);
                if (GraphicsWindow.LastKey == "D1") a += 0.05;
                if (GraphicsWindow.LastKey == "D2") a -= 0.05;
            };
        }
        
        static void DrawSquare(int Deep, double alp, params int[] P)
        {
             
            for (int i = 0; i < 8; i+=2)
            {
                GraphicsWindow.DrawLine(P[i%8], P[(i+1) % 8], P[(i + 2) % 8], P[(i + 3) % 8]);
            }
            
            if (Deep>0)
            {
                int x1 = (int)(P[0] * (1 - alp) + P[2] * alp);
                int x2 = (int)(P[2] * (1 - alp) + P[4] * alp);
                int x3 = (int)(P[4] * (1 - alp) + P[6] * alp);
                int x4 = (int)(P[6] * (1 - alp) + P[0] * alp);

                int y1 = (int)(P[1] * (1 - alp) + P[3] * alp);
                int y2 = (int)(P[3] * (1 - alp) + P[5] * alp);
                int y3 = (int)(P[5] * (1 - alp) + P[7] * alp);
                int y4 = (int)(P[7] * (1 - alp) + P[1] * alp);
               
                DrawSquare(Deep - 1, alp, x1, y1, x2, y2, x3, y3, x4, y4);

            }

        }


    }
}

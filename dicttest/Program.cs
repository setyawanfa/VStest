using System;
using System.Collections.Generic;
using System.Linq;

namespace dicttest
{
    class Program
    {
        public struct Point
        {
            public double x,y;
            
            public Point(double p1,double p2)
            {
                x = p1;
                y = p2;
            }
        }
        static public double distance(Point p1, Point p2)
        {
            double dist = Math.Sqrt(Math.Pow(p2.y - p1.y, 2) + Math.Pow(p2.x - p2.x, 2));
            return dist;
        }
        static void Main(string[] args)
        {
            
            Dictionary<string, Point> dictnum = new Dictionary<string, Point>();
            //point declaration
            Point coor1 = new Point(1, 1);
            Point coor2 = new Point(2, 5);
            Point coor3 = new Point(3, 2);
            Point coor4 = new Point(7, 9);
            Point coor5 = new Point(6, 8);
            //dictionary insert
            dictnum.Add("Point 1", coor1);
            dictnum.Add("Point 2", coor2);
            dictnum.Add("Point 3", coor3);
            dictnum.Add("Point 4", coor4);
            dictnum.Add("Point 5", coor5);

            List<string> key = new List<string>();
            key = dictnum.Keys.ToList();
            for (int i = 0; i < key.Capacity; i++)
            {
                double jarak = 10000000;
                Point titik1 = dictnum[key[i]];
                int ketemu = 0;
                for (int j = 0; j < key.Capacity; j++)
                {
                    if (i != j)
                    {
                        Point titik2 = dictnum[key[j]];
                        double ss = distance(titik1, titik2);
                        if (ss < jarak)
                        {
                            jarak = ss;
                            ketemu = j;
                        }
                    }
                    
                }
                Console.WriteLine("{0} nearest point is {1} ", key[i], key[ketemu]);
            }
            Console.Read();
        }
    }
}

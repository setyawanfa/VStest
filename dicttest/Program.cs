using System;
using System.Collections.Generic;
using System.Linq;
namespace dicttest
{
    class Program
    {
        public struct Point
        {
            public int x,y;
            
            public Point(int p1,int p2)
            {
                x = p1;
                y = p2;
            }
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
                Console.WriteLine(key[i]+" "+dictnum[key[i]].x+" "+dictnum[key[i]].y);
                
            }
            Console.Read();
        }
    }
}

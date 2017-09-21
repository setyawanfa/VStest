using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"G:\fe\jquery.html");
            Console.WriteLine("the output is:");
            Boolean udahprint=false;
            foreach (string line in text)
            {
                if (line.Contains("<p>") && !udahprint)
                {
                    udahprint = true;
                    string kata1 = line.Replace("<p>", "").Replace("</p>", "");
                    string[] kata2 = kata1.Split(' ');
                    int count = 0;
                    int i = 0;
                    while (count<150 && i<kata2.Length)
                    {
                        count = count + kata2[i].Length + 1;
                        if (count < 150)
                        {
                            Console.Write("{0} ", kata2[i]);
                        }
                        i++;
                    }
                    
                }
                }
            Console.Read();
        }
    }
}

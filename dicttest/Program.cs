using System;
using System.Collections.Generic;
using System.Text;

namespace dicttest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicNumber = new Dictionary<string, string>();
            List<string> listNumber = new List<string>();

            dicNumber.Add("1", "First");
            dicNumber.Add("2", "Second");
            dicNumber.Add("3", "Third");
            var keys = new List<string>(dicNumber.Keys);
            var values = new List<string>(dicNumber.Values);
            for (int i = 0; i < keys.Capacity; i++)
            {
                Console.WriteLine(dicNumber.Keys);
                
            }
            Console.Read();
        }
    }
}

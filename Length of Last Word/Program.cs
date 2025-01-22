using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    internal class Program
    {
        public static int Length(string s)
        {
            string[] s2 = s.Trim().Replace("  "," ").Split(' ');
            string n = s2[s2.Length - 1];
            return n.Length;
        }
        static void Main(string[] args)
        {
            string s = " we  are flying in  the  moon  ";
            int length = Length(s);
            Console.WriteLine("The Length of the last word : "+length);

            Console.ReadKey();
        }
    }
}

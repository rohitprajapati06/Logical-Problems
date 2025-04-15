using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_Characters
{
    internal class Program
    {
        public static void RepeatCharacters(string input , string current , string result)
        {
              foreach (char c in input) {

                    if (char.IsLetter(c))
                    {
                        current += c;
                    }
                    else if (char.IsDigit(c))
                    {
                        int length = int.Parse(c.ToString());

                        for(int j = 0; j < length; j++)
                        {
                            result += current;
                        }

                        current = "";
                    }
                }
            Console.WriteLine($"Output : {result}");
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string current = "";
            string result = "";
            RepeatCharacters(input , current , result );
        }
    }
}

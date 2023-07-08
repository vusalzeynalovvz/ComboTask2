using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original string: java");
            Console.WriteLine("Said string in uppercase: " + test("salam ay yaver ustaaaaa... netersen rovsen qadan alim"));
        }
        public static string test(string text)
        {
            return new string(text.ToCharArray().Reverse().ToArray()).ToUpper();
        }
    }

}

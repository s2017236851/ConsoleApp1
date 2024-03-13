using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            for (int qq = 0, i = 0; i < 4; i++, qq++)
            {
                Thread.Sleep(1000);
                int aaa = i + qq;
                Console.Write(aaa);
                a = i.ToString();
            }
            Console.WriteLine(a);
        }
        public string shujv()
        {
            return "32323232";
        }
        public string qwqwq()
        {
            return "32323232";
        }
        public string qwqwqq()
        {
            return "32323232";
        }

    }
}

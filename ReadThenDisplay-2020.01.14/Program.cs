using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThenDisplay_2020._01._14
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            string input;
            Console.WriteLine("請輸入文字:");
            input = Console.ReadLine();
            Console.Write("你輸入的文字是:");
            Console.WriteLine(input);
            Console.ReadLine();

            int result = Mutiple(5,6);

        }
        /// <summary>
        /// 回傳兩數乘積
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Mutiple(int x, int y)
        {
            return x * y;
        }
    }
}

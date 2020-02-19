using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionDisplay_2020._01._15
{
    class Program
    {
        static void Main(string[] args)
        {

            int condition = 10;
            int value;
            Console.WriteLine("請輸入一個數字:");
            string input = Console.ReadLine();//讀進來的是字串
            value = int.Parse(input);//字串轉換成整數數值
            if (value > condition)
            {
                Console.WriteLine($"輸入的值大於{condition}");
                //$是可以讓condition可以直接帶入值(2015版本以後可以用) 叫做字串插補 ->語法糖 就是簡化
                //Console.WriteLine(string.Format("輸入的值大於 {0}", condition));文字格式化(舊寫法)
                //Console.WriteLine("輸入的值小於" + condition.ToString ());(最舊寫法)
            }
            else
            {
                if (value < condition)
                {
                    Console.WriteLine($"輸入的值小於於{condition}");
                }
                else
                {
                    Console.WriteLine($"輸入的值等於{condition}");
                }
            }

            //下面比較好 分支不多
            if (value > condition)
            {
                Console.WriteLine($"輸入的值大於{condition}");
                //$是可以讓condition可以直接帶入值
                Console.WriteLine("輸入的值大於"+condition);
                
            }
            else if (value < condition)
            {
                Console.WriteLine($"輸入的值小於於{condition}");
            }
            else
            {
                Console.WriteLine($"輸入的值等於{condition}");
            }

            Console.ReadLine();

        }
    }
}

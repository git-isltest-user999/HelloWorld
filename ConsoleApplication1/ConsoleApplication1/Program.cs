using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 あ;
            String エラーメッセージ = "エラーです";

            if (Int32.TryParse("10", out あ))
            {
                Console.WriteLine(あ);
            }
            else
            {
                Console.WriteLine(エラーメッセージ);
            }
        }
    }
}

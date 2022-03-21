using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜密碼
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ans = 0;
            int guess = 0;
            int max = 100, min = 0;
            int num = 0;
            ans = random.Next(1, 101);
            while (true)
            { 
                Console.WriteLine($"猜數字範圍{min}~{max}");
                Console.WriteLine("請輸入數字:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess >= min && guess < max)
                {
                    num++;
                    if (guess == ans)
                    {
                        Console.WriteLine();
                        Console.WriteLine("答對了");
                        Console.WriteLine($"總共答了{num}次");
                        break;
                    }
                    else if (guess > ans)
                    {
                        max = guess;
                        Console.WriteLine($"答錯了，答案介於{min}~{max}之間");
                    }
                    else if (guess < ans)
                    {
                        min = guess;
                        Console.WriteLine($"答錯了，答案介於{min}~{max}之間");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("超出範圍了，請重新輸入");
                    Console.WriteLine();
                }
            }
            Console.Read();

        }
    }
}

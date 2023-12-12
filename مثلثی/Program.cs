
    using System;
using System.Collections.Generic;
using System.Text;
///////////////////////

//www.SourceCodes.ir

///////////////////////
namespace mosalase_adad
{
    class Program
    {
        static void delay(int d)
        {
            for (int j = 0; j < d; j++) ; //delay
        }
        static void printr(string str, int repeat, int d)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(str);
                delay(d);
            }
        }
        static void print(string str, int start, int end, int d)
        {
            if (end == 0)
                end = str.Length;
            for (int i = start; i < end; i++)
            {
                Console.Write(str[i]);
                delay(d);
            }
        }
        static void loading()
        {
            print(" mosallase adad ", 0, 0, 20000000);
            delay(300000000);
            Console.Clear();
            printr("_", 80, 1900000);
            Console.Write(" ");
            string name = " ..........www.SourceCodes.ir.......... ";
            int namecount = name.Length;
            print(name, 0, 0, 9000000);
            printr("_", 80, 1900000);
        }
        //======================================================================================
        //======================================================================================

        static void Main(string[] args)
        {
            loading();


            int number = 0;
            print("Enter a number : ", 0, 0, 20000000);
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                    delay(2000000);
                }
                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                    delay(2000000);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
            print(" www.SourceCodes.ir ", 0, 0, 20000000);
            delay(300000000);

        }
    }
}
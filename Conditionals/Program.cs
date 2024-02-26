using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Ifelse
            var number = 15;
            if (number > 10)
            {
                Console.WriteLine("Number is greater than 10!");
            }
            else if (number == 0)
            {
                Console.WriteLine("Number is 0 !");

            }
            else
            {
                Console.WriteLine("Number is less than 10 ! ");
            }
            #endregion

            #region SingleLineIf
            var number2 = 10;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");  // single line if 
            #endregion

            #region SwitchCase
            int number3 = 25;
            switch (number3)
            {
                case 0:
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 0");
                    break;
                case 25:
                    Console.WriteLine("Number is 25");
                    break;

                default: // hiçbir durum gerçekleşmezse çalışacak olan bölüm.
                    Console.WriteLine("Unexpected error !");
                    break;
            }
            #endregion

            #region MultipleIfElseBlock
            int number4 = 150;
            if (number4 >= 0 && number <= 200)
            {
                Console.WriteLine("Number is between 0 and 200");
            }
            else if (number > 200 && number <= 250)
            {
                Console.WriteLine("Number is between  200 - 250");
            }
            else if (number < 0 || number > 250)
            {
                Console.WriteLine("Number is less than 0 or greater than 250");
            }
            #endregion

            #region NestedLoops
            int number5 = 44;
            if (number5 < 50)
            {
                if (number5 >= 40 && number5 < 45)
                {
                    Console.WriteLine("Number is between 40 - 45 ");
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}

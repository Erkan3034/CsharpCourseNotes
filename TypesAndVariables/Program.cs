using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");

            //-------------------------------->Value types

            #region ByteType
            byte number4 = 0; // (8-bit (0~255)) // the smallest variable type
            Console.WriteLine(number4);
            #endregion

            #region ShortType
            short number3 = -32768; //(16-bit (-32768~32767)
            Console.WriteLine(number3);
            #endregion

            #region IntType
            int number1 = 2147483647; // the capacity of int variable is (-2147483648 ~ 2147483647) (32-bit)
            Console.WriteLine("Number 1 is = " + number1);
            #endregion

            #region LongType
            long number2 = 9223372036854775807;// the long variable is twice the int variable type. but it takes more memory spaces.(64-bit)
            Console.WriteLine(" The long number is = ");
            #endregion

            #region BoolType
            bool condition = true; //bool type is for conditions
            Console.WriteLine(condition);
            #endregion

            #region CharType
            char character = 'N';
            Console.WriteLine(character);
            #endregion

            #region DoubleType 
            double number5 = 15.54; //(64-bit)
            Console.WriteLine(number5); // double is used for ıntegers and also for decimal numbers
            #endregion

            #region VarType
            var variable = 7; // var type decides the type of the variable at runtime
            Console.WriteLine(variable);

            #endregion

            Console.WriteLine(Days.Monday);
            Console.ReadLine();
        }
    }

    enum Days // bize aslında liste  halinde bir dize oluştur ve burdaki elemanlar üzerinden işlem yapamamıza olanak sağlayan bir değişken türüdür.
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}

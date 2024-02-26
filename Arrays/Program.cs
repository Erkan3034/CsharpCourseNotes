using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Erkan";
            //students[1] = "Serkan";
            //students[2] = "Necip";

            ////for (int i = 0; i < students.Length; i++)
            ////{
            ////    Console.WriteLine(students[i]); // Dizideki elemanları yazdırma
            ////}


            ////Alternative Foreach loop instead of For loop 
            //foreach (string student in students) 
            //{
            //    Console.WriteLine(student);
            //}

            //Alternative usage


            string[] students = { "Ali", "Mehmet", "Can" };

            foreach (string item in students) { Console.WriteLine(item); }
            #region MultipleArrays
            string[,] regions = new string[7, 2] // 7= satır sayısı , 2= sütun sayısı
            {

                { "İstanbul","Bursa"},
                { "Adana","Antalya"},
                { "Hakkari","Van"},
                { "Ankara","Karabük"},
                { "Aydın","İzmir"},
                { "Bartın","Zonguldak"},
                { "Kayseri","Kars"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // GetUpperBound ile ilk boyutu(satırı) alırız
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) // GetUpperBound ile ikinci boyutu(satırı) alırız
                {            
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("-*-*-*-**-*-*-");
            }
            #endregion

            Console.ReadLine();

        }
    }
}

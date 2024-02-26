using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Strings
            //ın fact every string is a char series
            string city = "Ankara";

            foreach (var s in city)
            {
                Console.WriteLine(s);
            }

            string city2 = "İstanbul";
            //string result = city2 + city;

            Console.WriteLine(String.Format("{0} {1}", city, city2));

            #endregion

            string sentence = " My name is Erkan";
            var result=sentence.Length; // karakter sayısı
            Console.WriteLine(result);

            Console.WriteLine("-----------------------");

            var result2 = sentence.Clone(); // İlgili cümlenin referansısı oluşturur(kopya)
            sentence = "My name is Serkan Turgut";
            Console.WriteLine(result2);

            Console.WriteLine("-----------------------");

            bool result3 = sentence.EndsWith("t"); //Cümlenin t ile bittiğini kontrol eder.
            bool result4=sentence.StartsWith("M");
            Console.WriteLine(result3);


            var result5= sentence.IndexOf("name"); //Bir strındgde belli bir ifadeyı aramak için kullanılır.(name nin indexini bulur)
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf(" "); //Bulduğu ilk boşluğu bulur ve durur.
            Console.WriteLine(result6);

            var result7 = sentence.LastIndexOf(" "); // Sondan aramaya başlar 
            Console.WriteLine(result7);

            var result8 = sentence.Insert(0,"Hello, "); //Cümlenin 0. karakterinden sonra "hello," yazısını ekle.
            Console.WriteLine(result8);

            var result9 = sentence.Substring(3); // cümleyi 3. karakterden itibaren al
            Console.WriteLine(result9);

            var result10 = sentence.ToLower(); // tüm karakterleri küçük yazar
            Console.WriteLine(result10);

            var result11 = sentence.ToUpper(); // tüm karakterleri büyük harf yapar
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ", "-"); // boşlukların yerini - ile değiştir.
            Console.WriteLine(result12);

            var result13 = sentence.Remove(2); // 2. karakterden sonrasını kaldır
            Console.WriteLine(result13);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Diyelim ki veri tabanına bir kullanıcı kaydı yapacağoz. Bunu her kullanıcı için ayrı ayrı tek tek yaparsak  ilerde bir şey eklememiz gerektiğinde onlarca yeri değiştirmemiz anlamına gelir. Bundan kurtulmak için ve verileri tek merkezden yönetmek için mettot kullanırız 

            //Add(); // Method calling
            //Add();
            //Add();


            //var result = Add2(40, 50);
            //Console.WriteLine( "Result of return method = "+result);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);


            //Console.WriteLine(Multiply(4, 5));
            //Console.WriteLine(Multiply(4, 5, 2));


            Console.WriteLine(Add4(10,9,8,7,6,5,4,3,2,1)); // İstenildiği miktarda değer girilebilir.
            Console.ReadLine();

          
        }

        static void Add()
        {
            Console.WriteLine(" Added !!!");
        }

        static int Add2(int a, int b = 35) // Default parametre old için metot 35'i dikkate alır
        {
            //return a + b;
            var result = a + b;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30; // değer tip (mevzu sadece değişkenin değeri ile ilgilidir)
            var result2 = number1 + number2;
            return result2;

            //ref keywordü ile  number1'in number1'in  referans tutup onu işleme almasını istiyoruz. Bellekte ikkinci bir numner1 alanı açması yerinde diğer  number1'in referansını tutmasını isteriz.
        }


        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) // Aynı isimde farklı parametre ile oluşturulan metotlar ) = Overloading
        {
            return number1 * number2 * number3;
        }


        //Params( kullanıcının kaç sayı girşi yapacağını bilmediğimiz durumlarda Metot overload yapmamız pek sağlıklı olmazç. Bu yüzden Params keywordü ile girilen değere göre metodun çalışmasını sağlarız.Bunu da dizi kavramı ile birlikte kullanırız. Yani params girilen değerlerle bir dizi oluşturup metotta kullanır.

        static int Add4(params int[] numbers)
        {
            return numbers.Sum(); // Girilen tüm değerleri topla
           
        }

    }
}

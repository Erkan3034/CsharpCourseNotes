using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Yapmak istediğimiz işleri gruplara ayırıp bu gruplar üzerinden işlem yapmak için classları kullanırız.

            Customermanager customerManager = new Customermanager();  //bir classı kullanabilmek için onun bir örneği oluşturulmalı.
            customerManager.Add();
            customerManager.Update();

            Productmanager productManager = new Productmanager();  //bir classı kullanabilmek için onun bir örneği oluşturulmalı.
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.FirstName = "Erkan";
            customer.LastName = "Turgut";
            customer.City = "İstanbul";
            customer.Id = 1;

            //Alternative usage
            Customer customer2 = new Customer //Kayıt
            {
                Id = 2,
                FirstName = "Erkan",
                LastName = "Turgut",
                City = "İstanbul"
            };

            Console.WriteLine("Customer name is = "+customer2.FirstName); // (get= customer2.FirstName) (set= customer2.Firstname="erkan")
            Console.ReadLine();
        }



       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Program
    {
        static void Main(string[] args)
        {
            //inheritance(kalıtım)

            Customer customer = new Customer();
            customer.FirstName = "Erkan";


            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Erkan"}, 
                new Person{FirstName="Serkan"},
                new Student{FirstName="Necip"}
            };
            foreach (Person person in persons) { Console.WriteLine(person.FirstName); }
            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        //Classların tek başına anlamı vardır fakat İnterfacelerin bir anlamı yoktur


        class Customer : Person // Bir nesne sadece bir kez inheritance(miras) alınabilir. İnterfaceden farkı da budur
        {
            public string City {  get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            //Bir interface tek başına new'lenemez. Fakat implemente edildiği nesnelerle newlenebilir(student,customer,worker)

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            { 
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };
            foreach (var customerDal in customerDals) // her iki veritabanına ulaşabiliyoruz.
            {
                customerDal.Add();
                customerDal.Delete();
                Console.WriteLine();
            }

            Console.ReadLine();


        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager(); //Ekleme


            Customer customer = new Customer //Customer ekleme
            {

                Id = 2,
                FirstName = "Serkan",
                LastName = "Turgut",
                Address = "İstanbul"
            };
            manager.Add(customer);



            //Customer için Alternatif kullanım
            manager.Add(new Customer { Id = 1, FirstName = "Erkan", LastName = "Turgut", Address = "İstanbul" });



            Student student = new Student
            {
                Id = 3,
                FirstName = "Hasan",
                LastName = "Turgut",
                Departmant = "Computer Science"
            };

            manager.Add(student);
        }

        interface IPerson //Interfacelerin temel amacı oparasyon oluşturmak. //Soyut nesne
        {
            //IPersonda tanımlanmış her şeyi Customer ve Student nesnelerinde görebiliriz( :IPerson) 
            //Interfaceler yazılırken tamamen metodun imzası yazılır.
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }
        class Customer : IPerson// Somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }
        class Student : IPerson // somut nesne 
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }

        }

        class worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person) //Ekleme olayında bana customer ve Student olarak ekleme yapar çünkü ikisi de bir IPerson nesnesidir.
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
}

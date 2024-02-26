using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //Örneğin bir müşterinin özelliklerini tutmak için kullanıdğımız nesne:

        //field
        //public string FirstName;

        //property
        public int Id { get; set; }
        //public string FirstName { get; set; }

        private string _firstname; // buradaki - karakteri sistemin set yapabilmesi için Diğer değişken olan FirstName ile karıştırmaması için kullanılır.
        public string FirstName
        {
            get
            {
                return  "Mr. " + _firstname;  // Bu tarz eklme çıkarma tarzı olaylar için Encapsulation dedğimiz bu tekniği kullanırız. 
            }
            set
            {
                 _firstname = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

        //bunları classes/program.cs de classı newleyip orda kullanabiliriz.

        // Örneğin Firstname = "Erkan" dediğimzde yani = kullandığımızda SET etmiş oluruz.
    }

}

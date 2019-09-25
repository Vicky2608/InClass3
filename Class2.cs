using System;
using System.Collections.Generic;
using System.Text;

namespace InClass3
{
    class Student : Person
    {
        public string StudentNo;
        public string Grade;

        public static void Main(string[] args)
        {
            Person S = new Person();
            S.firstName = "Vignesh";
            S.lastName = "Kannan";
            S.salutation = "Mr";

            Console.WriteLine("First Name is " + S.firstName);
            Console.WriteLine("Last Name is " + S.lastName);
            Console.WriteLine("Salutation is " + S.salutation);
        }
    }
}

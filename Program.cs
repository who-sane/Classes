using System;
using System.Collections.Generic;


/*Task 1 Error, No argument given that corresponds to parameter red, couldnt solve
however all other code should function as normal.*/


namespace Cookies
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Cookies.");
            // practicing loops 
            for (int i=0; i<2; i++)
            {
                Console.WriteLine("_");
            }

            Console.WriteLine("\n To utilise the class Cookie, we have to create a new instance of it!.");
            // initialising a cookie
            Cookie yuckGreenCookie = new Cookie(40, "Very Clumpy", 31,32,12);
            Console.WriteLine("The colour code of this cookie is: " + yuckGreenCookie.Red + "," + yuckGreenCookie.Green + "," + yuckGreenCookie.Blue);

        }
    }

}


namespace PersonClass
{
    class Program : Person
    {
        static void Main(string[] args)
        {
        // Creating instance of a Person Object.
          Person person = new Person();

            person.givenName = "Hussein";
            person.surname = "Hussein";
            person.GetFullName();
            person.ID();
            person.dob = "04-05-2002";
            person.height = 185;
     

            Person person2 = new Person();

            person.givenName = "Mohamed";
            person.surname = "Bashir";
            person.GetFullName();
            person.ID();
            person.dob = "14-05-1995";
            person.height = 190;
            

            Person person3 = new Person();

            person.givenName = "Gendy";
            person.surname = "Barnsworth";
            person.GetFullName();
            person.ID();
            person.dob = "14-05-2002";
            person.height = 165;
            
            // in field one, person = a, and person 2 = b thus the function subtracts their height.
            GetHeightDifference(person.height,person2.height);

            List<string> personSubjects = new List<string>();      

            personSubjects.Add("Calculus ");
            personSubjects.Add("Chemistry");

            person.newSubjects(personSubjects);    

        
        }
    }
}

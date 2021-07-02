using System;
using System.Collections.Generic;


namespace PersonClass
{
    public class Person
    {
        public string givenName;
        public string surname;
       // using string for dob since it is easier to input and DateTime function is weird.
        public string dob;
        public int height;
       
       // TODO Creation GetFullName() function
        public void GetFullName()
        {
            Console.WriteLine("Name "  + givenName + " " + surname + " " + "  height: " + height + "cm");
        }

          public void ID()
        {
            // Assign a random ID
            Random rd = new Random();
            // upper value is exclusive so adjust to 10000 over 9999
            int identifier = rd.Next(1000,10000);
            Console.WriteLine("ID:{0}",identifier);
        }

          public void newSubjects(List<string> subjectList)
        {
            Console.WriteLine(String.Format("The subjects for " + givenName));
            foreach(string subject in subjectList) {
                Console.Write("are: {0}", subject);  
            }
        }
        public static void GetHeightDifference(int a, int b)
        {
            // height difference equation
            int heightDifferenceAmount = a - b;

            Console.WriteLine("\nHeight differential of: {0}cm", heightDifferenceAmount);
        }

    }
}
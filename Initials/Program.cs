using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your full name?");
            string fullName = Console.ReadLine();
            string initial = Initials(fullName);
            Console.WriteLine(initial);
            Console.ReadLine();
        }

        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
        public static string Initials(string fullName)
        {

            string[] fullNameArray = fullName.Split(' ');
            char[] firstNameChar;
            firstNameChar = fullNameArray[0].ToCharArray();
            char[] secondNameChar;
            secondNameChar = fullNameArray[1].ToCharArray();
            char[] lastNameChar;
            lastNameChar = fullNameArray[2].ToCharArray();
            

            char firstInitial = firstNameChar[0];
            char secondInitial = secondNameChar[0];
            char lastNameInitial = lastNameChar[0];
            string initialF = firstInitial.ToString(); 
            string initialS = secondInitial.ToString();
            string initialL = lastNameInitial.ToString();
            string initials = initialF + initialS + initialL;
            initials = initials.ToUpper();
            return initials;
        }
      
    }
}

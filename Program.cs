using System.Globalization;

namespace validation_and_verification_
{
    internal class Program
    {
        static int rangeCheck(int age)
        {
            while (!(age >= 0 && age <= 150))
            {
                Console.WriteLine("age not in range please re enter a valid age ");
                Console.WriteLine("enter your age>>");
                age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Range check validated");
            return age;
        }
        static bool lengthCheck(string name)
        {
            if (name.Length>= 2 && name.Length<= 748)
            {
                Console.WriteLine("Lenth of name is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Length of name is not valid");
                return false;
            }
        }
        static void TypeCheck(string name) 
        {
            if (name is string) 
            {
                Console.WriteLine("The inputted name is a string data type");
            }
        }

        static string PresenceCheck(string name)
        {
            while (name == "")
            {
                Console.WriteLine("Name was left blank");
                Console.WriteLine("Enter your name>>");
                name = Console.ReadLine();
            }
            return name;
        }
        static bool LogIn(string username, string password) 
        {
            if (username == "Mr Milton" && password == "Pass1234")
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name>>");
            string name= Console.ReadLine();
            Console.WriteLine("enter your age>>");
            int age = Convert.ToInt32(Console.ReadLine());
            age = rangeCheck(age);
            TypeCheck(name);
            name = PresenceCheck(name);
            while (lengthCheck(name)!= true)
            {
                Console.WriteLine("Enter your name>>");
                name = Console.ReadLine();
            }
            string username = name;
            Console.WriteLine("enter your password>>");
            string password = Console.ReadLine();
            bool verfied = LogIn(username, password);
            while (!verfied) 
            {
                Console.WriteLine("Enter your username>>");
                username = Console.ReadLine();
                Console.WriteLine("enter your password>>");
                password = Console.ReadLine();
                verfied = LogIn(username, password);
            }

        }
    }
}

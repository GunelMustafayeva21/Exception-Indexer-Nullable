using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWorkPasswordCheck.Models;

namespace ClassWorkPasswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username for Checking ");
            string Username = Console.ReadLine();


            Console.WriteLine("Enter Password for Checking ");
            string Password = Console.ReadLine();


            User user = new User(Username, Password);

            Console.WriteLine(("Print Password of user"));
            Console.WriteLine(user.Password);
        }
    }
}

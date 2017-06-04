//This is the program of hashing with collison resolution technique. Linear probing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashing hs = new Hashing();  // created object of Hashing class to access its methods
            int userValue = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Select from following option");
                Console.WriteLine("1. Add numbers");
                Console.WriteLine("2. Display saved phone numbers");
                Console.WriteLine("3. Exit");
                userValue = int.Parse(Console.ReadLine());
                switch (userValue)
                {

                    case 1:
                        hs.AddNumbers();
                        break;

                    case 2:
                        hs.Display();
                        break;

                    case 3:
                        break;

                    default:
                        throw new NotImplementedException();
                }
            } while (userValue != 3);
        }
    }
}

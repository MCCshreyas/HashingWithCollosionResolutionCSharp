using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    class Hashing
    {
        /*
         * Our hash table size is 10 and of type double
         * */

        double[] phoneNumbers = new double[10];    
        int Id = 0, hashValue = 0;
        
        public void AddNumbers()
        {
            Console.WriteLine("Enter the Id of the student");
            Id = int.Parse(Console.ReadLine());
            hashValue = Id % 10;                                               //calculated hash value from hash function X mod 10
            Console.WriteLine("The hash value generated is " + hashValue);

            /* We are checking is there any previous value store on that index position of hash table
             * 
             * */
            if (phoneNumbers[hashValue] != 0)
            {
                /* If there is any previous value then collison has happened.
                 * 
                 * */
                Console.WriteLine("The collison has happened. We will save the value to the next empty location.");
                while (phoneNumbers[hashValue] != 0)
                {
                    hashValue++;              // we will increase our hash value by 1
                    if (hashValue >= 9)
                    {
                        Rescue();            // in case hash value gets greater or equal to 9.  
                        return;
                    }
                }
                Console.WriteLine("The new hash value generated is " + hashValue);
                Console.WriteLine("Now enter the phone number of the student");
                phoneNumbers[hashValue] = double.Parse(Console.ReadLine());
                Console.WriteLine("Phone number added sucessfully");
            }
            else
            {
                Console.WriteLine("Now enter the phone number of the student");
                phoneNumbers[hashValue] = double.Parse(Console.ReadLine());
                Console.WriteLine("Phone number added sucessfully");
            }
            
        }

        public void Rescue()
        {
            hashValue = 0;
            while (phoneNumbers[hashValue] != 0)
            {
                hashValue++;
                if (hashValue >= 9)
                {
                    Rescue();
                }
            }
            
            Console.WriteLine("The new hash value generated is " + hashValue);
            Console.WriteLine("Now enter the phone number of the student");
            phoneNumbers[hashValue] = double.Parse(Console.ReadLine());
            Console.WriteLine("Phone number added sucessfully");
        }

        public void Display()
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                Console.WriteLine("PhoneNumbers[{0}] = {1} ", i, phoneNumbers[i]); 
            }
        }
    }
}

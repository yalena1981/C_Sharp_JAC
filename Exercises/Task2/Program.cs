using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    class Program
    {
        public static int Menu()
        {
            Console.WriteLine(@"
        1. Add Airport
        2. List all airports
        3. Find nearest airport by code (preferably using LINQ)
        4. Find airport's elevation standard deviation (using LINQ)
        5. Change log delegates
        0. Exit");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            return userChoice;
        }

        static void Main(string[] args)
        {
            int choice = Menu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK6
{
    class Program
    {
        static void Main(string[] args)
        { int userInput;
            double sum = 0;

            Console.Write("How many things would you like to inventory? >> ");
            while (int.TryParse(Console.ReadLine(), out userInput)==false || userInput<=0)
                {
                    Console.Write("Please try again: ");
                 }

            Console.WriteLine();//blank

            //build empty array limited by user input
            Thing[] inventory = new Thing[userInput];
            for(int i = 0; i<inventory.Length; i++ )  //loop to collect info and put in each index
            {
                Console.Write("Please enter Thing {0} name: ", i+1 );

                string name = Console.ReadLine();

                Console.Write("Please enter Thing {0} price: $", i+1);

                double pricePerPart;
                while (double.TryParse(Console.ReadLine(), out pricePerPart)==false || pricePerPart<=0)
                     { Console.WriteLine("Try again: "); }

                Console.Write("Please enter Thing {0} quantity: ", i+1);
                int quantity;
                while (int.TryParse(Console.ReadLine(), out quantity)==false || quantity<=0)
                      { Console.WriteLine("Try again: "); }

                //build thing objects for each index using user information
                inventory[i] = new Thing(name, pricePerPart, quantity);
                Console.WriteLine();//blank
             }

            Array.Reverse(inventory);

            for (int i=0; i<inventory.Length; i++)
            {
                sum= sum + inventory[i].TotalCost();

                inventory[i].PrintInfo();

            }

            Console.WriteLine();

            Console.WriteLine("The total cost of the inventory is {0:C}.", sum);

            Console.ReadLine();
        }//end of main
    }
}

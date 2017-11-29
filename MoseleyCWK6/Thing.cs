using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK6
{
    class Thing
    {
        //private data members
        private string name;
        private double pricePerPart;
        private int quantity;

        //constructors

        public Thing ()
        {
            name = "Thing default";
            pricePerPart = 5.0;
            quantity = 1;
        }

        public Thing(string name, double pricePerPart, int quantity)
        {
            this.name = name;//this.variable= value passed in through perameters
            this.pricePerPart = pricePerPart;
            this.quantity = quantity;
        }

        //properties get/set
        public string NAME
        {
            get { return name; }

            set { name = value; }
        }

        public double PRICEPERPART
        {
            get { return pricePerPart; }

            set { pricePerPart = value; }
        }

        public int QUANTITY
        {
            get { return quantity; }

            set { quantity = value; }
        }

        //methods

        public double TotalCost()
        {
            double totalCost;
            totalCost = quantity * pricePerPart;
            return totalCost;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} inventory costs {1:C}", name, TotalCost());
        }

    }//end of class THING
}

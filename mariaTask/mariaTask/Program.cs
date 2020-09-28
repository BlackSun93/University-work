using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mariaTask
{
    class Program
    {

        static void Main(string[] args)
        {
            for (; ; ) //loop forever
            {
                double priceStrawb, raspQuant, strawbQuant, bananabQuant, orangebQuant; //declare variables as doubles
                Console.WriteLine("Please enter the price of strawberries: ");
                priceStrawb = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the quantitiy of bananas: ");
                bananabQuant = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the quantitiy of oranges: ");
                orangebQuant = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the quantitiy of raspberries: ");
                raspQuant    = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the quantitiy of strawberries: ");
                strawbQuant  = Convert.ToDouble(Console.ReadLine());
  
                double finish = FruitShop(priceStrawb, bananabQuant , orangebQuant ,raspQuant, strawbQuant ); //stores total in variable finish
                Console.WriteLine("");
                Console.WriteLine("The total is:");
                Console.WriteLine("");
                Console.WriteLine(finish);
            }
        }

       static double FruitShop (double price, double quantBan, double quantOrg, double quantRas, double quantStr) //price of raspberries, quantity of rasperries, strawberries, orange, banana
        {
            double priceStrawb  = price; //strawb price is given in input
            double priceRasb    = priceStrawb /2; // raspberry is half the price of strawberry 
            double priceOranges = priceRasb - (0.4 * priceRasb); // 1 orange is 40% the calculated price of raspberries
            double priceBanana  = priceRasb - (0.8 * priceRasb); //banana is 80% the price of rasp

            double totalStrawb  = price * quantStr; //price * quantity gives each fruit's total
            double totalRasb    = priceRasb * quantRas;
            double totalOrange  = priceOranges * quantOrg;
            double totalBanana  = priceBanana * quantBan;
      
            double totalAmount = totalBanana + totalOrange + totalRasb + totalStrawb; //calculates total
            return totalAmount; //returns total
        }
    }
}

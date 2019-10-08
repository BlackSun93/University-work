using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMade;
            int attendants;
            int lengthOfReport ;
            int paper = 500;
            double tonerCartridgesNeeded;//= amountMade / 1200;
            double costReam, costCart;
            double paperTotal;
            double cartTotal;

            Console.WriteLine("please enter how many people are attending");
            attendants = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter how many pages your report is");
            lengthOfReport = Convert.ToInt32(Console.ReadLine());

            amountMade = (attendants + 5) * lengthOfReport; //attendants + 5 extra, finds how many pages are needed
            double totalReamsNeeded = Math.Ceiling(amountMade / Convert.ToDouble(paper));
            // totalReamsNeeded = System.Math.Ceiling(totalReamsNeeded); //rounds reams up as they have to be bought in stacks of 500

            Console.WriteLine("You need {0} pages", amountMade);

            tonerCartridgesNeeded = amountMade / 1200; //1 cartridge lasts for 1200 pages
            tonerCartridgesNeeded = Math.Ceiling(tonerCartridgesNeeded); // rounds up

            Console.WriteLine("you need {0} toner cartridges and {1} reams of paper", tonerCartridgesNeeded, totalReamsNeeded);

            Console.WriteLine("Please enter the cost of each ream of paper:");
            costReam = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the cost per toner cartridge:");
            costCart = Convert.ToDouble(Console.ReadLine());

            if (totalReamsNeeded >= 5)
            {
                paperTotal = (costReam / 1.1) * totalReamsNeeded;
                Console.WriteLine("As over 5 reams of paper have been ordered, a discount of {0} has been applied. ", System.Math.Round(costReam / 1.1, 2)); //calculates discount and rounds to 2 decimal points
            }
            else
            {
                paperTotal = costReam * totalReamsNeeded;
            }

            if (tonerCartridgesNeeded >= 5)
            {
                cartTotal = (costCart / 1.1) * tonerCartridgesNeeded;
                Console.WriteLine("AS over 5 cartridges are needed, a discount of {0} has been applied", System.Math.Round(costCart / 1.1, 2));
            }
            else
            {
                cartTotal = costCart * tonerCartridgesNeeded;
            }
            double finalCost = paperTotal + cartTotal;
            Console.WriteLine("The paper will cost £ {0} and the cartridges £ {1}. the total cost is {2}", Math.Round(paperTotal, 2), Math.Round(cartTotal, 2), Math.Round(finalCost, 2));

            Console.ReadLine();
        }
    }
}



/* 
    Create a program to solve this problem.
    Test this problem with the following data: The report is 140 pages long, there will be 25 people at the meeting.
    Assuming that the printer is old and inefficient, modify the program to calculate how many toner cartridges are also required if each one
    lasts 1200 pages.
    Modify the program to calculate the total purchase cost, taking the cost per ream and per cartridge as user input.
    The local print store offers a 10% discount on bulk purchases of 5 or more reams of paper. It offers the same discount on toner cartridges, 
    but the two offers cannot be combined (i.e. you do not get a discount on 3 reams and 2 cartridges). 
    Modify the program to automatically account for this discount - it should also inform the user when a discount has been included.
*/

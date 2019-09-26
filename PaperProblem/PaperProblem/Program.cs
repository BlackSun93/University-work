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
            //int attendants = 25;
            int lengthOfReport = 140;
            int paper = 500;
            double tonerCartridgesNeeded;//= amountMade / 1200;
            double costReam, costCart;
            double paperTotal;
            double cartTotal;


            amountMade = (25 + 5) * lengthOfReport; //25 attendants + 5 extra, finds how many pages are needed
            double totalReamsNeeded = System.Math.Ceiling( amountMade / Convert.ToDouble(paper));
           // totalReamsNeeded = System.Math.Ceiling(totalReamsNeeded); //rounds reams up as they have to be bought in stacks of 500

            tonerCartridgesNeeded = amountMade / 1200; //1 cartridge lasts for 1200 pages
            tonerCartridgesNeeded = System.Math.Ceiling(tonerCartridgesNeeded); // rounds up

            Console.WriteLine("Please enter the cost of each ream of paper:");
            costReam = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the cost per toner cartridge:");
            costCart = Convert.ToDouble(Console.ReadLine());

            if (totalReamsNeeded >= 5)
            {
                paperTotal = (costReam / 1.1) * totalReamsNeeded;
                Console.WriteLine("As over 5 reams of paper have been ordered, a discount of {0} has been applied. ", costReam / 1.1);
            }
            else
            {
                paperTotal = costReam * totalReamsNeeded;
            }

            if (tonerCartridgesNeeded >= 5)
            {
                cartTotal = (costCart / 1.1) * tonerCartridgesNeeded;
                Console.WriteLine("AS over 5 cartridges are needed, a discount of {0} has been applied", costCart / 1.1);
            }
            else
            {
                cartTotal = costCart * tonerCartridgesNeeded;
            }
            double finalCost = paperTotal + cartTotal;
            Console.WriteLine("You need {0} reams of paper and {1} amount of cartridges. The paper will cost £ {2} and the cartridges £ {3}. the total cost is {4}", totalReamsNeeded, tonerCartridgesNeeded, Math.Round(paperTotal, 2), Math.Round(cartTotal, 2), Math.Round(finalCost, 2));

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
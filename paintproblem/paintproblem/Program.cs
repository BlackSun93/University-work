using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomW = 0, roomL = 0, roomH = 0;
            double winL, winH;
            int winAmount;
            double totalWin = 0;
            double totalRoom, totalToPaint;

            Console.WriteLine("Hello! Please enter the width, length and height of the room you're painting:");
            Console.WriteLine("Enter the width in feet:");
            roomW = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length in feet:");
            roomL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height in feet:");
            roomH = Convert.ToDouble(Console.ReadLine());

            totalRoom = (2*((roomH * roomW) + (roomH * roomL) + (roomL * roomW))) - (roomL * roomW); //not painting the floor so take that face away
            Console.WriteLine("the room's surface area to paint is {0}", totalRoom);

            Console.WriteLine("How many windows are there?");
                winAmount = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i < winAmount + 1; i++) //starts at 1 so 1st window isnt shown as window 0, winAmount increased accordingly
            {
                Console.WriteLine("Please enter the height of window {0} in feet:", i);
                winH = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the length of window {0} in feet :", i);
                winL = Convert.ToDouble(Console.ReadLine());

                totalWin = totalWin + (winL * winH); //only asks for height and length as window is a cutout on one face (i.e its 2d)
            }

            Console.WriteLine("the total surface area of the windows is {0}", totalWin);
            totalToPaint = totalRoom - totalWin;

            Console.WriteLine("the total area to paint is {0}", totalToPaint);

            double HowManyGallons = totalToPaint / 100; //1 gallon covers 100ft^2
            Console.WriteLine("You need {0} gallons to paint the room, minus the windows and minus the floor. Thanks", HowManyGallons);

            Console.ReadLine();
        }
    }
}

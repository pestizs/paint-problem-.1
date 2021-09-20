using System;

namespace paint_problem_._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // How much paint needed?
            // Paint capacity 100 ft²/gallon

            string Inputheigth;
            string Inputlength;
            string Inputwidth;
            string InputwindowWidth;
            string InputwindowHeigth;
            double heigth;
            double length;
            double width;
            double windowWidth;
            double windowHeigth;

            double ceiling;
            double wall1;
            double wall2;
            double window;

            double paintPerGallon = 100;
            double finalPaint;

            Console.WriteLine("Hi. This Calculator will tell you how much paint you will need for a 1 window room after you gave the dimensions.");
            Console.WriteLine("\n");
            Console.Write("Please Enter the Heigth of the Room in ft:");
            Inputheigth = Console.ReadLine();
            Console.Write("Please Enter the Length of the Room in ft:");
            Inputlength = Console.ReadLine();
            Console.Write("Please Enter the Width of the Room in ft:");
            Inputwidth = Console.ReadLine();
            Console.Write("Please Enter the Width of the window in ft:");
            InputwindowWidth = Console.ReadLine();
            Console.Write("Please Enter the Heigth of the window in ft:");
            InputwindowHeigth = Console.ReadLine();

            heigth = Convert.ToDouble(Inputheigth);
            length = Convert.ToDouble(Inputlength);
            width = Convert.ToDouble(Inputwidth);
            windowWidth = Convert.ToDouble(InputwindowWidth);
            windowHeigth = Convert .ToDouble(InputwindowHeigth);

            ceiling = length * width;
            wall1 = length * heigth;
            wall2 = width * heigth;
            window = windowWidth * windowHeigth;

            finalPaint = (ceiling + wall1 + wall2 - window) / paintPerGallon;
            Console.WriteLine("You will need " + finalPaint + " ft² of paint.");
            Console.ReadLine();
        }
    }
}

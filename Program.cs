using System;

namespace _2_4_Lab_Maskevich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            int myFirstNumber = 19;
            int mySecondNumber = 244;
            Console.WriteLine(myFirstNumber * mySecondNumber);

            string myText = "Some Text";
            Console.WriteLine(myText + mySecondNumber);

            string moreText = "Goes Here";
            Console.WriteLine(myText + moreText);

            string color1 = "Yellow";
            string color2 = "Red";

            bool isYellow = true;
            bool isGreen = false;

            Console.WriteLine(isYellow);
            Console.WriteLine(color2);
            Console.WriteLine(isGreen);

            double numbers;

            numbers = mySecondNumber / myFirstNumber;

            Console.WriteLine(numbers);

            numbers = mySecondNumber / (double)myFirstNumber;
            Console.WriteLine(numbers);

            Console.WriteLine("Breakpoint Here");

            string textToNumber = "80473";

            int results = 99 * int.Parse(textToNumber);
            Console.WriteLine(results);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);






        }
    }
}

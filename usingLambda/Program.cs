using System;

namespace usingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number");
            double inputone = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number");
            double inputtwo = double.Parse(Console.ReadLine());
            // adds
            var addnum = (double num1, double num2) => num1 + num2; 
            Console.WriteLine(addnum(inputone, inputtwo));
            // mult
            var multnum = (double num1, double num2) => num1 * num2;
            Console.WriteLine(multnum(inputone, inputtwo));
            // returns smaller
            var smallernum = (double num1, double num2) =>
            {
                if (num1 < num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            };
            Console.WriteLine(smallernum(inputone, inputtwo));
        }
    }
}

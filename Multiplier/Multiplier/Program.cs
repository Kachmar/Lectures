using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("I wanna calculate something for you, please input the first digit");
        string firstInput = Console.ReadLine();
        Console.WriteLine("Thank’s and another digit please!");
        string secondInput = Console.ReadLine();
        int firstDigit;
        int secondDigit;
        if (int.TryParse(firstInput, out firstDigit) && int.TryParse(secondInput, out secondDigit))
        {
            if (firstDigit <= 10 && firstDigit > 0 && secondDigit <= 10 && secondDigit > 0)
            {
                int result = firstDigit * secondDigit;
                //String concatination
                //Console.WriteLine("Here you are: " + result + " :).");
                //Extrapolation
                //Console.WriteLine($"Here you are: {result}");
                {
                    Console.WriteLine("Sorry, I support only digits from 0 to 10 :(");
                }
            }
            else
            {
                Console.WriteLine("Sorry, I do not now how to multiply chars :(.");
            }

            Console.ReadLine();
        }
    }
}
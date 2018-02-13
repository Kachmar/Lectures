using System;
namespace ClassesSample
{
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Acceptdetails();
            rectangle.Display();
            Console.ReadLine();
            StaticClass staticClass = new StaticClass();
            staticClass.GetGreeting();
        }
    }
}
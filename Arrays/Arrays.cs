using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Arrays
    {
        static void Main(string[] args)
        {
            //Collect names for 50 attendees

            //string attendee1 = Console.ReadLine();
            //string attendee2 = Console.ReadLine();
            //string attendee3 = Console.ReadLine();
            //string attendee4 = Console.ReadLine();
            //string attendee5 = Console.ReadLine();
            //string attendee6 = Console.ReadLine();
            //string attendee7 = Console.ReadLine();
            //string attendee8 = Console.ReadLine();
            //string attendee9 = Console.ReadLine();
            //string attendee10 = Console.ReadLine();
            //string attendee11 = Console.ReadLine();
            //string attendee12 = Console.ReadLine();
            //string attendee13 = Console.ReadLine();
            //string attendee14 = Console.ReadLine();
            //string attendee15 = Console.ReadLine();
            ////....
            //string attendee50 = Console.ReadLine();










            //how to achieve same result with array:

            //string[] attendees = new string[50];
            //for (int i = 0; i < 5; i++)
            //{
            //    attendees[i] = Console.ReadLine();
            //}
            //Console.WriteLine(attendees[2]);



















            ////////////////////////////////
            //string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday" };
            //foreach (string weekDay in weekDays)
            //{
            //    Console.WriteLine(weekDay);
            //}

            //index out of range
            //Console.WriteLine(weekDays[6]);

            //string[] nullValues = new string[2];
            //Console.WriteLine(nullValues[1]);
            //string nullValue = null;

            //Task for the students
            //Print out the number of values that are greater than zero in next array:{ -4, -3, 0, 1, 2, -2, -1, 3, 4 };



















            //int[] numbers = { -4, -3, 0, 1, 2, -2, -1, 3, 4 };
            //int result = 0;
            //foreach (int number in numbers)
            //{
            //    if (number > 0)
            //    {
            //        result++;
            //    }
            //}
            //Console.WriteLine($"Number of elements greater than zero: {result}");


            //two dimension array
            //string[,] personalData =
            //    {
            //        { "Petro", "Budyak", "Lviv" },
            //        { "Ivan", "Pobyvan", "Kharkiv" },
            //        { "Olena", "Ivanchenki", "Kolymyja"}
            //    };
            //Console.WriteLine(personalData[0, 2]);

            //for (int i = 0; i < personalData.GetLength(0); i++)
            //{
            //    Console.WriteLine($"{personalData[i, 0]} {personalData[i, 1]} from {personalData[i, 2]}");
            //}

            //Console.ReadLine();


            //Array of arrays
            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] { 1, 2 };
            //numbers[1] = new int[] { 1, 2, 3 };
            //numbers[2] = new int[] { 1, 2, 3, 4, 5 };

            //foreach (int[] row in numbers)
            //{
            //    foreach (int number in row)
            //    {
            //        Console.Write($"{number} \t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write($"{numbers[i][j]} \t");
            //    }
            //    Console.WriteLine();
            //}




            //Task for students
            // Please reverse next array:  { -4, -3, -2, -1,0, 1, 2, 3, 4 }


















            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //int length = numbers.Length;
            //int halfOfArrayLength = length / 2;
            //int temp;
            //for (int i = 0; i < halfOfArrayLength; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[length - i - 1];
            //    numbers[length - i - 1] = temp;
            //}
            //foreach (int i in numbers)
            //{
            //    Console.Write($"{i} \t");
            //}

            Array.Reverse(numbers);
            Console.WriteLine();
            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }

            Console.ReadLine();
        }
    }
}
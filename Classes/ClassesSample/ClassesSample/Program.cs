using System;
namespace ClassesSample
{
    class Student
    {   //Fields
        public int Age;
        public string Name;
        public string LastName;

        public string GetInfo()
        {
            return $"Here comes the student {Name} {LastName} aged {Age}.";
        }

        public bool IsOlder(Student studentToCompare)
        {
            return Age < studentToCompare.Age;
        }
    }

    class ScopeSample
    {
        Student classScope = new Student();

        public void Demo()
        {
            MethodScopeDemo();
            methodScopeStudent.Age = 4;
            classScope.Age = 6;
        }

        void MethodScopeDemo()
        {
            Student methodScopeStudent = new Student();
            // this will be garbage collected.
        }
    }

    class ExecuteRectangle
    {
        Student classScope = new Student();

        static void Main(string[] args)
        {
            string student1Name = "Oleh";
            string student1LastName = "Vynnyk";
            int student1Age = 19;

            string student2Name = "Bob";
            string student2LastName = "Sinclair";
            int student2Age = 44;

            string student3Name = "Michael";
            string student3LastName = "Poplavskii";
            int student3Age = 21;

            string student4Name = "Iryna";
            string student4LastName = "Bilyk";
            int student4Age = 22;

            Student student1 = new Student { Name = "Oleh", LastName = "Vynnyk", Age = 19 };
            Student student2 = new Student();
            student2.Name = "Bob";
            student2.LastName = "Sinclair";
            student2.Age = 44;
            Student student3 = new Student { Name = "Michael", LastName = "Poplavskii", Age = 21 };
            Student student4 = new Student { Name = "Iryna", LastName = "Bilyk", Age = 22 };

            Console.WriteLine($"Here comes the student {student1.Name} {student1.LastName} aged {student1.Age}.");
            Console.WriteLine($"Here comes the student {student2.Name} {student2.LastName} aged {student2.Age}.");
            Console.WriteLine($"Here comes the student {student3.Name} {student3.LastName} aged {student3.Age}.");
            Console.WriteLine($"Here comes the student {student4.Name} {student4.LastName} aged {student4.Age}.");


            //Console.WriteLine(student1.GetInfo());
            //Console.WriteLine(student2.GetInfo());
            //Console.WriteLine(student3.GetInfo());
            //Console.WriteLine(student4.GetInfo());

            // Lets focus on what is reference to an object. Refernce is just an adress pointing to certain part of memory, 
            // where actually the object lives

            Student studentReference = student1;
            studentReference.Age = 111;
            Console.WriteLine($"Magic of reference: Age of Oleh Vynny is now {student1.Age}");


            //Lets take a look at garbage collection
            //But first of all lets look at scopes
            // Look into the class
            ScopeSample scopeSample = new ScopeSample();
            scopeSample.Demo();
        }


        //static void Sub()
        //{
        //    Rectangle rectangle = new Rectangle();
        //    rectangle.Acceptdetails();
        //    rectangle.Display();
        //    Console.ReadLine();
        //    StaticClass staticClass = new StaticClass();
        //    staticClass.GetGreeting();
        //}
    }
}
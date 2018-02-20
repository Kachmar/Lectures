using System;
namespace ClassesSample
{
    class Student
    {   //Fields
        public int Age;
        public string Name;
        public string LastName;
        // public DateTime CreationTime;
        private DateTime createTime;
        public DateTime CreationTime
        {
            get
            {
                return this.createTime;
            }
            set
            {
                if (this.createTime <= value)
                {
                    this.createTime = value;
                }
            }
        }
        //public DateTime CreationTime
        //{
        //    get
        //    {
        //        return createTime;
        //    }
        //    set
        //    {
        //        if (this.createTime <= value)
        //        {
        //            this.createTime = value;
        //        }
        //    }
        //}
        public Student(string name, string lastName, int age) : this()
        {
            this.Age = age;
            this.LastName = lastName;
            this.Name = name;
        }

        public Student()
        {
            this.CreationTime = DateTime.Now;
        }

        private string GetInfo()
        {
            return $"Here comes the student {Name} {LastName} aged {Age}.";
        }

        public bool IsOlder(Student studentToCompare)
        {
            return Age < studentToCompare.Age;
        }

        public bool IsOlder(int age)
        {
            return Age < age;
        }

        public void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }

    class ScopeSample
    {
        Student classScope = new Student();

        private int blockScopeVariable;

        public void Demo()
        {
            MethodScopeDemo();
            //methodScopeStudent.Age = 4;
            int blockScopeVariable;
            if (true)
            {
                blockScopeVariable = 5;
            }
            blockScopeVariable = 6;
            classScope.Age = 6;
            classScope = null;
            Console.WriteLine(classScope.Age);
        }

        void MethodScopeDemo()
        {
            Student methodScopeStudent = new Student();
            // this will be garbage collected.
            blockScopeVariable = 4;
        }
    }

    class ExecuteRectangle
    {
        //Student classScope = new Student();

        static void Main(string[] args)
        {
            //    string student1Name = "Oleh";
            //    string student1LastName = "Vynnyk";
            //    int student1Avarage = 3;
            //    int student1Age = 19;

            //    string student2Name = "Bob";
            //    string student2LastName = "Sinclair";
            //    int student2Avarage = 4;
            //    int student2Age = 44;

            //    string student3Name = "Michael";
            //    string student3LastName = "Poplavskii";
            //    int student3Age = 21;

            //    string student4Name = "Iryna";
            //    string student4LastName = "Bilyk";
            //    int student4Age = 22;

            //Student student1 = new Student { Name = "Oleh", LastName = "Vynnyk", Age = 19 };
            //Student student2 = new Student();
            //student2.Name = "Bob";
            //student2.LastName = "Sinclair";
            //student2.Age = 44;
            //Student student3 = new Student { Name = "Michael", LastName = "Poplavskii", Age = 21 };
            //Student student4 = new Student { Name = "Iryna", LastName = "Bilyk", Age = 22 };

            //Console.WriteLine($"Here comes the student {student1.Name} {student1.LastName} aged {student1.Age}.");
            //Console.WriteLine($"Here comes the student {student2.Name} {student2.LastName} aged {student2.Age}.");
            //Console.WriteLine($"Here comes the student {student3.Name} {student3.LastName} aged {student3.Age}.");
            //Console.WriteLine($"Here comes the student {student4.Name} {student4.LastName} aged {student4.Age}.");


            //Console.WriteLine(student1.GetInfo());
            //Console.WriteLine(student2.GetInfo());
            //Console.WriteLine(student3.GetInfo());
            //Console.WriteLine(student4.GetInfo());

            // Lets focus on what is reference to an object. Reference is just an address pointing to a certain part of memory, 
            // where actually the object lives

            //Student studentReference = student1;
            //studentReference.Age = 111;
            //Console.WriteLine($"Magic of reference: Age of Oleh Vynnyk is now {student1.Age}");


            //Lets take a look at garbage collection
            //But first of all lets look at scopes
            // Look into the class
            //ScopeSample scopeSample = new ScopeSample();
            //scopeSample.Demo();

            //Lets now look at methods. Their parameters and return values
            //Student student1 = new Student { Name = "Michael", LastName = "Poplavskii", Age = 21 };
            //student1.PrintInfo();
            //Student student2 = new Student { Name = "Iryna", LastName = "Bilyk", Age = 22 };
            //if (student1.IsOlder(student2))
            //{
            //    Console.WriteLine($"{student2.Name} is older than {student1.Name}");
            //}

            //Lets look at the constructors
            //Student student1 = new Student { Name = "Michael", LastName = "Poplavskii", Age = 21 };
            //Student student2 = new Student { Name = "Iryna", LastName = "Bilyk", Age = 22 };

            //Student student1 = new Student("Michael", "Poplavskii", 21);
            //Student student2 = new Student("Iryna", "Bilyk", 22);

            //Console.WriteLine(student1.CreationTime.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
            //Console.WriteLine(student2.CreationTime.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));

            //Lets take a look at access modifiers private and public
            // And we want to hide the GetInfo method and make CreateTime only become newer...properties :)
            //Student testStudent = new Student();
            //testStudent.CreationTime = new DateTime(1994, 3, 3);
            //testStudent.CreationTime = new DateTime(2020, 3, 3);
            //Console.WriteLine(testStudent.CreationTime);

            //Console.WriteLine(StaticClass.GetGreeting());
            //Console.WriteLine(RegularClass.GetStaticGreeting());
            //Console.WriteLine(new RegularClass().GetGreeting());

            //lets dive into Structs
            //BookStruct bookStruct1;
            //bookStruct1.name = "Harry Poter";
            //bookStruct1.author = "Unknown";
            //bookStruct1.year = 2006;
            //BookStruct bookStruct2 = bookStruct1;
            //bookStruct2.name = "Changed";
            //Console.WriteLine(bookStruct1.name);
            Console.ReadLine();
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
    struct BookStruct
    {
        public string name;
        public string author;
        public int year;

        public void Info()
        {
            Console.WriteLine($"Book '{name}' (author {author}) published in {year}.");
        }
    }

    class ThisSample
    {
        private string name;

        public ThisSample()
        {
            //some logic
        }

        public int Age { get; set; }

        public ThisSample(string name) : this()
        {
            this.name = name;
            this.Age = 56;
        }

    }
}
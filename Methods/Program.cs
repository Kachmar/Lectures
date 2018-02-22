using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodDemo methodDemo = MethodDemo.FactoryMethodWithParamsAndReturnValue(5);

            int x = 10;
            int y = 15;
            methodDemo.AdditionByRef(ref x, y);
            ChangeCodeInRefObject(methodDemo);
            methodDemo.overLoadDemoMethod();
            string input = Console.ReadLine();
            int inputInt;
            if (int.TryParse(input, out inputInt))
            {
                Console.WriteLine("Int received :)");
            }
            else
            {
                Console.WriteLine("Not and integer :(");
            }
            Factorial(15);


            Console.WriteLine(x);

            Console.ReadLine();
        }
        static void ChangeCodeInRefObject(MethodDemo methodDemo)
        {
            methodDemo.code = 777;
        }

        static int Factorial(int x)
        {
// 0! = 1
//1! = 1
//2! = 1·2 = 2
//3! = 1·2·3 = 6
//4! = 1·2·3·4 = 24
//5! = 1·2·3·4·5 = 120
//6! = 1·2·3·4·5·6 = 720
//7! = 1·2·3·4·5·6·7 = 5040
//8! = 1·2·3·4·5·6·7·8 = 40320
//9! = 1·2·3·4·5·6·7·8·9 = 362880
//10! = 1·2·3·4·5·6·7·8·9·10 = 3628800
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        class MethodDemo
        {
            public int code;
            public void MethodWithoutParametersAndReturnValue()
            {

            }

            public static MethodDemo FactoryMethodWithParamsAndReturnValue(int code)
            {
                MethodDemo methodDemo = new MethodDemo();
                methodDemo.code = code;
                return methodDemo;
            }

            public void AdditionByRef(ref int x, int y)
            {
                x += y;
            }

            public void overLoadDemoMethod()
            {
                overLoadDemoMethod(11, 10);
            }

            public void overLoadDemoMethod(int x)
            {
                overLoadDemoMethod(x, 10);
            }

            public void overLoadDemoMethod(int x, int y)
            {
                Console.WriteLine($"Overload called with params: {x} and {y}");
            }
            public int ParamsAddition(params int[] values)
            {
                int result = 0;
                foreach (var value in values)
                {
                    result = result + value;
                }
                return result;
            }

            public void OutDemo(out int value)
            {
                value = 5;
            }
        }
    }
}

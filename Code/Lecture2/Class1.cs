using System;

namespace Lecture2
{
    public class Program
    {

        static void Main(string[] args)
        {
            BasicArithmeticOperators();
            PrefixAndPostfixIncrementDecrement();
            ComparisonOperators();
            LogicalOperators();
            FloatingPointArithmeticExample();
            IfElseIfElseExample();
            SwitchStatementExample();
            ForLoopExample();
            WhileLoopExample();
            MethodExample();
            IntegerArrayExample();
            StringToCharArrayExample();
            SortExample();
            ScopeExample1RepetedDeclaration();
            ScopeExample2AccessingVariableOutsideScope();
            Console.Read();
        }

        static void BasicArithmeticOperators()
        {
            //Let's define
            int m = -6;
            int n = 4;
            int k;
            float x = -6;
            float y = 4;
            float z;

            Console.WriteLine("Multiplication");
            k = m * n;
            z = x * y;
            Console.WriteLine(string.Format("   m = {0}, n = {1}, k =  m * n = {2};", m, n, k));
            Console.WriteLine(string.Format("   x = {0}, y = {1}, z =  x * y = {2};", x, y, z));
            Console.ReadKey();
            Console.WriteLine("Division");
            k = m / n;
            z = x / y;
            Console.WriteLine(string.Format("   m = {0}, n = {1}, k =  m / n = {2};", m, n, k));
            Console.WriteLine(string.Format("   x = {0}, y = {1}, z =  x / y = {2};", x, y, z));
            Console.ReadKey();
            Console.WriteLine("Reminder");
            k = m % n;
            z = x % y;
            Console.WriteLine(string.Format("   m = {0}, n = {1}, k =  m % n = {2};", m, n, k));
            Console.WriteLine(string.Format("   x = {0}, y = {1}, z =  x % y = {2};", x, y, z));
            Console.ReadKey();
            Console.WriteLine("Addition");
            k = m + n;
            z = x + y;
            Console.WriteLine(string.Format("   m = {0}, n = {1}, k =  m + n = {2};", m, n, k));
            Console.WriteLine(string.Format("   x = {0}, y = {1}, z =  x + y = {2};", x, y, z));
            Console.ReadKey();
            Console.WriteLine("Subtraction");
            k = m - n;
            z = x - y;
            Console.WriteLine(string.Format("   m = {0}, n = {1}, k =  m - n = {2};", m, n, k));
            Console.WriteLine(string.Format("   x = {0}, y = {1}, z =  x - y = {2};", x, y, z));
            Console.ReadKey();
            Console.WriteLine("Order of presedence: ( ) * / % + -");
            k = m + n * n - 2 * (5 % 3) + m / 3;
            Console.WriteLine(string.Format("   m = {0}, n = {1}, k = m + n * n - 2 * (5 % 3) + m / 3 = ", m, n));
            Console.ReadKey();
            Console.WriteLine(k);
            Console.ReadKey();
        }

        static void PrefixAndPostfixIncrementDecrement()
        {
            Console.WriteLine("Prefix and postfix increment and decrement");
            int m = -6;
            int n = 4;
            int k;
            int l;

            k = ++m;
            l = n++;
            Console.WriteLine(string.Format("k = {0}, m = {1}, l = {2}, n = {3}", k, m, l, n));
        }

        static void ComparisonOperators()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Discuss comparison operators using immediate window");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Read();

        }

        static void LogicalOperators()
        {
            Console.WriteLine("Logical operators: ");
            bool logicalOr = EvaluateToAndWriteToConsole(true) | EvaluateToAndWriteToConsole(false);
            bool logicalAnd = EvaluateToAndWriteToConsole(false) & EvaluateToAndWriteToConsole(true);
            //Generally use these to aid perfomance:
            Console.WriteLine("...and now the lazy version");
            bool logicalOrLazy = EvaluateToAndWriteToConsole(true) || EvaluateToAndWriteToConsole(false);
            bool logicalAndLazy = EvaluateToAndWriteToConsole(false) && EvaluateToAndWriteToConsole(true);
            Console.Read();
        }

        static void FloatingPointArithmeticExample()
        {
            Console.WriteLine("Floating point arithmetic example:");
            double a = Math.Pow(10, 308);
            double b = 1.01 * Math.Pow(10, 308);
            double c = -1.001 * Math.Pow(10, 308);
            double s1 = a + b;
            s1 = s1 + c;
            double s2 = a + (b + c);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("(a+b)+c={0}", s1);
            Console.WriteLine("a+(b+c)={0}", s2);
        }    

        static void IfElseIfElseExample()
        {
            Console.WriteLine("If, ElseIf, Else example:");
            IsEvenOrOdd(1);
            IsEvenOrOdd(2);
            IsEvenOrOdd(2.5);
            Console.Read();
        }

        static void SwitchStatementExample()
        {
            Console.WriteLine("Switch statment example");
            WriteIntegerAsString(0);
            WriteIntegerAsString(1);
            WriteIntegerAsString(2);
            WriteIntegerAsString(3);
            Console.Read();
        }

        static void ForLoopExample()
        {
            Console.WriteLine("For loop example:");
            int N = 100;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void WhileLoopExample()
        {
            Console.WriteLine("While loop example:");
            int N = 100;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void MethodExample()
        {
            string output = "";
            Concatenate("I thought C#", "was easy!", ref output);
            Console.WriteLine(output);
        }

        static void ScopeExample1RepetedDeclaration()
        {
            int i = 0;
            int N = 10;
            while (i < N) { Console.WriteLine(i); i++; }
            /* int */ i = 0;
            while (i < 10) { N = N + i; i++; }
        }

        static void ScopeExample2AccessingVariableOutsideScope()
        {
            int N = 10; int sum = 0;
            bool isEven = true;
            for (int i = 0; i < N; i++)
            {
                sum = sum + i;
                //bool is Even = false
                if (sum % 2 == 0) isEven = true;
            }
            Console.WriteLine(isEven);
        }

        static void MySort(double[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        double tmp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = tmp;
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }

        static void SortExample()
        {
            Console.WriteLine("Sort example");
            double[] myNumberList = new double[] { 1.0, -3.0, -2.0, 15.0, 12.1, 4.2 };
            Console.WriteLine(" Unsorted:");
            for (int i = 0; i < myNumberList.Length; i++)
            {
                Console.WriteLine(myNumberList[i]);
            }
            Console.ReadKey();
            MySort(myNumberList);
            Console.WriteLine(" Sorted:");
            for (int i = 0; i < myNumberList.Length; i++)
            {
                Console.WriteLine(myNumberList[i]);
            }
            Console.Read();
        }

        static void StringToCharArrayExample()
        {
            Console.WriteLine("String to char[] example:");
            string myString = "Arrays are great!";
            char[] myStringAsCharArray = new char[0];
            int size = 0;
            StringToCharArray(myString, ref myStringAsCharArray, ref size);
            for (int i = 0; i < size; i++)
                Console.Write(myStringAsCharArray[i]);
            Console.Read();
        }

        static void StringToCharArray(String s, ref char[] charArray, ref int size)
        {
            size = s.Length;
            charArray = new char[size];
            for (int i = 0; i < size; i++)
                charArray[i] = s[i];
        }

        static void IntegerArrayExample()
        {
            Console.WriteLine("Integer array example:");
            int N = 5;
            int[] myArray = new int[N];
            for (int i = 0; i < N; i++)
                myArray[i] = i * i;
            for (int j = 0; j < N; j++)
                Console.WriteLine(myArray[j]);
        }

        static void WriteIntegerAsString(int argument)
        {
            switch (argument)
            {
                case 0:
                    Console.WriteLine("Zero");
                    Console.WriteLine("Nil");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Can't count that high!");
                    break;
            }
        }

        static void IsEvenOrOdd(double d)
        {
            if (d % 2 == 0)
            {
                Console.WriteLine(string.Format("{0} is even", d));
            }                           
            else if (d % 1 == 0)
            {
                Console.WriteLine(string.Format("{0} is odd", d));
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not an integer", d));
            }
        }

        static void Concatenate(string s1, string s2, ref string output)
        {
            output = s1 + s2;
        }
        
        private static bool EvaluateToAndWriteToConsole(bool b)
        {
            Console.WriteLine("Evaluated to: {0}", b);
            return b;
        }

       
    }
}

using System;

namespace Learning_CSharp
{
    internal class Program
    {
        enum myEnum { TODAY, TOMORROW, NEVER, MAYBELATER};

        struct myStructPoint
        {
            public int x;
            public int y;
            public int z;
            public string ToString()
            {
                return '{' + x.ToString() + ',' + y.ToString() + ',' + z.ToString() + '}';
            }
        }

        static void Main(string[] args)
        {
            int myFirstInt = 123;
            long myLongInt = 123;
            short myShortInt = 123;

            char myChar = 'A';
            string myString = "Hello WOrld";
            double myDouble = 3.14156123;
            float myFloat = 3.1415123f;

            // An array is a sequencially ordered group of same size data....
            int[] myIntArray = { 1, 2, 3, 4, 6, 0, 3, 12, 1 };
            char[] myCharArray = { 'A', 'B', 'A', 'g', '\0' };

            Console.WriteLine("Hello World!");
            Console.WriteLine("My data : \n int : " + myFirstInt);
            Console.WriteLine("long (int) : " + myLongInt);
            Console.WriteLine("short (int) : " + myShortInt);
            Console.WriteLine("char : " + myChar);
            Console.WriteLine("string : " + myString);
            Console.WriteLine("double : " + myDouble);
            Console.WriteLine("float : " + myFloat);

            Console.WriteLine("Int Array");
            foreach(int i in myIntArray) Console.WriteLine(i);

            Console.WriteLine("Char Array");
            foreach(char c in myCharArray)
            {  
                Console.WriteLine(c); 
            }

            Console.WriteLine("\t\t\t\tMin\t\t\t\t\tMax");
            Console.WriteLine("Int\t\t\t\t" + int.MinValue + "\t\t\t\t" + int.MaxValue);
            Console.WriteLine("uint\t\t\t\t" + uint.MinValue + "\t\t\t\t\t" + uint.MaxValue);
            Console.WriteLine("long(int)\t\t\t" + long.MinValue + "\t\t\t" + long.MaxValue);
            Console.WriteLine("short(int)\t\t\t" + short.MinValue + "\t\t\t\t\t" + short.MaxValue);
            Console.WriteLine("ulong(int)\t\t\t" + ulong.MinValue + "\t\t\t\t\t" + ulong.MaxValue);
            Console.WriteLine("ushort(int)\t\t\t" + ushort.MinValue + "\t\t\t\t\t" + ushort.MaxValue);
            Console.WriteLine("float\t\t\t\t" + float.MinValue + "\t\t\t\t" + float.MaxValue);
            Console.WriteLine("double\t\t\t\t" + double.MinValue + "\t\t\t" + double.MaxValue);
            Console.WriteLine("byte\t\t\t\t" + byte.MinValue + "\t\t\t\t\t" + byte.MaxValue);
            Console.WriteLine("sbyte\t\t\t\t" + sbyte.MinValue + "\t\t\t\t\t" + sbyte.MaxValue);
            Console.WriteLine("decimal\t\t\t\t" + decimal.MinValue + "\t\t" + decimal.MaxValue);

            // Typicall all data is placed at the start of a code block....but making an exception here...
            myEnum testEnum;
            testEnum = myEnum.TODAY;
            Console.WriteLine(testEnum);

            myStructPoint newPoint;
            newPoint.x = 1;
            newPoint.y = 2;
            newPoint.z = 0;
            Console.WriteLine(newPoint.ToString());

            return;
        }
    }
}

using System.ComponentModel.Design;

namespace ProgrammingBasics12BCS
{
    internal class Program
    {
        struct Town
        {
            public string TownName;
            public int Population;
            public double Area;
            public string County;

            public Town(string tName, int tPop, double tArea, string tCounty)
            {
                TownName = tName;
                Population = tPop;
                Area = tArea;
                County = tCounty;
            }
        }
        static void Main(string[] args)
        {
            // Data types
            // data type identifier (=value);
            // integer
            // whole number between -2,147,483,648 and
            // 2,147,483,647
            int myNum;
            myNum = 0;
            Console.WriteLine(myNum);
            int anotherNum = 42;
            Console.WriteLine(anotherNum);

            // real / float
            float myFloat = 0.3F;
            decimal myDecimal = 1.2345m;
            double myDouble = 1.98342162;

            // Boolean
            bool myBool = false;
            myBool = true;
            myBool = !myBool;  //flip boolean values

            // Character
            char myChar = 'a';
            myChar = '@';

            // String
            string myString = "This is a string";
            string emptyString;
            emptyString = "";

            // Date/Time
            DateTime myDateTime = DateTime.Now;
            Console.WriteLine(myDateTime);
            Console.WriteLine(myDateTime.Year);
            Console.WriteLine(myDateTime.Month);
            Console.WriteLine(myDateTime.Day);
            Console.WriteLine(myDateTime.Hour);
            Console.WriteLine(myDateTime.Minute);
            Console.WriteLine(myDateTime.Second);
            Console.WriteLine(myDateTime.Millisecond);

            // Pointer
            // int* ptr = &x;

            // Records
            Town myTown = new Town();
            myTown.TownName = "Heckmondwike";
            myTown.Population = 45;
            myTown.Area = 3.45;
            myTown.County = "W Yorks";
            Console.WriteLine(myTown.Population);
            Town myTown2 = new Town("Batley", 14, 7.2, "W Yorks");
            Console.WriteLine(myTown2.Population);

            // array
            int[] ints = { 3, 7, 2, 1 };
            int[] ints1 = new int[10];

            // Variable declaration
            int aNum = 42;
            int bNum;

            // Constant declaration
            const int myConstantInt = 42;

            // Assignment
            bNum = 123456;

            // Selection
            // Uses If
            // if(criteria){ code }
            if (aNum == 42)
            {
                Console.WriteLine("aNum is 42");
            }

            if (aNum >= 30)
            {
                Console.WriteLine("aNum is greater than or equal to 30");
            }
            else
            {
                Console.WriteLine("aNum is less than 30");
            }

            if (aNum < 50)
            {
                Console.WriteLine("aNum is less than 50");
            }
            else if (bNum < 50)
            {
                Console.WriteLine("aNum is not less than 50 but bNum is");
            }
            else
            {
                Console.WriteLine("Neither are less than 50");
            }

            switch (myNum)
            {
                case 0:
                    Console.WriteLine("Mynum is 0");
                    break;
                case > 10:
                    Console.WriteLine("mynum is greater than 10");
                    break;
                case < -10:
                    Console.WriteLine("mynum les than -10");
                    break;
                default:
                    Console.WriteLine("Not found our value");
                    break;
            }

            bool isItTrue = true;
            if (!isItTrue)
            {
                Console.WriteLine("No it isn't");
            }

            // iteration
            // definite iteration
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for(int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            string test = "HELLO WORLD";
            for(int i = 0;i< test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            for(int i = test.Length - 1; i >= 0; i--)
            {
                Console.Write(test[i]);
            }
            Console.WriteLine();

        }
    }
}

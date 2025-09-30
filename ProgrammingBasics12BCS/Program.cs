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

            public Town(string tName,int tPop,double tArea,string tCounty)
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
            Town myTown2 = new Town("Batley",14,7.2,"W Yorks");
            Console.WriteLine(myTown2.Population);

            // array
            int[] ints = { 3, 7, 2, 1 };
            int[] ints1 = new int[10];

        }
    }
}

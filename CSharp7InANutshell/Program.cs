// C# 7.0 Pocket Reference
using System; // Importing namespace


//public class UnitConverter
//{
//    int ratio;  // Field

//    public UnitConverter(int unitRatio)    //Constructor
//    {
//        ratio = unitRatio;
//    }

//    public int Convert(int unit)   // Method
//    {
//        return unit * ratio;
//    }
//}

//// Page 15
//public class Panda
//{
//    public string Name; // Instance field
//    public static int Population;   // Static field

//    public Panda (string n)    // Constructor
//    {
//        Name = n;   // Assign instance field
//        Population = Population+1;    // Increment static field
//    }
//}

//// Page 17
//public struct Point { public int X, Y; }

//// Page 18
//public class Point { public int X, Y; }

class Test // Class declaration
{
    //// Page 5

    //static void Main() // Method declaration
    //{
    //    int x = 12 * 30; // Statement 1
    //    Console.WriteLine(x); // Stateman 2
    //} // End of method

    static void Main()
    {
        //page 5 - 6

        //Console.WriteLine(FeetToInches (30)); // 360
        //Console.WriteLine(FeetToInches (100)); // 1200

        ////page 12

        //string message = "Hello world";
        //string upperMessage = message.ToUpper();
        //Console.WriteLine(upperMessage);    //HELLO WORLD

        //int x = 2015;
        //message = message + x.ToString();
        //Console.WriteLine(message);     //Hello world2015

        //bool simplevar = false;     // "bool" Only takes either "true" or "false"
        //if (simplevar)    // Because "simplevar" is false it will not print.
        //    Console.WriteLine("This will not print");

        //int x2 = 5000;
        //bool lessThanAMile = x2 < 5200;
        //if (lessThanAMile)
        //    Console.WriteLine("This will print");

        ////page 13

        //UnitConverter feetToInches = new UnitConverter(12);
        //UnitConverter milesToFeet = new UnitConverter(5280);

        //Console.WriteLine(feetToInches.Convert(30)); // 360
        //Console.WriteLine(feetToInches.Convert(100)); // 1200
        //Console.WriteLine(feetToInches.Convert(milesToFeet.Convert(1)));    // 63360

        ////printing all 3 lines i one line.
        //Console.Write(feetToInches.Convert(30)); // 360
        //Console.Write(feetToInches.Convert(100)); // 1200
        //Console.Write(feetToInches.Convert(milesToFeet.Convert(1)));    // 63360


        //Console.WriteLine("/n"); // Blank line

        //// Page 15

        //Panda p1 = new Panda("Pan Dee");
        //Panda p2 = new Panda("Pan Dah");

        //Console.WriteLine(p1.Name); // Pan Dee
        //Console.WriteLine(p2.Name); // Pan Dah

        //Console.WriteLine(Panda.Population);

        //// Page 17

        //Point p1 = new Point();
        //p1.X = 7;

        //Point p2 = p1; // Assignment causes copy

        //Console.WriteLine(p1.X);    // 7
        //Console.WriteLine(p2.X);    // 7

        //p1.X = 9;   // Change p1.X
        //Console.WriteLine(p1.X);    // 9
        //Console.WriteLine(p2.X);    // 7

        //// Page 18

        //Point p1 = new Point();
        //p1.X = 7;

        //Point p2 = p1;  // Copies p1 reference

        //Console.WriteLine(p1.X);    // 7
        //Console.WriteLine(p2.X);    // 7

        //p1.X = 9;   // Change p1.X
        //Console.WriteLine(p1.X);    // 9
        //Console.WriteLine(p2.X);    // 9

        //Point p = null;
        //Console.WriteLine(p == null);   // True

        //Console.WriteLine(p.X); // NullReferenceException

        //// Page 22
        //Console.WriteLine(        1.0.GetType());     // Double (double)
        //Console.WriteLine(       1E06.GetType());    // Double (double)
        //Console.WriteLine(          1.GetType());   // Int32 (int)
        //Console.WriteLine( 0xF0000000.GetType());  // UInt32 (unit)
        //Console.WriteLine(0x100000000.GetType()); // Int64 (long)

        //decimal d = 3.5M;   // M = Decimal (case-insensitive)
        //Console.WriteLine(d);
        //long i = 5; // Implicit conversion from int to long
        //Console.WriteLine(i);

        //float f = 4.5F;     // Won't compile without suffix
        //decimal d = -1.23M; // Won't compile without suffix

        //// Page 23
        //int x = 12345;      // int is a 32-bit integral type
        //long y = x;         // Implicit conversion to 64-bit int
        //short z = (short)x; //Explicit conversion to 16-bit int

        //int i1 = 100000001;
        //Console.WriteLine(i1);
        //float f = i1;       // Magnitude preserved precision lost
        //Console.WriteLine(f);
        //int i2 = (int)f;    // 100000000
        //Console.WriteLine(i2);

        //// Page 24
        //int x = 0;
        //Console.WriteLine(x++); // Outputs 0; x is now 1
        //Console.WriteLine(++x); // Outputs 2; x is now 2
        //Console.WriteLine(--x); // Outputs 1; x is now 1

        //int a = int.MinValue; a--;
        //Console.WriteLine(a == int.MaxValue);   //True

        //// Page 25
        //int a = 1000000, b = 1000000;

        //int c = checked (a * b); // Checks just the expression

        //checked     // Checks all expressions
        //{           // In statement block.
        //    c = a * b;
        //}


    }

    //// Page 5 - 6
    //static int FeetToInches (int feet)
    //{
    //    int inches = feet * 12;
    //    return inches;
    //}
} // End of class "Test"


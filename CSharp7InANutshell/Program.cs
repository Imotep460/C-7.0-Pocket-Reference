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

// Page 15
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

// Page 17
//public struct Point { public int X, Y; }

// Page 18
//public class Point { public int X, Y; }

class Test // Class declaration
{
    // Page 5

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

        //page 12

        //string message = "Hello world";
        //string upperMessage = message.ToUpper();
        //Console.WriteLine(upperMessage);    //HELLO WORLD

        //int x = 2015;
        //message = message + x.ToString();
        //Console.WriteLine(message);     //Hello world2015

        //bool simplevar = false;     //only takes either "true" or "false"
        //if (simplevar)
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

        // Page 17

        //Point p1 = new Point();
        //p1.X = 7;

        //Point p2 = p1; // Assignment causes copy

        //Console.WriteLine(p1.X);    // 7
        //Console.WriteLine(p2.X);    // 7

        //p1.X = 9;   // Change p1.X
        //Console.WriteLine(p1.X);    // 9
        //Console.WriteLine(p2.X);    // 7

        // Page 18

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

    }

    // Page 5 - 6
    //static int FeetToInches (int feet)
    //{
    //    int inches = feet * 12;
    //    return inches;
    //}
} // End of class "Test"


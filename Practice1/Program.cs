using System;

class AreaOfCircle
{
    static void Main()
    {
        // declare variables
        double area =0;
        string radius ;
        // constant number of Pi
        const double PI = Math.PI;

        // Request for user's input
        System.Console.Write("Enter radius value:  ");
        //store input
         radius=  Console.ReadLine();


        // convert from string to double
        double r = Convert.ToDouble(radius);
        // Calculate area
        area = PI * Math.Pow(r, 2);


        // Print output
        System.Console.WriteLine(area);
        System.Console.ReadKey();
    }
}
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

     
        System.Console.Write("Enter radius value:  ");
         radius=  Console.ReadLine();
        double r = Convert.ToDouble(radius);
        // Calculate area
        area = PI * Math.Pow(r, 2);
        // Print output
        System.Console.WriteLine(area);

        System.Console.ReadKey();
    }
}
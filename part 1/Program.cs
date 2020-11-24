/// Lab 13
/// File Name: 
/// @author: Dakota Durst
/// Date: November 23rd, 2020
///
/// Problem Statement: Create 2 methods and assign the method to the delegate and use the method via the delegate.

/// 
///
///
/// Overall Plan:
/// 1)create rectangle class with calculating area and perimeter
/// 2) using 2 new classes and delegating delegate values to each other for pulling
/// 3) invoke the various methods to print out perimeter and area
using System;

namespace part_1
{
    class rectangle
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            mydelegate rectdele = new mydelegate(rect.area);
            //alternative
            //mydelegate rectdele = rect.area;
            rectdele = rectdele + new mydelegate(rect.perimeter);
            rectdele.Invoke(6.0, 4.5);
            Console.WriteLine();
            rectdele.Invoke(15.3, 11.4);
        }
        //declaring delegate
        public delegate void mydelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: " + (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: " + ((width * 2) + (2 * height)));
        }
    }
}

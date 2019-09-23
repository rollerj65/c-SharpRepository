//https://www.tutorialspoint.com/csharp/csharp_basic_syntax.htm
//C# is an object-oriented programming language. In Object-Oriented Programming methodology, a program consists of various objects that interact with each other by means of actions. 
//The actions that an object may take are called methods. Objects of the same kind are said to have the same type or, are said to be in the same class.
//For example, let us consider a Rectangle object. It has attributes such as length and width.Depending upon the design, 
//it may need ways for accepting the values of these attributes, calculating the area, and displaying details.
//Let us look at implementation of a Rectangle class and discuss C# basic syntax −


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSyntax
{
    class Rectangle
    {
        double length;
        double width;

        public void initialize()
        {
            length = 4.5;
            width = 3.5;
        }

        public double getArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Aread: {0}", getArea());
        }
    }
    class executeRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.initialize();
            r.Display();
            Console.ReadLine();
        }
    }
}

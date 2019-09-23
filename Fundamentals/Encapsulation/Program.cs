//https://www.tutorialspoint.com/csharp/csharp_encapsulation.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// process of enclosing one or more items within a physical or logical package
//Abstraction -> allows making relevant information visible
//Encapsulation -> allows programmer to implement the desired level of abstraction



namespace Encapsulation
{
    //Public access specifier allows a class to expose its member variables and member functions to other functions and objects. Any public member can be accessed from outside the class.
    public class publicAccessSpecifier
    {
        class publicRectangle
        {
            public double length;
            public double width;

            public double GetArea()
            {
                return length * width;
            }

            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }

        public class executeRectangle
        {
            public static void execute()
            {
                publicRectangle r = new publicRectangle();
                r.length = 4.5;
                r.width = 3.5;
                r.Display();
                Console.ReadLine();
            }
        }
    }

    //Private access specifier allows a class to hide its member variables and member functions from other functions and objects. 
    //Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.
    public class privateAccessSpecifier
    {
        public class privateRectangle
        {
            private double length;
            private double width;

            void acceptDetails()
            {
                Console.WriteLine("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Width: ");
                width = Convert.ToDouble(Console.ReadLine());
            }
            double getArea()
            {
                return length * width;
            }

            void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", getArea());
            }

            public void executeRectangle()
            {
                privateRectangle r = new privateRectangle();
                r.acceptDetails();
                r.getArea();
                r.Display();

            }
        }
            
    }

   

    //Protected access specifier allows a child class to access the member variables and member functions of its base class.
    class protectedAccessSpecifier
    {
        


    }
    //Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly.
    class internalAccessSpecifier
    {
        class internalRectangle
        {
            internal double length;
            internal double width;

            double getArea()
            {
                return length * width;
            }

            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", getArea());

            }

            public void executeRectangle3()
            {
                internalRectangle r = new internalRectangle();
                r.length = 4.5;
                r.width = 3.5;
                r.Display();
                Console.ReadLine();
            }

        }
        
    }
    class encapsulationProgram
    {
        static void Main(string[] args)
        {
            publicAccessSpecifier.executeRectangle.execute();
        }
    }
}

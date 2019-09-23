using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //static polymorphism: linking a function with an object during compile time is early binding -> static binding
    class FunctionOverloading
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        
        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }

    class FunctionOverloadingTest
    {
        public static void TestInputs()
        {
            FunctionOverloading p = new FunctionOverloading();

            p.print(5);
            p.print(500.263);
            p.print("String found");
        }
    }

    //Dynamic Polymorphism
    //abstract class: used to provide partial class implementation of an interface. Implementation is completed when a derived class inherits from it.
    //Rules of abstract classes:
    //Cannot create an instance of an abstract class
    //cannot declare an abstract method outside of an abstract class
    //when a class is declared sealed, it cannot be inherited. Abstract classes cannot be declared sealed.

    class AbstractClassUsage
    {
        public abstract class Shape
        {
            public abstract int area();
        }

        public class Rectangle : Shape
        {
            private int length;
            private int width;

            public Rectangle(int a = 0, int b = 0)
            {
                length = a;
                width = b;
            }

            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * length);
            }


        }
    }

    class AbstractClassTest
    {
        public static void Initialize()
        {
            AbstractClassUsage.Rectangle r = new AbstractClassUsage.Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
        }
    }

    //Virtual functions: functions defined in a class that it implemented in inherited classes
    //functions could be implemented differently in different inherited classes.

    class VirtualFunctionUsage
    {
        public class Shape
        {
            protected int width, height;

            public Shape(int a = 0, int b = 0)
            {
                width = a;
                height = b;
            }

            public virtual int area()
            {
                Console.WriteLine("Parent class area: ");
                return 0;
            }

            class Rectangle: Shape
            {
                public Rectangle(int a = 0, int b = 0): base(a, b) {}

                public override int area()
                {
                    Console.WriteLine("Rectangle class Area: ");
                    return (width * height);
                }
            }

            class Triangle: Shape
            {
                public Triangle(int a = 0, int b = 0): base(a,b) {}

                public override int area()
                {
                    Console.WriteLine("Triangle class area :");
                    return (width * height / 2);
                }
            }

            class Caller
            {
                public void CallArea(Shape sh)
                {
                    int a;
                    a = sh.area();
                    Console.WriteLine("Area: {0}", a);
                }
            }

            public class Tester
            {
                public static void Initialize()
                {
                    Caller c = new Caller();
                    Rectangle r = new Rectangle(10, 7);
                    Triangle t = new Triangle(10, 5);

                    c.CallArea(r);
                    c.CallArea(t);
                }
            }
        }
    }
    class PolymorphismProgram
    {
        static void Main(string[] args)
        {
            FunctionOverloadingTest.TestInputs();
            AbstractClassTest.Initialize();
            VirtualFunctionUsage.Shape.Tester.Initialize();
            Console.Read();
        }
    }
}

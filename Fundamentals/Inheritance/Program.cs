using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //classes can be derived from more than one class or interface

    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

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

    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w) {}
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }


    }

    class RectangleTester
    {
        public static void Initialize()
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
        }
    }

    //Multiple inheritance implementation using interfaces
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    //base class PaintCost
    public interface PaintCost
    {
        int GetCost(int area);
    }

    //Derived class
    class MultipleInheritanceRectangle: Shape, PaintCost
    {
        public int GetArea()
        {
            return (width * height);
        }

        public int GetCost(int area)
        {
            return area * 70;
        }


    }

    class MultipleInheritanceTester
    {
        public static void Initialize()
        {
            MultipleInheritanceRectangle rect = new MultipleInheritanceRectangle();
            int area;

            rect.SetWidth(5);
            rect.SetHeight(7);
            area = rect.GetArea();

            Console.WriteLine("Total area: {0}", rect.GetArea());
            Console.WriteLine("Total paint cost: ${0}", rect.GetCost(area));
        }
    }

    class InheritanceProgram
    {
        static void Main(string[] args)
        {
            RectangleTester.Initialize();
            MultipleInheritanceTester.Initialize();
            Console.Read();
        }
    }
}

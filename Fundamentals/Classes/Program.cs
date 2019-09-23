//https://www.tutorialspoint.com/csharp/csharp_classes.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //default access specifiers:
    //class type: internal
    //members: private

    
    class StaticVariable
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public int GetNum()
        {
            return num;
        }
    }

    class PrivateLine
    {
        private double length;

        //Constructor
        public PrivateLine()
        {
            Console.WriteLine("Private line created.");
        }

        //Constructor with additional parameters
        public PrivateLine(double len)
        {
            Console.WriteLine("Object is being created, length = {0}", len);
            length = len;
        }

        //Destructor
        ~PrivateLine()
        {
            Console.WriteLine("Object is being deleted");
        }

        public void SetLength(double len)
        {
            length = len;
        }
        public double GetLength()
        {
            return length;
        }
    }

    class PublicBox
    {
        public double length;
        public double breadth;
        public double height;
    }

    class PrivateBox
    {
        private double length;
        private double breadth;
        private double height;

        public void SetLength(double len)
        {
            length = len;
        }
        public void SetBreadth (double bre)
        {
            breadth = bre;
        }
        public void SetHeight(double hei)
        {
            height = hei;
        }
        public double GetVolume()
        {
            return length * breadth * height;
        }
    }

    class PublicBoxTester
    {
        public static void InitializePublicBoxes()
        {
            PublicBox Box1 = new PublicBox();
            PublicBox Box2 = new PublicBox();
            double volume = 0.0;

            //Box1 specification
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            //Box2 specification
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            //volume of box 1
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Volume of Box1: {0}", volume);

            //volume of box 2
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Volume of Box2: {0}", volume);

        }
    }

    class PrivateBoxTester
    {
        public static void InitializePrivateBoxes()
        {
            PrivateBox Box1 = new PrivateBox();
            PrivateBox Box2 = new PrivateBox();
            double volume;

            //Box 1 specification using set command
            Box1.SetLength(6.0);
            Box1.SetBreadth(7.0);
            Box1.SetHeight(5.0);

            Box2.SetLength(12.0);
            Box2.SetBreadth(13.0);
            Box2.SetHeight(10.0);

            //calculate volume using public class
            volume = Box1.GetVolume();
            Console.WriteLine("Volume of Private box1: {0}", volume);

            volume = Box2.GetVolume();
            Console.WriteLine("Volume of private box2: {0}", volume);
        }
    }

    class PrivateLineTester
    {
        public static void InitializeLine()
        {
            PrivateLine line1 = new PrivateLine();
            PrivateLine line2 = new PrivateLine(10.0);
            //set line length
            line1.SetLength(6.0);
            Console.WriteLine("Length of line: {0}", line1.GetLength());

            //set line length using Constructor with additional parameter
            Console.WriteLine("Length of line: {0}", line2.GetLength());
        }
    }

    class StaticVariableTester
    {
        public static void InitializeVariable()
        {
            int Iteration = 3;

            StaticVariable s1 = new StaticVariable();
            StaticVariable s2 = new StaticVariable();

            for (int i = 0 ; i < Iteration; i++)
            {
                s1.count();
                s2.count();
            }

            Console.WriteLine("Variable num: {0}", s1.GetNum());
            Console.WriteLine("Variable num: {0}", s2.GetNum());
        }
    }

    class ClassesProgram
    {
        static void Main(string[] args)
        {
            PublicBoxTester.InitializePublicBoxes();
            PrivateBoxTester.InitializePrivateBoxes();
            PrivateLineTester.InitializeLine();
            StaticVariableTester.InitializeVariable();
            Console.ReadKey();
        }
    }
}

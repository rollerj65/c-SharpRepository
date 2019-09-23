using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    //You can redefine or overload most built-in operators.
    //allows you to operate on user-defined types as well

    class OverloadingImplementation
    {
        class Box
        {
            private double length;
            private double breadth;
            private double height;

            public double GetVolume()
            {
                return length * breadth * height;
            }

            public void SetLength(double len)
            {
                length = len;
            }

            public void SetBreadth(double bre)
            {
                breadth = bre;
            }

            public void SetHeight(double hei)
            {
                height = hei;
            }

            //Overload addition operator to add boxes
            public static Box operator +(Box b, Box c)
            {
                Box box = new Box();
                box.length = b.length + c.length;
                box.breadth = b.breadth + c.breadth;
                box.height = b.height + c.height;
                return box;
            }

            public static bool operator ==(Box lhs, Box rhs)
            {
                bool status = false;
                if (lhs.length == rhs.length && lhs.height == rhs.height && lhs.breadth == rhs.breadth)
                {
                    status = true;
                }
                return status;
            }

            public static bool operator !=(Box lhs, Box rhs)
            {
                bool status = false;

                if (lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
                {
                    status = true;
                }
                return status;
            }

            public static bool operator >(Box lhs, Box rhs)
            {
                bool status = false;

                if (lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth)
                {
                    status = true;
                }
                return status;
            }

            public static bool operator <(Box lhs, Box rhs)
            {
                bool status = false;

                if (lhs.length < rhs.length && lhs.height < rhs.height && lhs.breadth < rhs.breadth)
                {
                    status = true;
                }
                return status;
            }

            public static bool operator <=(Box lhs, Box rhs)
            {
                bool status = false;

                if (lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth)
                {
                    status = true;
                }
                return status;
            }

            public static bool operator >=(Box lhs, Box rhs)
            {
                bool status = false;

                if (lhs.length >= rhs.length && lhs.height >= rhs.height && lhs.breadth >= rhs.breadth)
                {
                    status = true;
                }
                return status;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1}, {2})", length, breadth, height);
            }
            public class Tester
            {
                public static void Initialize()
                {
                    Box Box1 = new Box();
                    Box Box2 = new Box();
                    Box Box3 = new Box();
                    Box Box4 = new Box();

                    double volume = 0.0;

                    //box1 specification
                    Box1.SetLength(6.0);
                    Box1.SetBreadth(7.0);
                    Box1.SetHeight(5.0);

                    //box2 specification
                    Box2.SetLength(12.0);
                    Box2.SetBreadth(13.0);
                    Box2.SetHeight(10.0);

                    //display boxes using overloaded ToString()
                    Console.WriteLine("Box 1: {0}", Box1.ToString());
                    Console.WriteLine("Box 2: {0}", Box2.ToString());
                    
                    //volume of box 1
                    volume = Box1.GetVolume();
                    Console.WriteLine("Volume of Box1: {0}", volume);

                    //volume of box 2
                    volume = Box2.GetVolume();
                    Console.WriteLine("Volume of Box2: {0}", volume);

                    //add the two objects
                    Box3 = Box1 + Box2;

                    //volume of box 3
                    volume = Box3.GetVolume();
                    Console.WriteLine("Volume of Box3: {0}", volume);

                    //Compare boxes

                    if(Box1 > Box2)
                    {
                        Console.WriteLine("Box1 is greater than Box2");
                    }
                    else
                    {
                        Console.WriteLine("Box1 is not greater than Box2");
                    }

                    if(Box1 < Box2)
                    {
                        Console.WriteLine("Box1 is less than Box2");
                    }
                    else
                    {
                        Console.WriteLine("Box1 is not less than Box2");
                    }

                    if(Box1 >= Box2)
                    {
                        Console.WriteLine("Box1 is greater than or equal to Box2");
                    }
                    else
                    {
                        Console.WriteLine("Box1 is not greater than or equal to Box2");
                    }

                    if(Box1 <= Box2)
                    {
                        Console.WriteLine("Box1 is less than or greater to Box2");
                    }
                    else
                    {
                        Console.WriteLine("Box1 is not less than or greater to Box2");
                    }

                    if (Box1 != Box2)
                    {
                        Console.WriteLine("Box1 is not equal to Box2");
                    }
                    else
                    {
                        Console.WriteLine("Box1 is not greater or equal to Box2");
                    }

                    Box4 = Box3;

                    if (Box3 == Box4)
                    {
                        Console.WriteLine("Box3 is equal to Box4");
                    }
                    else
                    {
                        Console.WriteLine("Box3 is not equal to Box4");
                    }
                }
            }
        }

        class OperatorOverloadingProgram
        {
            static void Main(string[] args)
            {
                Box.Tester.Initialize();
                Console.Read();
            }
        }
    }
}

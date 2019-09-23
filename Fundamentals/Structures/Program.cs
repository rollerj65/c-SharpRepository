//https://www.tutorialspoint.com/csharp/csharp_struct.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id : {0}", book_id);
        }

    }
    class DefiningAStructure
    {
        public static void TestStructure()
        {
            Books Book1;
            Books Book2;

            //Book 1 specification
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            //Book 2 specification
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            //print Book1 info
            Book1.display();

            //print Book2 info
            Book2.display();
        }

    }

    class ClassVersusStructure
    {
        
    }

    class StructureProgram
    {
        static void Main(string[] args)
        {
            DefiningAStructure.TestStructure();
            Console.Read();
        }
    }
}

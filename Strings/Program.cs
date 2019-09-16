#region string methods
//String Methods:
//public static int Compare(string strA, string strB), Compares two specified string objects and returns an integer that indicates their relative position in the sort order.
//public static int Compare(string strA, string strB, bool ignoreCase), Compares two specified string objects and returns an integer that indicates their relative position in the sort order.However, it ignores case if the Boolean parameter is true.
//public static string Concat(string str0, string str1), Concatenates two string objects.
//public static string Concat(string str0, string str1, string str2), Concatenates three string objects.
//public static string Concat(string str0, string str1, string str2, string str3), Concatenates four string objects.
//public bool Contains(string value), Returns a value indicating whether the specified String object occurs within this string.
//public static string Copy(string str), Creates a new String object with the same value as the specified string.
//public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count), Copies a specified number of characters from a specified position of the String object to a specified position in an array of Unicode characters.
//public bool EndsWith(string value), Determines whether the end of the string object matches the specified string.
//public bool Equals(string value), Determines whether the current String object and the specified String object have the same value.
//public static bool Equals(string a, string b), Determines whether two specified String objects have the same value.
//public static string Format(string format, Object arg0), Replaces one or more format items in a specified string with the string representation of a specified object.
//public int IndexOf(char value), Returns the zero-based index of the first occurrence of the specified Unicode character in the current string.
//public int IndexOf(string value), Returns the zero-based index of the first occurrence of the specified string in this instance.
//public int IndexOf(char value, int startIndex), Returns the zero-based index of the first occurrence of the specified Unicode character in this string, starting search at the specified character position.
//public int IndexOf(string value, int startIndex), Returns the zero-based index of the first occurrence of the specified string in this instance, starting search at the specified character position.
//public int IndexOfAny(char[] anyOf), Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.
//public int IndexOfAny(char[] anyOf, int startIndex), Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters, starting search at the specified character position.
//public string Insert(int startIndex, string value), Returns a new string in which a specified string is inserted at a specified index position in the current string object.
//public static bool IsNullOrEmpty(string value), Indicates whether the specified string is null or an Empty string.
//public static string Join(string separator, params string[] value, Concatenates all the elements of a string array, using the specified separator between each element.
//public static string Join(string separator, string[] value, int startIndex, int count), Concatenates the specified elements of a string array, using the specified separator between each element.
//public int LastIndexOf(char value), Returns the zero-based index position of the last occurrence of the specified Unicode character within the current string object.
//public int LastIndexOf(string value), Returns the zero-based index position of the last occurrence of a specified string within the current string object.
//public string Remove(int startIndex), Removes all the characters in the current instance, beginning at a specified position and continuing through the last position, and returns the string.
//public string Remove(int startIndex, int count), Removes the specified number of characters in the current string beginning at a specified position and returns the string.
//public string Replace(char oldChar, char newChar), Replaces all occurrences of a specified Unicode character in the current string object with the specified Unicode character and returns the new string.
//public string Replace(string oldValue, string newValue), Replaces all occurrences of a specified string in the current string object with the specified string and returns the new string.
//public string[] Split(params char[] separator), Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array.
//public string[] Split(char[] separator, int count), Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array.The int parameter specifies the maximum number of substrings to return.
//public bool StartsWith(string value), Determines whether the beginning of this string instance matches the specified string.
//public char[] ToCharArray(), Returns a Unicode character array with all the characters in the current string object.
//public char[] ToCharArray(int startIndex, int length), Returns a Unicode character array with all the characters in the current string object, starting from the specified index and up to the specified length.
//public string ToLower(), Returns a copy of this string converted to lowercase.
//public string ToUpper(), Returns a copy of this string converted to uppercase.
//public string Trim(), Removes all leading and trailing white-space characters from the current String object.
#endregion


//https://www.tutorialspoint.com/csharp/csharp_strings.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{

    class CreatingStringObject
    //created by:
    //assigning string literal to string variable
    //using string class constructor
    //using string conctattenation operator(+)
    //retrieving proper or calling a method that returns a string
    //by calling formating method to conver a value or an object to its string representation
    {
        public static void CreateStrings()
        {
            string fname, lname;
            fname = "Jessica";
            lname = "Johnson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "from", "Jacob", "Roller" };
            string FullName = fname + lname;
            Console.WriteLine("Full name: {0}", fname + " " + lname);

            //using string constructor
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //method returning string
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    //string properties:
    //Chars: get char object at a specified position in the current string object
    //Length: get the number of characters in the current string object

    }

    class StringExamples
    {
        public static void ComparingStrings()
        {
            string str1 = "This is a test";
            string str2 = "This is a text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
        }

        public static void StringContainString()
        {
            string str = "This is test";

            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
        }

        public static void GettingASubstring()
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine("substring: " + substr);
        }

        public static void JoiningStrings()
        {
            string[] starray = new string[] { "Down the way the nights are dark", "And the sun shines daily on the mountain top", "And when I reached Jamaica", "I made a stop" };
            string str = String.Join("\n", starray);
            Console.WriteLine(str);
        }
    }


    class StringProgram
    {
        static void Main(string[] args)
        {
            CreatingStringObject.CreateStrings();
            StringExamples.ComparingStrings();
            StringExamples.StringContainString();
            StringExamples.GettingASubstring();
            StringExamples.JoiningStrings();
            Console.ReadLine();
        }
    }
}

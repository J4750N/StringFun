using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace StringFun
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Here is text";
            string string2 = "Here is some more text";

            bool result = string1.Equals(string2, StringComparison.OrdinalIgnoreCase);

            string string3 = "Here is even more text";

            string someAddedText = string1 + " " + string2 + " " + string3 + " A final string";

            string formattedString = string.Format("{0} {1} {2}", string1, string2, string3, "A final String" );

            int formattedStringLen = formattedString.Length;

            Console.WriteLine(formattedString.ToUpper());

            string subString = string3.Substring(8, 4);

            string replacetext = string3.Replace("text", "String");

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("Hello World");
            StringBuilder sb3 = new StringBuilder(string1);

            StringBuilder sb4 = new StringBuilder("Hello World!", 50);

            Console.WriteLine(sb2.Length);
            Console.WriteLine(sb2);

            sb1.Append("Here I am");
            sb1.Append(" and this is my string");
            sb1.Append(String.Format(" {0} {1} {2}", string1, string2, string3, "A final String"));

            Console.WriteLine(sb1);

            int total = 25;
            StringBuilder output = new StringBuilder("Your total is: ");
            output.AppendFormat("{0:C} ", total);
            Console.WriteLine(output);

            StringBuilder mySB1 = new StringBuilder("This is my bird ");
            mySB1.Insert(11, "beautiful ");
            Console.WriteLine(mySB1);

            mySB1.Replace("beautiful ", "ugly");
            Console.WriteLine(mySB1);

            mySB1.Remove(11, 5);
            Console.WriteLine(mySB1);

            mySB1.AppendLine();


            Console.ReadLine();
        }

    }
}

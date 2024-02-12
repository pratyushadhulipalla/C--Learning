using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for (int i = 0; i < 2500; i++)
            {
                indexes += i.ToString();

            }


           string firstName = "Bethany";
           string lastName = "Smith";

           StringBuilder builder = new StringBuilder();

            builder.Append("Last name: ");
            builder.AppendLine(lastName);
            builder.Append("First name: ");
            builder.AppendLine(firstName);
            string result = builder.ToString();

            Console.WriteLine(result);











        }
    }
}

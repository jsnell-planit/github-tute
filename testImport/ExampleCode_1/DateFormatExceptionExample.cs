using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExampleCode_1
{
    class DateFormatExceptionExample
    {
        public void DateStringParsing()
        {
            CultureInfo MyCultureInfo = new CultureInfo("en-AU");
            string[] myStrings = { " Monday, 05 May 1980", "Monday, 05 May 1980" };
            string dtFormatter = "ddd, d MMM yyyy";

            foreach (string dateString in myStrings)
            {
                try
                {
                    DateTime MyDateTime = DateTime.ParseExact(dateString, "D", MyCultureInfo);
                    Console.WriteLine(MyDateTime.ToString(dtFormatter));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse '{0}'", dateString);
                }
            }
        }

        public void DateStringParsingNoCheck()
        {
            CultureInfo MyCultureInfo = new CultureInfo("en-AU");
            string myDateString = "Monday, 05 May 1980";
            string dtFormatter = "ddd, d MMM yyyy";

            // won't compile - bad params
            DateTime MyDateTime1 = DateTime.Parse(myDateString, "D", MyCultureInfo);

            // will compile
            DateTime MyDateTime2 = DateTime.Parse(myDateString, MyCultureInfo);
            DateTime MyDateTime3 = DateTime.ParseExact(myDateString, "D", MyCultureInfo);
            Console.WriteLine(MyDateTime3.ToString(dtFormatter));

            double number = double.Parse("04.5");
        }
    }
}

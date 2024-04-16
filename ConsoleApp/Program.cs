using System;
using System.Globalization;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Please uncommit 1 by 1 to test the code!");

            string readValue = Console.ReadLine();


            Console.WriteLine(Question1(readValue));


            //Console.WriteLine(Question2(readValue));

            //// For please use single space
            //Console.WriteLine(Question3(readValue));


            //Console.WriteLine(Question4(readValue));


            //Console.WriteLine(Question5(readValue));



            //// For please use single space for two numbers
            //Console.WriteLine(Question6(readValue));


            //Console.WriteLine(Question7(readValue));


            //Console.WriteLine(Question8(readValue));

            //Console.WriteLine(Question9(readValue));


            //Console.WriteLine(Question10(readValue));

        }


        public static string Question1(string path) => File.Exists(path) ? "File Path Exist" : "File Path Not Exist";

        public static string Question2(string input)
        {
            int x = 0;
            Int32.TryParse(input, out x);

            if (x > 1000 && x < 0)
            {
                return "Number must between 0 and 1000";
            }

            return input.ToString();
        }


        public static string Question3(string input)
        {
            if (input.Length == 0) return "Empty";


            String[] arrays = new String[] { input };

            int handler = 0;

            for (int i = 0; i < arrays.Length; i++)
            {
                int x = 0;
                if (Int32.TryParse(input, out x))
                    handler += x;
            }

            return (handler / arrays.Length).ToString();

        }


        public static string Question4(string input)
        {
            int x = 0;

            if (!Int32.TryParse(input, out x)) return "Not a number";

            return input;

        }


        public static string Question5(string input)
        {
            int x = 0;
            Int32.TryParse(input, out x);

            return Int32.TryParse(input, out x) ? "In range" : "out of range";
        }


        public static string Question6(string input)
        {
            string[] spliit = input.Split(" ");

            int x = 0, y = 0;
            Int32.TryParse(spliit[0], out x);
            Int32.TryParse(spliit[1], out y);

            if (y == 0)
                return "Cannot be divided by 0";

            return (x / y).ToString();

        }



        public static string Question7(string input)
        {
            DateTime dt;
            if (DateTime.TryParseExact(input,
                                        "dd/mm/yyyy",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                out dt))
            {
                return "Valid Date";
            }
            else
            {
                return "Invalid Date";
            }

        }

        private static string Question8(string input)
        {
            int x = 0;
            Int32.TryParse(input, out x);
            if (x < 0)
                return "Number must be a whole number";

            return Math.Sqrt(x).ToString();
        }


        private static string Question9(string input) => input.ToUpper();

        private static string Question10(string input)
        {
            int i, fact = 1, number;

            int x;

            number = int.Parse(input);
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            if (fact > 2147483647) return "Result exceeds the int32 max value";



            return fact.ToString();

        }



    }
}

using System;

namespace RgbConverter
{
    public static class Rgb
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console RGB converter C#\r");
            Console.WriteLine("------------------------");

            while (!endApp)
            {
                string result;
                int red = 0, green = 0, blue = 0;

                GetInputNumber(ref red);
                GetInputNumber(ref green);
                GetInputNumber(ref blue);
                
                result = GetHexRepresentation(red, green, blue);

                Console.WriteLine($"Your result: {result}");
                Console.WriteLine("------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }
                Console.WriteLine("\n");
            }
        }
        public static void GetInputNumber(ref int numColour)
        {
            Console.Write("Type a number, and then press Enter: ");
            string numInput = Console.ReadLine();

            while (!int.TryParse(numInput, out numColour))
            {
                Console.Write("This is not valid input. Please enter an integer number: ");
                numInput = Console.ReadLine();
            }
        }

        public static string GetHexRepresentation(int red, int green, int blue)
        {
            string result = string.Empty;

            CheckMin(ref red);
            CheckMin(ref green);
            CheckMin(ref blue);

            CheckMax(ref red);
            CheckMax(ref green);
            CheckMax(ref blue);

            result += Sum(result, red) + Sum(result, green) + Sum(result, blue);
            return result;
        }

        public static void CheckMin(ref int color)
        {
            color = (color < byte.MinValue) ? byte.MinValue : color;
        }

        public static void CheckMax(ref int color)
        {
            color = (color > byte.MaxValue) ? byte.MaxValue : color;
        }

        public static string Sum(string str, int color)
        {
            if (Convert.ToString(color, 16).Length == 1 || color == 0)
            {
                str = string.Concat("0", Convert.ToString(color, 16));
            }
            else
            {
                str = Convert.ToString(color, 16);
            }

            return str.ToUpperInvariant();
        }
    }
}
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace debugDev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Try-Catch-Finally
            int num1 = 5, num2 = 0;
            try {
                calc(num1, num2);

            } catch (NullReferenceException ex) {
                Console.WriteLine($"NullReferenceException: {ex.Message}");

            } catch (Exception ex) {
                Console.WriteLine("------------------------------------------------------\n");
                Console.WriteLine($"Exception Data: {ex.Data}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception HelpLink: {ex.HelpLink}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception HResult: {ex.HResult}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception InnerException: {ex.InnerException}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception Message: {ex.Message}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception Source: {ex.Source}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception StackTrace: {ex.StackTrace}");
                Console.WriteLine("\n------------------------------------------------------\n");
                Console.WriteLine($"Exception TargetSite: {ex.TargetSite}");
                Console.WriteLine("\n------------------------------------------------------\n");

            } finally {
                Console.WriteLine("HEY YOU!! -- Bye bye!");
            }

            //// ArrayTypeMismatchException
            //string[] names = { "Dog", "Cat", "Fish" };
            //Object[] objs = (Object[])names;

            //Object obj = (Object)13;
            //objs[2] = obj; // Breaks

            //// DivideByZeroException
            //int number1 = 3000;
            //int number2 = 0;
            //Console.WriteLine(number1 / number2); // Breaks

            //// FormatException
            //int valueEntered;
            //string userValue = "two";
            //valueEntered = int.Parse(userValue); // Breaks

            //// IndexOutOfRangeException
            //int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
            //int[] values2 = new int[6];

            //values2[values1.Length - 1] = values1[values1.Length - 1]; // Breaks

            //// InvalidCastException
            //object obj = "This is a string";
            //int num = (int) obj;

            //// NullReferenceException (1)
            //int[] values = null;
            //for (int i = 0; i <= 9; i++) {
            //    values[i] = i * 2;
            //}

            //// NullReferenceException (2)
            //string? lowCaseString = null;
            //Console.WriteLine(lowCaseString.ToUpper());

            //// OverflowException
            //decimal x = 400;
            //byte i;

            //i = (byte) x; // Breaks
            //Console.WriteLine(i);

            Console.WriteLine("\n.......................................................................\n");

            //Debug.Assert();

            Console.WriteLine("\n.......................................................................\n");

            FormatException invalidFormatException = new FormatException("FormatException: Validation was interrupted due to invalid data format");
            throw invalidFormatException;
        }

        private static int calc(int num1, int num2) {
            int result = num1 / num2;
            return result;
        }
    }
}

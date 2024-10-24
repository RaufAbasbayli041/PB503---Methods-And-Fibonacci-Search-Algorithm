using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PB503___Methods_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 with return type

            //int sumOfCountNumbers = SumOfCountNumbers(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine($"Sum of countable numbers is {sumOfCountNumbers}");

            #endregion

            #region Task 1 with void type

            //int number = Convert.ToInt32(Console.ReadLine());
            //PrintSumOfCountNumbers(number);

            #endregion

            #region Task 2  

            // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.

            string text = " Code Academy ";
            PrintText(text);


            #endregion
        }

        static int SumOfCountNumbers(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    Console.WriteLine($"{i} - countable");
                }
            }
            return sum;
        }

        static void PrintSumOfCountNumbers(int numbers)
        {
            int sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    Console.WriteLine($"{i} - countable");
                }
            }
            Console.WriteLine($"sum of countable numbers is {sum}");
        }

        static void PrintText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == ' ')
                {
                    continue;
                }
                Console.Write(text[i]);
            }


        }
    }

}

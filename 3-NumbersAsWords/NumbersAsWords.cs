namespace _3_NumbersAsWords
{
    internal class NumbersAsWords
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 1 && number < 10)
            {
                Console.WriteLine("one");
            }
            else if (number == 2 && number < 10)
            {
                Console.WriteLine("two");
            }
            else if (number == 3 && number < 10)
            {
                Console.WriteLine("three");
            }
            else if (number == 4 && number < 10)
            {
                Console.WriteLine("four");
            }
            else if (number == 5 && number < 10)
            {
                Console.WriteLine("five");
            }
            else if (number == 6 && number < 10)
            {
                Console.WriteLine("six");
            }
            else if (number == 7 && number < 10)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8 && number < 10)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9 && number < 10)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}

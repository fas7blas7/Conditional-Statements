namespace _4_GreaterNumber
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Greater number: {firstNumber}");
            }
            else
            {
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine($"Greater number: {secondNumber}");
                }
            }
        }
    }
}

namespace Delegate
{
    internal class Program
    {
        public delegate bool NumberMethod(int number);
        static void Main(string[] args)
        {
            SumOfNumbers((s) => s % 2==0, 1, 2, 3, 4, 5, 6);
            SumOfNumbers((s) => s %2 ==1 , 1, 2, 3, 4, 5, 6);
        }


        public static void SumOfNumbers(NumberMethod method, params int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                if (method(number))
                {
                    sum+= number;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}

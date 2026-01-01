using System.ComponentModel.DataAnnotations;

namespace Delegate
{
    internal class Program
    {
        public delegate bool NumberMethod(int number);
        static void Main(string[] args)
        {
            //SumOfNumbers((s) => s % 2 == 0, 1, 2, 3, 4, 5, 6);
            //SumOfNumbers((s) => s % 2 == 1 , 1, 2, 3, 4, 5, 6);
            //SumOfNumbers(delegate (int s) { return s % 2 == 1; },
            //    1, 2, 3, 4, 5, 6);
            Calculator calculator = new Calculator();
            ValidateObject(calculator);


            NumberMethod method = IsEven;
            method += IsOdd;
            SumOfNumbers(method, 1, 2, 3, 4, 5, 6);
        }

        public static void ValidateObject(object obj)
        {
            var context = new ValidationContext(obj, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, context, results, true);
            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Object is valid.");
            }
        }


        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private static bool IsOdd(int number)
        {
            return number % 2 == 1;
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

    class Calculator
    {
        [Required]
        [MyMaxLength(10)]
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class MyMaxLengthAttribute : ValidationAttribute
    {
        private readonly int _maxLength;
        public MyMaxLengthAttribute(int maxLength)
        {
            _maxLength = maxLength;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string strValue && strValue.Length > _maxLength)
            {
                return new ValidationResult($"The field {validationContext.MemberName} exceeds the maximum length of {_maxLength}.");
            }
            return ValidationResult.Success;
        }
    }

}

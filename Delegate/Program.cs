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

            Student student1 = new Student(1, "John", "Doe", 20);
            Student student2 = new Student(2, "Jane", "SmithWithAVeryLongSurname", 17);
            ValidateStudent(student1);
            ValidateStudent(student2);

            //NumberMethod method = IsEven;
            //method += IsOdd;
            //SumOfNumbers(method, 1, 2, 3, 4, 5, 6);
        }

       
        public static void ValidateStudent(Student student)
        {
            var context = new ValidationContext(student);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(student, context, results, true);
            if (isValid)
            {
                Console.WriteLine("Student is valid.");
            }
            else
            {
                Console.WriteLine("Student is invalid. Errors:");
                foreach (var validationResult in results)
                {
                    Console.WriteLine($"- {validationResult.ErrorMessage}");
                }
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

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string Surname { get; set; }
        [Required]
        [Check]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}";
        }

        public Student(int id, string name, string surname, int age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
        }

    }

    class CheckAttribute : ValidationAttribute
    {
        public int MinAge { get; set; } = 18;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int age)
            {
                if (age < MinAge)
                {
                    return new ValidationResult($"Age must be at least {MinAge}.");
                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid age value.");
        }
    }

}

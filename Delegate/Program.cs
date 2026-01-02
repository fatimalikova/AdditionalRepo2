using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Delegate
{
    internal class Program
    {
        public delegate U Print<T,U>(string w);

        public delegate bool NumberMethod(int number);
        static void Main(string[] args)
        {
            //SumOfNumbers((s) => s % 2 == 0, 1, 2, 3, 4, 5, 6);
            //SumOfNumbers((s) => s % 2 == 1, 1, 2, 3, 4, 5, 6);
            //SumOfNumbers(delegate (int s) { return s % 2 == 1; },
            //    1, 2, 3, 4, 5, 6);

            SumOfNumbers(s => 
            {
                Console.WriteLine("Checking number: " + s);
                return s % 2 == 0; 
            }, 1, 2, 3, 4, 5, 6);

            //SumOfNumbers(IsOdd, 1, 2, 3, 4, 5, 6);

            //Student student = new Student(1, "Johnathan", "DoeSurnameExceedingMax", 16);
            //Validate(student);

            //NumberMethod method = IsEven;
            //method += IsOdd;
            //SumOfNumbers(method, 1, 2, 3, 4, 5, 6);


            Print<string, int> print = delegate (string w)
            {
                Console.WriteLine(w);
                return w.Length;
            };


            print += (string w) => { Console.WriteLine(w.ToUpper()); return w.Length; };
            int result = print("Hello, World!");
            Console.WriteLine("Result: " + result);


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

        public static void Validate(object obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var atts = property.GetCustomAttributes(typeof(MyMaxLengthAttribute), true);
                var value = property.GetValue(obj);
                foreach (var attObj in atts)
                {
                    if (attObj is MyMaxLengthAttribute att && value is string strValue)
                    {
                        if (strValue.Length > att.MaxLength)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{property.Name} maksimum uzunlugu kecir");
                            Console.ResetColor();
                        }
                    }
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

        public static void SumOfNumbers(Predicate<int> method, params int[] numbers)
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
        [Required]
        [MyMaxLength(5)]
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

    class MyMaxLengthAttribute : ValidationAttribute
    {
        public int MaxLength { get; set; }
        public MyMaxLengthAttribute(int maxLength)
        {
            MaxLength = maxLength;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string str)
            {
                if (str.Length > MaxLength)
                {
                    return new ValidationResult($"The length of the string must not exceed {MaxLength} characters.");
                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid string value.");
        }
    }

}

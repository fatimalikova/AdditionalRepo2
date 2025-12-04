using Additional2.Models;

namespace Additional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5 };
            //string[] strings = { "apple", "banana", "cherry" };
            //double[] doubles = { 1.1, 2.2, 3.3 };
            //PrintArray(nums);


            //    List<string> fruits = new List<string>();
            //    fruits.Add("Apple");
            //    fruits.Add("Banana");
            //    fruits.Add("Cherry");
            //    fruits.Add("Date");
            //    fruits.Add("Elderberry");
            //    fruits.Add("Fig");
            //    fruits.Add("Grape");
            //    fruits.Add("Honeydew");


            //    Console.WriteLine(fruits.Capacity);
            //    Console.WriteLine(fruits.Count);
            //    Console.WriteLine(fruits.IndexOf("Banana"));
            //    Console.WriteLine(fruits.Contains("Fig"));
            //    Console.WriteLine(fruits.Exists(x=>x=="Grape"));
            //    string[] colorsArray = fruits.ToArray();

            //    foreach (string color in fruits)
            //    {
            //        Console.WriteLine(color);
            //    }
            //}
            //public static void PrintArray<T>(T[] array)
            //{
            //    foreach (T item in array)
            //    {
            //        System.Console.WriteLine(item);
            //    }
            //}


            //int day = 4;
            //Days today = (Days)day;
            //Console.WriteLine(today);
            //Days days = Days.Wednesday;
            //if (days == Days.Wednesday)
            //{
            //    Console.WriteLine("Today is Wednesday");
            //}
            //int friday = DaysStruct.Friday;
            //Console.WriteLine(friday);

            //Animal animal = new Dog();
            //animal.Speak();

            //List<Animal> animals = new List<Animal>();
            //animals.Add(new Dog { Name = "Buddy", Age = 3, Breed = "Golden Retriever" });
            //animals.Add(new Animal { Name = "Mittens", Age = 2 });
            //animals.Add(new Dog { Name = "Max", Age = 5, Breed = "German Shepherd" });
            //animals.Add(new Animal { Name = "Whiskers", Age = 4 });

            //foreach (var a in animals)
            //{
            //    Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");
            //    //a.Speak();
            //}

            //List<T> GetAnimalsOfType<T>(List<Animal> animals) where T : Animal
            //{
            //    List<T> result = new List<T>();
            //    foreach (var animal in animals)
            //    {
            //        if (animal is T tAnimal)
            //        {
            //            result.Add(tAnimal);
            //        }
            //    }
            //    return result;
            //}
            //List<Dog> dogs = GetAnimalsOfType<Dog>(animals);
            //Console.WriteLine("\nDogs in the list:");
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Breed: {dog.Breed}");
            //}
            //Console.WriteLine();


            //MyIntList myList = new MyIntList();
            ////myList.Add("Hello");
            ////myList.Add("World");
            //myList.Add(10);
            //myList.Add(20);
            //myList.Add(30);
            //myList.Add(40);
            //Console.WriteLine($"Count: {myList.Count}");
            //myList.GetAll();
            //Console.WriteLine(myList.Get(0));



            //Student student = new Student();
            //student.Add(new Student { Name = "Alice", Age = 20 });
            //student.Add(new Student { Name = "Bob", Age = 22 });
            //Console.WriteLine($"Student Count: {student.Count}");
            //student.GetAll();
            //Console.WriteLine(student.Get(0));



            ////MyList<string> stringList = new MyList<string>();
            //MyList<int> intList = new MyList<int>();
            ////stringList.Add("Hello");
            //intList.Add(100);
            //intList.Add(200);
            //Console.WriteLine($"Count: {intList.Count}");
            //intList.GetAll();

            //MyList<Student> studentList = new MyList<Student>();
            //studentList.Add(new Student { Name = "Charlie", Age = 23 });
            //Console.WriteLine($"Student List Count: {studentList.Count}");
            //studentList.GetAll();

            //List<string> genericList = new List<string>();
            //genericList.Add("Sample");
            //genericList.Add("Test");
            //Console.WriteLine($"Generic List Count: {genericList.Count}");

            //Student[] students = new Student[]
            //{
            //    new Student { Id = 1, Name = "Alice", Age = 20 },
            //    new Student { Id = 2, Name = "Bob", Age = 22 },
            //    new Student { Id = 3, Name = "Charlie", Age = 23 }
            //};
            //Array.Sort(students);


            MyList<Student> studentList = new();
            studentList.Add(new Student { Name = "David", Age = 24 });
            studentList.Add(new Student { Name = "Eva", Age = 21 });
            Student firstStudent = studentList.Get(0);
            Console.WriteLine($"First Student: Name={firstStudent.Name}, Age={firstStudent.Age}");
            Console.WriteLine($"Student List Count: {studentList.Count}");
            studentList.GetAll();
            studentList.Clear();
            Console.WriteLine($"Student List Count after Clear: {studentList.Count}");
            //studentList.index = 0;


            //MyList<int> myList = new MyList<int, object>();
            //myList.Add(10);
            //myList.Add(20);
            //Console.WriteLine($"Count: {myList.Count}");
            //myList.GetAll();


        }


    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }


    }
    public enum Days
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday

    }

    public struct DaysStruct
    {
        public const int Sunday = 1;
        public const int Monday = 2;
        public const int Tuesday = 3;
        public const int Wednesday = 4;
        public const int Thursday = 5;
        public const int Friday = 6;
        public const int Saturday = 7;
    }
}

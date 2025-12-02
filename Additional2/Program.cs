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

            Animal animal = new Dog();
            animal.Speak();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog { Name = "Buddy", Age = 3, Breed = "Golden Retriever" });
            animals.Add(new Animal { Name = "Mittens", Age = 2 });
            animals.Add(new Dog { Name = "Max", Age = 5, Breed = "German Shepherd" });
            animals.Add(new Animal { Name = "Whiskers", Age = 4 });

            foreach (var a in animals)
            {
                Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");
                //a.Speak();
            }

            List<T> GetAnimalsOfType<T>(List<Animal> animals) where T : Animal
            {
                List<T> result = new List<T>();
                foreach (var animal in animals)
                {
                    if (animal is T tAnimal)
                    {
                        result.Add(tAnimal);
                    }
                }
                return result;
            }
            List<Dog> dogs = GetAnimalsOfType<Dog>(animals);
            Console.WriteLine("\nDogs in the list:");
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Breed: {dog.Breed}");
            }
            Console.WriteLine();

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

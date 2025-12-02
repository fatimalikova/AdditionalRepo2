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
            Days days = Days.Wednesday;
            if (days == Days.Wednesday)
            {
                Console.WriteLine("Today is Wednesday");
            }
            int friday = DaysStruct.Friday;
            Console.WriteLine(friday);



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

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


            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Date");
            fruits.Add("Elderberry");
            fruits.Add("Fig");
            fruits.Add("Grape");
            fruits.Add("Honeydew");


            Console.WriteLine(fruits.Capacity);
            Console.WriteLine(fruits.Count);
            Console.WriteLine(fruits.IndexOf("Banana"));
            string[] colorsArray = fruits.ToArray();

            foreach (string color in fruits)
            {
                Console.WriteLine(color);
            }
        }
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                System.Console.WriteLine(item);
            }
        }


        
    }
}

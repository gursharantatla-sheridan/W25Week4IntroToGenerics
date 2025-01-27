namespace Week4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            object obj = num;   // boxing

            num = (int)obj;     // unboxing


            //if (AreEqual(5.5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");



            int[] intArr = { 3, 5, 6, 4, 3, 5, 7 };
            double[] doubleArr = { 3.3, 5.5, 7.7, 5.5 };
            char[] charArr = { 'h', 'e', 'l', 'l', 'o' };

            PrintArray<int>(intArr);
            PrintArray<double>(doubleArr);
            PrintArray<char>(charArr);
        }

        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("\n\nNumber of elements: " + array.Length);

            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        // non-generic method
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}

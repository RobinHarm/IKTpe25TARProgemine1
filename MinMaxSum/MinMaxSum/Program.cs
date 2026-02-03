namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("List numbrites");

            int[] numbers = new int[10] { 2, 10, 15, 5, 4, 3, 1, 9, 8, 12 };
            ////max
            //Console.WriteLine(numbers.Max());
            ////min
            //Console.WriteLine(numbers.Min());
            ////sum
            //Console.WriteLine(numbers.Sum());
            ////average
            //Console.WriteLine(numbers.Average());

            Console.WriteLine("----------------------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani");

            //peate kasutama Array ja Sort
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
             
            //sorteerib numbrid alates suuremast väiksemani

        }
    }
}

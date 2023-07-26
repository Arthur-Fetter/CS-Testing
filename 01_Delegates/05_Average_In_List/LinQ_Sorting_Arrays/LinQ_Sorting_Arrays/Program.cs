class Program
{
    static void Main()
    {
        Console.WriteLine("Sorting arrays using LinQ!");

        Console.WriteLine("Here is the unsorted array: ");

        foreach (int number in og_arr)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();

        /*Series addition with LinQ*/
        int sum = og_arr.Sum();
        
        Console.WriteLine($"Adding all numbers in array using the Sum funcion. The result is: {sum}")
    }

    static List<int> og_arr= new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
}

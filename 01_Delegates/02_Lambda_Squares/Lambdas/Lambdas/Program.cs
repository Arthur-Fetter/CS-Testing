class Program
{
    static Func<int, int> Square = num => num * num;

    static void Main(string[] args)
    {
        Console.WriteLine($"Here is the square of the number you've chosen: {Square(4)}");
    }
}

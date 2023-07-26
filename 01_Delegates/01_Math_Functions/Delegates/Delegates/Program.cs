delegate int MathOperation(int x, int y);

class Program
{
    static MathOperation Add = (a, b) => a + b;
    static MathOperation Subtract = (a, b) => a - b;

    static int Calculate(int a, int b, MathOperation f) => f(a, b);

    static void Main(string[] args)
    {
        Console.WriteLine($"The result is {Calculate(4, 2, Subtract)}!");
    }
    
}
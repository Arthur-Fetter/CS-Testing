class Program
{
    static Func<string, bool> isUpper = str => str == str.ToUpper();

    static void Main(string[] args)
    {
        string? test_string;

        test_string = Console.ReadLine();

        if (isUpper(test_string))
        {
            Console.WriteLine("The string is uppercase!");
        }
        else
        {
            Console.WriteLine("The string is not uppercase!");
        }
    }
}

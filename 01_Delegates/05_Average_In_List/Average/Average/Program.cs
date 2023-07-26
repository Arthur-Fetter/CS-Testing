class Program
{
    static Func<List<int>, double> Average = (IntegerList) =>
    {
        double average = 0;

        foreach (int num in IntegerList)
        {
            average = average + num;
        }

        average = average / IntegerList.Count;

        return average;
    };

    
    static void Main()
    {
        List<int> SomeList = new() { 1, 2, 3, 4, 5, 6, 7, 8};

        double some_average = Average(SomeList);

        Console.WriteLine($"Here is the average: {some_average}");
    }
    
}

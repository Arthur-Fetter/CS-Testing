Filter IsEven = num => num % 2 == 0;
Filter IsOdd = num => num % 2 == 1;
Filter IsPositive = num => num > 0;

int[] some_array = { 0, 1, -2, 3, -4, 5, -6, 7, -8 };
int[] result = FilterNumbers(some_array, IsEven);

Console.WriteLine("Here are the numbers that passed the filter: ");

foreach (int num in result)
{
    Console.WriteLine(num);
}

int[] FilterNumbers(int[] arr, Filter filter)
{
    List<int> resulting_arr = new();

    foreach (int number in arr)
    {
        if (filter(number))
        {
            resulting_arr.Add(number);
        }

        Console.WriteLine(number);
    }

    return resulting_arr.ToArray();
}


delegate bool Filter(int x);
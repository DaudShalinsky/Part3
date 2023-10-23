public static class ArrayInversion
{
    public static void Start()
    {
        int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
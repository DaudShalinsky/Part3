public static class PolojitelnieVMassive
{
    public static void Start()
    {
        int[] numbers = { 1, 5, -9, -12, 1, 4, -11, -7 };

        int result = 0;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                result++;
            }
        }
        Console.WriteLine($"Число элементов больше нуля: {result}");
    }
}
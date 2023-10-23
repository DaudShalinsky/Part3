public static class Bank2
{
    public static void Start()
    {
        Console.Write("Напишите сумму вклада: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Напишите количество месяцев: ");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numberOfMonths; i++)
        {
            depositAmount += depositAmount * 0.07;
        }
        Console.WriteLine($"Сумма вклада через {numberOfMonths} месяцев составит {depositAmount}");
    }
}
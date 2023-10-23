public static class Bank
{
    public static void Start()
    {
        Console.Write("Напишите сумму вклада: ");

        string? otvetPolzovatelya = Console.ReadLine();
        double summaVklada = Convert.ToDouble(otvetPolzovatelya);
        double summaVkladaSProcentami = 0;

        if (summaVklada < 100000)
        {
            summaVkladaSProcentami = summaVklada * 0.05;
        }
        else if (summaVklada >= 100000 && summaVklada <= 200000)
        {
            summaVkladaSProcentami = summaVklada * 0.07;
        }
        else if (summaVklada > 200000)
        {
            summaVkladaSProcentami = summaVklada * 0.10;
        }
        Console.WriteLine("Начисленные проценты: " + summaVkladaSProcentami);
    }
}
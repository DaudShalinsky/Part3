public static class SravnenieSOdnim
{
    public static void Start()
    {
        Console.Write("Введите число: ");

        string? chisloPolzovatelya = Console.ReadLine();
        double otvetPolzovatelya = Convert.ToDouble(chisloPolzovatelya);

        if (otvetPolzovatelya > 5 && otvetPolzovatelya < 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
}
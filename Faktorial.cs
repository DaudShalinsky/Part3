public static class Faktorial
{
    public static void Start()
    {
        Console.WriteLine("Программа для вычисления факториала.");
        Console.Write("Напишите число: ");
        int chisloPolzovatelya = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (int i = 1; chisloPolzovatelya >= i; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Факториал {factorial}");
    }
}
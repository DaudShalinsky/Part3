public static class Sravnenie
{
    public static void Start()
    {
        Console.WriteLine("Введите первое число: ");
        string? perviyOtvet = Console.ReadLine();
        double pervoeChislo = Convert.ToDouble(perviyOtvet);

        Console.WriteLine("Ведите второе число: ");
        string? vtoroyOtvet = Console.ReadLine();
        double vtoroeChislo = Convert.ToDouble(vtoroyOtvet);

        if (pervoeChislo == vtoroeChislo)
        {
            Console.WriteLine($"{pervoeChislo} = {vtoroeChislo}");
        }
        else if (pervoeChislo < vtoroeChislo)
        {
            Console.WriteLine($"{pervoeChislo} < {vtoroeChislo}");
        }
        else
        {
            Console.WriteLine($"{pervoeChislo} > {vtoroeChislo}");
        }
    }
}
public static class Cake
{
    public static void Start()
    {
        string tort1 = "Tortik";
        string tort2 = "Tort";
        string tort3 = "Tort95";

        int tort1cena = 1507;
        int tort2cena = 3600;
        int tort3cena = 200;

        Console.Write("Муьлх торт ез хьун: ");
        string? otvetPolzovatelya = Console.ReadLine();

        if (otvetPolzovatelya.ToLower() == tort1.ToLower())
        {
            Console.WriteLine($"{tort1}ах {tort1cena} ѝом доьху");
        }
        else if (otvetPolzovatelya.ToLower() == tort2.ToLower())
        {
            Console.WriteLine($"{tort2}х {tort2cena} ѝом доьху");
        }
        else if (otvetPolzovatelya.ToLower() == tort3.ToLower())
        {
            Console.WriteLine($"{tort3}ах {tort3cena} ѝом доьху");
        }
        else
            Console.WriteLine($"{otvetPolzovatelya} йац, 1адика йойла");
    }
}
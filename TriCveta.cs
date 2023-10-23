public static class Colors
{
    public static void Start()
    {
        Console.WriteLine("Напишите три ваших любимых цвета: ");
        string? color1 = Console.ReadLine();
        string? color2 = Console.ReadLine();
        string? color3 = Console.ReadLine();
        {
            string[] colors = { color1, color2, color3 };

            string result = string.Join(", ", colors);

            Console.WriteLine(result);
        }
    }
}
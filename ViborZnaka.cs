public static class ViborZnaka
{
    public static void Start()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        {
            {
                Console.Write("Введите первое число: ");
                double pervoeChislo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double vtoroeChislo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите номер операции: ");

                int otvetPolzovatelya = Convert.ToInt32(Console.ReadLine());


                double title = 0;

                switch (otvetPolzovatelya)
                {
                    case 1:
                        title = pervoeChislo + vtoroeChislo;
                        break;
                    case 2:
                        title = pervoeChislo - vtoroeChislo;
                        break;
                    case 3:
                        title = pervoeChislo * vtoroeChislo;
                        break;
                    case 4:
                        title = pervoeChislo / vtoroeChislo;
                        break;
                    default:
                        Console.WriteLine("Операция недоступна.");
                        break;
                }
                Console.WriteLine(title);
            }
        }
    }
}
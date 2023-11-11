public static class WeatherInformation
{
    public static void Start()
    {
        int[] temperatures = new int[30];
        int[] precipitations = new int[30];

        Random number = new Random();

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = number.Next(-15, 40);
        }

        Console.WriteLine();
        for (int i = 0; i < precipitations.Length; i++)
        {
            precipitations[i] = number.Next(0, 10);
        }

        Console.WriteLine();
        Console.WriteLine("Расчитываем среднюю месячную температуру");
        int totalTemperature = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            totalTemperature += temperatures[i];
        }
        int averageTemperature = totalTemperature / temperatures.Length;
        Console.WriteLine(averageTemperature);

        int maxValue = temperatures.Max();
        int maxIndex = temperatures.ToList().IndexOf(maxValue);
        Console.WriteLine("Индекс самого жаркого дня в месяце: ");
        Console.WriteLine(maxIndex);

        int minValue = temperatures.Min();
        int minIndex = temperatures.ToList().IndexOf(minValue);
        Console.WriteLine("Индекс самого холодного дня в месяце: ");
        Console.WriteLine(minIndex);


        Console.WriteLine("Расчет общего количества осадков за месяц");
        int totalPrecipitations = 0;
        for (int i = 0; i < precipitations.Length; i++)
        {
            totalPrecipitations += precipitations[i];
        }
        Console.WriteLine(totalPrecipitations);

        Console.WriteLine("Среднее количество осадков за месяц");
        int averagePrecipitation = totalPrecipitations / precipitations.Length;
        Console.WriteLine(averagePrecipitation);

        Console.WriteLine("Количество дней с количеством осадков выше среднего");
        int[] daysWithAboveAveragePrecipitation = { };

        int x = 0;
        foreach (int precipitation in precipitations)
        {
            if (precipitation > averagePrecipitation)
            {
                Array.Resize(ref daysWithAboveAveragePrecipitation, daysWithAboveAveragePrecipitation.Length + 1);
                daysWithAboveAveragePrecipitation[x] = precipitation;
                x++;
            }
        }
        Console.WriteLine(daysWithAboveAveragePrecipitation.Length);

        Console.WriteLine("Индексы дней с заморозками и увеличением осадков по сравнению с предыдущим днем: ");

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] < 0 && precipitations[i] > precipitations[i - 1])
            {
                int frostsAndHeavyPrecipitation = i;
                Console.Write($"{frostsAndHeavyPrecipitation}, ");
            }
        }

    }
}
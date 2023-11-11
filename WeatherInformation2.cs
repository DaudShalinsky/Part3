public static class WeatherInformation2
{
    public static void Start()
    {
        List<int> temperatures = new List<int>();
        List<int> precipitations = new List<int>();

        int daysCount = 30;

        Random number = new Random();
        for (int i = 0; i < daysCount; i++)
        {
            temperatures.Add(number.Next(-15, 40));
            Console.Write(temperatures[i].ToString().PadRight(3) + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < daysCount; i++)
        {
            precipitations.Add(number.Next(0, 10));
            Console.Write(precipitations[i].ToString().PadRight(3) + " ");
        }
        Console.WriteLine();

        ShowAverageTemperature(temperatures);
        ShowHotAndColdDayIndeces(temperatures);

        Console.WriteLine("Среднее количество осадков за месяц");
        int totalPrecipitations = GetTotalPrecipitation(precipitations);
        int averagePrecipitation = totalPrecipitations / precipitations.Count;
        Console.WriteLine(averagePrecipitation);

        Console.WriteLine("Количество дней с количеством осадков выше среднего");
        List<int> daysWithAboveAveragePrecipitation = new List<int>();

        int x = 0;
        foreach (int precipitation in precipitations)
        {
            if (precipitation > averagePrecipitation)
            {
                x++;
                daysWithAboveAveragePrecipitation.Add(precipitation);
            }
        }
        Console.WriteLine(daysWithAboveAveragePrecipitation.Count);

        Console.WriteLine("Индексы дней с заморозками и увеличением осадков по сравнению с предыдущим днем: ");

        for (int i = 1; i < temperatures.Count; i++)
        {
            if (temperatures[i] < 0 && precipitations[i] > precipitations[i - 1])
            {
                int frostsAndHeavyPrecipitation = i;
                Console.Write($"{frostsAndHeavyPrecipitation}, ");
            }
        }
    }

    private static int GetTotalPrecipitation(List<int> precipitations)
    {
        int totalPrecipitations = 0;
        for (int i = 0; i < precipitations.Count; i++)
        {
            totalPrecipitations += precipitations[i];
        }

        return totalPrecipitations;
    }

    private static void ShowHotAndColdDayIndeces(List<int> temperatures)
    {
        int maxValue = temperatures.Max();
        int maxIndex = temperatures.ToList().IndexOf(maxValue);
        Console.WriteLine("Индекс самого жаркого дня в месяце: ");
        Console.WriteLine(maxIndex);

        int minValue = temperatures.Min();
        int minIndex = temperatures.ToList().IndexOf(minValue);
        Console.WriteLine("Индекс самого холодного дня в месяце: ");
        Console.WriteLine(minIndex);
    }

    private static void ShowAverageTemperature(List<int> temperatures)
    {
        Console.WriteLine("Расчитываем среднюю месячную температуру");
        int totalTemperature = 0;
        for (int i = 0; i < temperatures.Count; i++)
        {
            totalTemperature += temperatures[i];
        }
        int averageTemperature = totalTemperature / temperatures.Count;
        Console.WriteLine(averageTemperature);
    }

}
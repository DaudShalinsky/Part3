public static class WeatherInformation
{
    public static void Start()
    {
        //Создаем два массива для указания температуры и количества осадков за месяц
        int[] temperatures = new int[30];
        int[] precipitations = new int[30];

        Random number = new Random();

        Console.WriteLine("Заполняем температуры");
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = number.Next(-15, 40);
            Console.Write($"{temperatures[i]} ");
        }

        Console.WriteLine();
        Console.WriteLine("Заполняем осадки");
        for (int i = 0; i < precipitations.Length; i++)
        {
            precipitations[i] = number.Next(0, 10);
            Console.Write($"{precipitations[i]} ");
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

        Console.WriteLine("Расчет общего количества осадков за месяц");
        int totalPrecipitations = 0;
        for (int i = 0; i < precipitations.Length; i++)
        {
            totalPrecipitations += precipitations[i];
        }
        Console.WriteLine(totalPrecipitations);

        Console.WriteLine("Среднее количество осадков за месяц");
        int averagePrecipitation = totalPrecipitations /= precipitations.Length;
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
        Console.WriteLine(string.Join(" ", daysWithAboveAveragePrecipitation));

        /*foreach (int c in precipitation)
        {

            if (c > precipitations)
            {
                for (int i = 0; i < 30; i++)
                {
                    precipitationIsAboveAverage[i] = c;

                }
            }
        }*/
        /*int x = 0;
        for (int i = 0; i < precipitation.Length; i++)
        {
            if (precipitation[i] > precipitations)
            {
                x++;
                precipitationIsAboveAverage[x] = precipitation[i];
            }
        }*/






        /*int[] vseUsloviya = { };

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] < 0)
            {
                if()
            }
        }*/



    }
}
public static class WeatherInformation
{
    public static void Start()
    {
        //Создаем два массива для указания температуры и количества осадков за месяц
        int[] temperatures = new int[30];
        int[] precipitation = new int[30];

        //Заполняем массив случайными числами
        Random number = new Random();
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = number.Next(-15, 40);
            Console.WriteLine($"-- {temperatures[i]}");
        }

        for (int i = 0; i < precipitation.Length; i++)
        {
            precipitation[i] = number.Next(0, 10);
            Console.WriteLine($"__{precipitation[i]}");
        }

        decimal averageTemperature = 0;
        //Расчитываем среднюю месячную температуру
    
            for (int i = 0; i < temperatures.Length; i++)
            { averageTemperature += temperatures[i]; }

        averageTemperature /= temperatures.Length;

        Console.WriteLine(averageTemperature);


        //Расчет общего количества осадков за месяц
        decimal precipitations = 0;

            for (int i = 0; i < precipitation.Length; i++)
            { precipitations += precipitation[i]; }


        Console.WriteLine(precipitations);

        //Среднее количество осадков за месяц
        precipitations /= (decimal)precipitation.Length;

        Console.WriteLine(precipitations);


        //Количество дней с количеством осадков выше среднего
        int[] precipitationIsAboveAverage = new int [30];

     
        int x = 0;
        for (int i = 0; i < precipitation.Length; i++)
        {
            if (precipitation[i] > precipitations)
            {
                x++;
                precipitationIsAboveAverage[x] = precipitation[i];
            }
        }

        
        Console.WriteLine(precipitationIsAboveAverage.Length);




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
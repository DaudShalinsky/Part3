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
            temperatures[i] = number.Next(-40, 40);
        }

        Random numbers = new Random();
        for (int i = 0; i < precipitation.Length; i++)
        {
            precipitation[i] = number.Next(0, 10);
        }

        int averageTemperature = 0;
        //Расчитываем среднюю месячную температуру
        do
        {
            for (int i = 0; i < temperatures.Length; i++)
            { averageTemperature += temperatures[i]; }
        } while (temperatures.Length < 30);

        averageTemperature /= temperatures.Length;


        //Расчет общего количества осадков за месяц
        int precipitations = 0;
        do
        {
            for (int i = 0; i < precipitation.Length; i++)
            { precipitations += temperatures[i]; }
        } while (precipitation.Length < 30);

        //Среднее количество осадков за месяц
        precipitations /= precipitation.Length;


        //Дни с количеством осадков выше среднего
        int[] precipitationIsAboveAverage = { };

        for (int i = 0; i < precipitation.Length; i++)
        {
            if (precipitation[i] > precipitations)
            {
                precipitationIsAboveAverage[i] = precipitation[i];
            }
        }




    }
}
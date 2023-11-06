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

        Random numbers = new Random();
        for (int i = 0; i < precipitation.Length; i++)
        {
            precipitation[i] = number.Next(0, 10);
            Console.WriteLine($"__{precipitation[i]}");
        }

        int averageTemperature = 0;
        //Расчитываем среднюю месячную температуру
        do
        {
            for (int i = 0; i < temperatures.Length; i++)
            { averageTemperature += temperatures[i]; }
        } while (temperatures.Length < 30);

        averageTemperature /= temperatures.Length;

        Console.WriteLine(averageTemperature);


        //Расчет общего количества осадков за месяц
        int precipitations = 0;
        do
        {
            for (int i = 0; i < precipitation.Length; i++)
            { precipitations += precipitation[i]; }
        } while (precipitation.Length < 30);

        Console.WriteLine(precipitations);

        //Среднее количество осадков за месяц
        precipitations /= precipitation.Length;

        Console.WriteLine(precipitations);


        //Дни с количеством осадков выше среднего
        int[] precipitationIsAboveAverage = { };

        /*for (int i = 0; i < precipitation.Length; i++)
        {
            if (precipitation[i] > precipitations)
            {
                precipitationIsAboveAverage[i] = precipitation[i];
                Console.WriteLine(precipitationIsAboveAverage.Length);
            }
        }*/


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
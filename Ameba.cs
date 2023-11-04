public static class Ameba
{
    public static void Start()
    {
        /*
        C4.3. Одноклеточная амеба каждые 3 часа делится на 2 клетки.
         Определить, сколько клеток будет через 3, 6, 9, …, 24 часа,
          если первоначально была одна амеба.

          изначально - 1 амеба
          через 3 часа - 2 амебы
          через 6 часов - 4 амебы
          через 9 часов - 8 амеб
          через 12 часов - 16 амеб

        Алгоритм (от лица программиста)
        1. Создать переменную для хранения количества клеток в организме(kletkiVOrganizme)
        2. Создать переменную для хранения колчиства клеток в организме за каждые 3 часа (kletkiVOrganizmeKajdie3Chasa)
        3. Создать переменну для хранения времен удвоения(vremenaUdvoenie)           
        4. Начать цикл для симулиции времени(time)
        5. Если прошло 3 часа, 
            5.1 Удвоить kletkiVOrganizme
            5.2. Показать kletkiVOrganizme за time
            5.3. Добавить kletkiVOrganizme в массив kletkiVOrganizmeKajdie3Chasa
            5.4  Добавить time в массив vremenaUdvoenie

        6. Если прошло 24 часа, то завершить цикл.
        7. Повторить цикл
        8. Найти индекс 6 внутри vremenaUdvoenie (indexVremeni)
        9. Найти kletkiVOrganizme в kletkiVOrganizmeKajdie3Chasa по indexVremeni
        10. Показать kletkiVOrganizme
        */

        int kletkiVOrganizme = 1;

        int time = 0;
        // Одно итерация равна одному часу.

        int[] kletkiVOrganizmeKajdie3Chasa = new int[8];//1, 2, 4, 8, 16, 32...
        int[] vremenaUdvoenie = new int[8];             //0, 3, 6, 9, 12, 15, 18...

        int index = 0;


        while (time != 24)
        {
            time += 1;

            if (time % 3 == 0)
            {
                kletkiVOrganizme *= 2;
                Console.WriteLine($"Время: {time}, количество амеб: {kletkiVOrganizme}");
                kletkiVOrganizmeKajdie3Chasa[index] = kletkiVOrganizme;
                index += 1;
            }
        }

        int indexVremeni = 0;

        for (int i = 0; i < vremenaUdvoenie.Length; i++)
        {
            int momentVremeni = vremenaUdvoenie[i];
            if (momentVremeni == 6)
            {
                indexVremeni = i;
            }
        }
        int kletki = kletkiVOrganizmeKajdie3Chasa[indexVremeni];

        Console.WriteLine($"Количество клеток через 6 часов: {kletki}");


    }
}
void Task1()
{
    /*
    Задача 25:
    Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
    */

    int numberA = ReadInt("Введите число A: ");
    int numberB = ReadInt("Введите число B: ");
    ToDegree(numberA, numberB);


    // Функция возведения в степень
    void ToDegree(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
        Console.WriteLine(result);
    }

    // Функция ввода
    int ReadInt(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}

void Task2()
{
    /*
    Задача 27: 
    Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
    */

    int number = ReadInt("Введите число: ");
    int len = NumberLen(number);
    SumNumbers(number, len);


    // Функция ввода
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Функция подсчета цифр в числе
    int NumberLen(int a)
    {
        int index = 0;
        while (a > 0)
        {
            a /= 10;
            index++;
        }
        return index;
    }

    // Функция вывода суммы цифр в числе
    void SumNumbers(int n, int len)
    {
        int sum = 0;
        for (int i = 1; i <= len; i++)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}

void Task3()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]
    Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
    Console.Write("Введите ряд чисел, разделенных запятой : ");
    string? seriesOfNumbers = Console.ReadLine();

    seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

    // функция удаления пробелов из строки 
    string RemovingSpaces(string series)
    {
        string seriesNew = "";
        for (int i = 0; i < series.Length; i++)
        {
            if (series[i] != ' ')
            {
                seriesNew += series[i];
            }
        }
        return seriesNew;
    }

    //  функция  проверки на правильность ввода 
    void СheckNumber2(int series)
    {

        if (series == '0' || series == '1' || series == '2'
        || series == '3' || series == '4' || series == '5' || series == '6'
        || series == '7' || series == '8' || series == '9' || series == ','
        || series == '-')
        {
        }
        else
        {
            Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

        }
    }

    // функция  создания и заполнения массива из строки
    int[] ArrayOfNumbers(string seriesNew)
    {

        int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

        int j = 0;

        for (int i = 0; i < seriesNew.Length; i++)
        {
            string seriesNew1 = "";

            while (seriesNew[i] != ',' && i < seriesNew.Length)
            {
                seriesNew1 += seriesNew[i];
                СheckNumber2(seriesNew[i]);
                i++;
            }
            arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
            if (i < seriesNew.Length - 1)
            {
                arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
            }
            j++;
        }
        return arrayOfNumbers;
    }

    // функция  вывода массива на печать 
    void PrintArry(int[] coll)
    {
        int count = coll.Length;
        int index = 0;
        Console.Write("[");
        while (index < count)
        {
            Console.Write(coll[index]);
            index++;
            if (index < count)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
    }


    string seriesNew = RemovingSpaces(seriesOfNumbers);

    int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

    PrintArry(arrayOfNumbers);
}


while (true)
{
    Console.WriteLine("Введите номер задачи");
    int a = int.Parse(Console.ReadLine());
    if (a == 1)
    {
        Task1();
    }
    if (a == 2)
    {
        Task2();
    }
    if (a == 3)
    {
        Task3();
    }
}
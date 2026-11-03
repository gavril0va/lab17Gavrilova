int[] scores = new int[7];

for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Анализ результатов");
Console.WriteLine($"Сумма: {SumArray(scores)}");
Console.WriteLine($"Минимум: {FindMin(scores)}");
Console.WriteLine($"Максимум: {FindMax(scores)}");
Console.WriteLine($"Результатов 50 и больше: {CountAtLeast(scores, 50)}");

Console.Write("\nКакой результат найти: ");
int target = Convert.ToInt32(Console.ReadLine());
int index = FindIndex(scores, target);

if (index != -1)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Результат не найден");
}

int SumArray(int[] numbers)
{
    int sum = 0; // начальное значение уже равно первому элементу, а потом цикл прибавляет его ещё раз. Надо начинать с 0
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}

int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++; // count += number прибавляет значение числа, а не считает количество
        }
    }
    return count;
}


int FindMin(int[] numbers)
{
    int min = numbers[0]; // если все числа положительные то минимальным останется 0, что неверно. Надо брать первый элемент
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}


int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}


int FindIndex(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i; // без return — цикл доходит до конца и запоминает последнее совпадение
        }
    }
    return -1;
}

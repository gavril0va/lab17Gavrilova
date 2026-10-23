int SumArray(int[] numbers)
{
    int sum = 0; // если написать numbers[0] - начальное значение берется из массива, а не из 0
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
            count++; // count += number - вместо увеличения счетчика на 1, происходит сложение значения элемента.
        }
    }
    return count;
}



int FindMin(int[] numbers)
{
    int min = numbers[0]; //начинаем с первого элемента, а не с 0
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

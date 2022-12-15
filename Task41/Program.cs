
int N = ReadInt("Введите размер массива: ");
var numbers = InputIntArray(N);

int positiveCount = GetPositiveCount(numbers);


Console.WriteLine($"Количество чисел больше 0: {positiveCount}");

int GetPositiveCount(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count++;
    }
    return count;
}

int[] InputIntArray(int count)
{
    int[] numbers = new int[count];
    for (int i = 0; i < count; i++)
        numbers[i] = ReadInt($"Введите число {i}:");
    return numbers;
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

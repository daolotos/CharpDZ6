
int N = ReadInt("Введите размер массива: ");
int[] array = new int[N];


Console.WriteLine("Количество четных чисел: ");


int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

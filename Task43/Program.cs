
Console.WriteLine("Расчет пересечения 2х прямых y = k1*x + b1 и y = k2*x + b2");
float k1 = ReadFloat("k1 = ");
float b1 = ReadFloat("b1 = ");
float k2 = ReadFloat("k2 = ");
float b2 = ReadFloat("b2 = ");

if (k1 != k2)
{
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;

    Console.WriteLine($"Прямые пересекаются в ({x},{y})");
}
else
    Console.WriteLine("Прямые не пересекаются");

float ReadFloat(string prompt)
{
    Console.Write(prompt);
    float x = (float)Convert.ToDouble(Console.ReadLine());
    return x;
}

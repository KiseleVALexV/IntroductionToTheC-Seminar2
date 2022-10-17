// Напишите программу, которая.
int number = new random().Next(10,100);
int a1 = number / 10;
int a2 = number % 10;

Console.WriteLine(number);

if (a1 > a2)
{
    Console.WriteLine($"Наибольшая цифра в числе: {a1}");
}
if (a2 > a1)
{
    Console.WriteLine($"Наибольшая цифра в числе: {a2}");
}
if (a1 == a2)
{
    Console.WriteLine($"Цифры в числе равны");
}

Console.ReadKey();
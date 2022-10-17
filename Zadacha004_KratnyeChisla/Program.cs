// Установить является ли число2 кратным к числу1. Если нет, вывести остаток.
// 34, 5 - не кратно, остаток 4
// 16, 4 - кратно

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int resault = number1 % number2;

if (resault == 0)
{
    Console.WriteLine($"Число {number2} является кратным к числу {number1}");
}
else
{
Console.WriteLine($"Остаток: {resault}");
}

Console.ReadKey();

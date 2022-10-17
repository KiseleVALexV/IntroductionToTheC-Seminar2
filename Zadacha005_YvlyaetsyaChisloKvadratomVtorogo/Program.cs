// Написать программу, которая выясняет является ли одно число квадратом другого.
Console.WriteLine("Введите число 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Одно из чисел является квадратом другого числа");   
}
//if (number1 * number1 == number2)
//{
//    Console.WriteLine($"Число {number2} является квадратом числа {number1}");   
//}
//if (number2 * number2 == number1) 
//{
//    Console.WriteLine($"Число {number1} является квадратом числа {number2}");   
//}
//if (number1 * number1 != number2 && number2 * number2 != number1)
//{
//    Console.WriteLine("Ни одно из чисел не является квадратом другого числа");   
//}
else
{
     Console.WriteLine("Ни одно из чисел не является квадратом другого числа");   
}
Console.ReadKey();

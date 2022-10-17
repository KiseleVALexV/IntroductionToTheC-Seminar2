// Напишите программу, которая убирает вторую цифру трехзначного случайного числа.

int number = new Random().Next(100,999);
Console.WriteLine($"Случайное число : {number}");

// Console.WriteLine("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());

int resault = (number / 100) * 10 + number % 10;

Console.WriteLine($"Результат: {resault}");

Console.ReadKey();
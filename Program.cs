/* Напишите программу, которая на вход принимает
два числа и выдаёт, какое число большее, а какое меньшее.*/
//Вводим первое число
Console.WriteLine("Введите первое число:");
String input = Console.ReadLine();
int num1 = int.Parse(input);
//Вводим второе число
Console.WriteLine("Введите второе число:");
String input2 = Console.ReadLine();
int num2 = int.Parse(input2);
if (num1 > num2)
{
     Console.WriteLine($"Максимальное число: {num1}");
}
else
{
    Console.WriteLine($"Максимальное число: {num2}");
}
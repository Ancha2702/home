/*  Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.*/
Console.Clear();
//Вводим первое число
Console.WriteLine("Введите первое число:");
String input = Console.ReadLine();
int num1 = int.Parse(input);
//Вводим второе число
Console.WriteLine("Введите второе число:");
String input2 = Console.ReadLine();
int num2 = int.Parse(input2);
//Вводим  третье число
Console.WriteLine("Введите третье число:");
String input3 = Console.ReadLine();
int num3 = int.Parse(input3);

if (num1 > num2)
{ 
 if (num1 > num3)
     Console.WriteLine($"Максимальное число: {num1}");
}
else if (num2 > num3)
{
    Console.WriteLine($"Максимальное число: {num2}");
}
else if (num3 > num1)
   {
    Console.WriteLine($"Максимальное число: {num3}");
   }
   else
   {
    Console.WriteLine("Некорректные данные или числа равны");
   }

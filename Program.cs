/* Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).*/
Console.Clear();
//Вводим  число
Console.WriteLine("Введите любое число:");
String input = Console.ReadLine();
int num1 = int.Parse(input);
 if (num1%2 == 0)
 {
    Console.WriteLine("Число четное");
 }
 else 
 {
 Console.WriteLine("Число нечетное");
 }


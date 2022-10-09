/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.*/

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 99999 || num <10000)
{
    Console.WriteLine("Error");
}
else if (num/10000 == num%10 && (num/1000)%10 == (num%100)/10)
{
    Console.WriteLine($"Число {num} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом.");
}
/*Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.*/

Console.Clear();

Console.WriteLine("Введите х первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите х второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве составит {Math.Round((Distance), 2)}");
// Задача 40: Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
///суммы двух других сторон.

Console.Clear();  
Console.WriteLine("Введите сторону треугольника а = : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника b = : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника c = : ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a<b+c)&&(b<a+c)&&(c<b+a)) Console.WriteLine("Треугольник с заданными сторонами существует");
else Console.WriteLine("Треугольник с заданными сторонами не существует");
//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

// Вычисление чисел Фиббоначи
//f(1)=0
//f(2)=1
//f(n)=f(n-1)+f(n-2)
Console.Clear();  
Console.WriteLine("Введите num");
double num = Convert.ToDouble(Console.ReadLine());
int first = 0;
int second = 1;
if (num==1) Console.WriteLine(first);
if (num==2) {Console.WriteLine(first);Console.WriteLine(second);}
else 
{
    Console.WriteLine(first);
    Console.WriteLine(second);
    for (int i=3;i<=num;i++)
    {
       int k=first+second;
       Console.WriteLine(k);
       first=second;
       second=k;
    }
}
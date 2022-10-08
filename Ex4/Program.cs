//Напишите программу, которая будет преобразовывать десятичное число 
//в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
Console.Clear();  
Console.WriteLine("Введите число в десятичной СС num = : ");
int num = Convert.ToInt32(Console.ReadLine());
int size = 1;
int num1=num;
while (num1>=2)
{
    num1=num1/2;
    size++;
    
}
int [] arr = new int [size];
for (int i=0; i<size; i++)
{
    int ostatok=num%2;
    num=num/2;
    arr[i]=ostatok;
}

for (int i=size-1; i>-1; i--) Console.Write(arr[i]);

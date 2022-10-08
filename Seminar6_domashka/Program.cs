Console.Clear();
Console.WriteLine("Введите номер задачи (41, 43, 1 или 2) для проверки:");
int num = int.Parse(Console.ReadLine());
if(num==41) Task41();
else if(num==43) Task43();
else if(num==1) Task1();
else if(num==2) Task2();
else Console.WriteLine("Более задач не было задано.");

void Task41(){
   
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество вводимых чисел М = ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[M];
massiv=Input_mass(massiv);
Console.Write(String.Join(",",massiv));

int negativ_count=Get_negativ_count(massiv);
Console.WriteLine();
Console.WriteLine($"Количество отрицательных чисел = {negativ_count}");


int Get_negativ_count(int[] massiv_local){
    int i=0;
    int negativ=0;
    for (i=0;i<massiv_local.Length;i++){
      if (massiv_local[i]<0) negativ++;
    }
    return negativ;
}

int [] Input_mass(int[] massiv_local){
    Console.WriteLine("Введите числа");
    int i=0;
      for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = Convert.ToInt32(Console.ReadLine());;
    }
    return massiv_local;
}
};


void Task43(){
// Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите коэффициент к1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент к2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2) Console.WriteLine("Прямые параллельны");
else {
    double x=(b2-b1)/(k1-k2); Console.Write("x="+x);
    double y=k1*x+b1; Console.WriteLine("; y="+y);
    }
};
void Task1(){
//Дополнительная задача 1 (задача со звёздочкой): 
//Напишите программу, которая задаёт массив из n элементов, 
//которые необходимо заполнить случайными значениями 
//и сдвинуть элементы массива влево, или вправо на 1 позицию.

//[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
//[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо


Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[razmer];
massiv=Rand_mass(massiv);
Console.WriteLine("Если необходимо сдвинуть массив влево, то введите 0, вправо - 1");
int napravlenie=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первоначальный массив: "+"[ "+ string.Join(",",massiv)+" ]");
Console.WriteLine("Конечный массив: "+"[ "+ string.Join(",",RotateArr(massiv,napravlenie))+" ]");

int [] RotateArr(int [] inputArray,int naprav)
{
    int [] RotatedArr = new int [inputArray.Length];
    if (naprav==0) {
        for (int i=0; i<inputArray.Length-1; i++)
    {
        RotatedArr[i]=inputArray[i+1];
    }
    RotatedArr[inputArray.Length-1]=inputArray[0];
    }
    else
    {
        for (int i=inputArray.Length-1; i>0; i--)
    {
        RotatedArr[i]=inputArray[i-1];
    }
    RotatedArr[0]=inputArray[inputArray.Length-1];
    }
    return RotatedArr;
}

int [] Rand_mass(int[] massiv_local){
    int i=0;
    Random rnd =new Random();
    for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = new Random().Next(0, 10);;
    }
    return massiv_local;
}
}
void Task2(){
//Дополнительная задача 2 (задача со звёздочкой): Напишите программу, 
//которая задаёт массив из n элементов, которые необходимо заполнить 
//случайными значениями и определить существует ли пара соседних элементов 
//с одинаковыми значениями, при наличии такого элемента заменить его 
//на уникальное значение.

//[1,2,3,3] -> [1,2,3,4]


Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[razmer];
massiv=Rand_mass(massiv);

Console.WriteLine("Первоначальный массив: "+"[ "+ string.Join(",",massiv)+" ]");
Console.WriteLine("Конечный массив: "+"[ "+ string.Join(",",ChangeArr(massiv))+" ]");

int [] ChangeArr(int [] inputArray)
{
    int [] ChangedArr = new int [inputArray.Length];
    int zamena=11;
    ChangedArr[0]=inputArray[0];
            for (int i=1; i<inputArray.Length-1; i++)
    {
        if (inputArray[i]==inputArray[i-1])
        {
          ChangedArr[i]= zamena;
          zamena++;
        }
        else ChangedArr[i]=inputArray[i];
    }
       
    return ChangedArr;
}

int [] Rand_mass(int[] massiv_local){
    int i=0;
    Random rnd =new Random();
    for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = new Random().Next(0, 10);;
    }
    return massiv_local;
}
}
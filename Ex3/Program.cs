//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

Console.Clear();  
int [] array =FillArr(5,1,10);
Console.WriteLine("Массив: "+"[ "+ string.Join(",",array)+" ]");
Console.WriteLine("Копия массива: "+"[ "+ string.Join(",",CopyArr(array))+" ]");

int [] FillArr(int size, int min, int max)
{
    int [] filledArray = new int [size];
    for (int i=0; i<size; i++)
    {
        filledArray[i]=new Random().Next(min,max+1);
    }
    return filledArray;
}


int [] CopyArr(int [] inputArray)
{
    int [] CopyedArr = new int [inputArray.Length];
    for (int i=0; i<inputArray.Length; i++)
    {
        CopyedArr[i]=inputArray[i];
    }
    return CopyedArr;
}

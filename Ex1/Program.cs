//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
Console.Clear();  
int [] array =FillArr(5,1,10);
Console.WriteLine("[ "+ string.Join(",",array)+" ]");
Console.WriteLine("[ "+ string.Join(",",ReversArr(array))+" ]");


int [] FillArr(int size, int min, int max)
{
    int [] filledArray = new int [size];
    for (int i=0; i<size; i++)
    {
        filledArray[i]=new Random().Next(min,max+1);
    }
    return filledArray;
}


int [] ReversArr(int [] inputArray)
{
    int [] ReversedArr = new int [inputArray.Length];
    for (int i=0; i<inputArray.Length; i++)
    {
        ReversedArr[i]=inputArray[inputArray.Length-1-i];
    }
    return ReversedArr;
}

    
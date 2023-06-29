// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillArray(int size, int leftRange, int rightRange) 
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for(int i = 0; i < tempArray.Length; i++) 
     {
       tempArray[i] = rand.Next(leftRange, rightRange+1);
     }
     return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
      System.Console.WriteLine("[" + string.Join(", ", arrayForPrint)+ "]");
}


void EvenNumbers(int[] tempArray)
{    int count = 0;
    
    for(int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i]%2 == 0)
        {
            count++;
        }
    }

       System.Console.WriteLine($"Четных чисел {count}");
    
}

//-----------------------------основная часть-------------
int[] array = FillArray(4, 100,1000);
PrintArray(array);
EvenNumbers(array);


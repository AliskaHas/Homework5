//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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


void Sum(int[] tempArray)
{    int sum = 0;
    
    for(int i = 0; i < tempArray.Length; i+=2)
    {
        sum += tempArray[i];
    }


       System.Console.WriteLine($"Сумма чисел с нечетным индексом {sum}");
}   


//-----------------------------основная часть-------------
int[] array = FillArray(4, -3,5);
PrintArray(array);
Sum(array);


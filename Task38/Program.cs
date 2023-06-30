//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




 double[] FillArray(int size) 
 {  System.Console.WriteLine("Введите нижнюю границу массива: ");
    int leftRange =Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите верхнюю границу массива: ");
    int rightRange =Convert.ToInt32(Console.ReadLine());

    double[] tempArray = new double[size];
    Random rand = new Random();
    for(int i = 0; i < tempArray.Length; i++) 
      {
        tempArray[i] = Math.Round((rightRange - 1)* rand.NextDouble()+1,2);
      }
     return tempArray;
}

void PrintArray(double[] arrayForPrint)
{
      System.Console.WriteLine("[" + string.Join(",   ", arrayForPrint)+ "]");
}


 void MaxMin(double[] tempArray)
 {    double max = tempArray[0];
      double min = tempArray[0];
    
     for(int i = 1; i < tempArray.Length; i++)
    {
         if(tempArray[i] > max) max = tempArray[i];
         if(tempArray[i] < min) min = tempArray[i]; 
     }

     System.Console.WriteLine($"Разность максимального и минимального чисел равна {Math.Round((max - min), 3)}");
 }   


//-----------------------------основная часть-------------

double[] array = FillArray(4);
PrintArray(array);
MaxMin(array);


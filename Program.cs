// Написать программу которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого
// элемента или же указание, что такого элемента нет
Console.WriteLine("Введите позицию строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца");
int b = Convert.ToInt32(Console.ReadLine());



int[,] CreateArray() {
int[,] array = new int[8, 10];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
    }
} return array;

}

void PrintArray(int[,] array) {
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t ");
    }
  Console.WriteLine();
}
   
}

void Nambers(int[,] array) {
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(array.GetLength(0) < a || array.GetLength(1) < b)
        {
         break;
                
        }
        if(array[i, j] == array[a - 1, b - 1]) 
        {
            Console.WriteLine("Значение элемента = " + array[i, j]);
            return;
        }
        
    }
    
 } 
  Console.WriteLine("Такого значения нет");
}


int[,] narray = CreateArray();
PrintArray(narray);
Nambers(narray);
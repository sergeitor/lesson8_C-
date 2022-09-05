//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] matrix = new int[3,4];

for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              matrix[i,j] = new Random().Next(1,10);
           }
      }

Console.WriteLine("Заданный массив:");   

for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              Console.Write(matrix[i,j] + " ");
           }
           Console.WriteLine();
      }

Console.WriteLine("Отсортированный массив:");   


for(int i = 0; i < matrix.GetLength(0); i++)         // сортировка массива
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
             {
               for(int m = 0; m < matrix.GetLength(1)-1; m++)
               {
                if(matrix[i,m] < matrix[i,m + 1]) 
                 {
                    int number = matrix[i,m + 1];
                    matrix[i,m + 1] = matrix[i,m];
                    matrix[i,m] = number;
                 }
               }
           }
      }

for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              Console.Write(matrix[i,j] + " ");
           }
           Console.WriteLine();
      }


//    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] matrix = new int[4,4];

int minstr = 0;

int str = 0;

for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              matrix[i,j] = new Random().Next(1,10);
           }
      }
 
 Console.WriteLine("Выведен прямоугольный массив:");

for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              Console.Write(matrix[i,j] + " ");
           }
             Console.WriteLine();
      }  

 

for(int i = 0; i < matrix.GetLength(1); i++)
     {
         minstr += matrix[0,i];
     }
           


for(int i = 0; i < matrix.GetLength(0); i++)
      {
           int sum = 0;

          for(int j = 0; j < matrix.GetLength(1); j++)
           {
               sum += matrix[i,j];
           }
           
           Console.WriteLine($"Сумма элементов {i+1} строки равно: {sum}"); 

           if(minstr >= sum)
                 {
                    minstr = sum;
                    str = i;
                 }                   
      }

Console.WriteLine($"Строка {str+1} с наименьшей суммой равна {minstr}");  


//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Сколько строк 1 матрица?");

int raw = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число столбцов 1 матрица?");

int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число столбцов 2 матрицы?");

int col2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[raw,col];

for(int i = 0; i < matrix1.GetLength(0); i++)
      {
          for(int j = 0; j < matrix1.GetLength(1); j++)
           {
              matrix1[i,j] = new Random().Next(1,10);
           }
      }

int[,] matrix2 = new int[col,col2];

for(int i = 0; i < matrix1.GetLength(1); i++)
      {
          for(int j = 0; j < matrix2.GetLength(1); j++)
           {
              matrix2[i,j] = new Random().Next(1,10);
           }
      }

int[,] matrix = new int[raw,col2];


Console.WriteLine("Первая матрица:");
 for(int i = 0; i < matrix1.GetLength(0); i++)
      {
          for(int j = 0; j < matrix1.GetLength(1); j++)
           {
              Console.Write(matrix1[i,j] + "\t");
           }
           Console.WriteLine();
      }

Console.WriteLine("Вторая матрица:");
for(int i = 0; i < matrix1.GetLength(0); i++)
      {
          for(int j = 0; j < matrix1.GetLength(1); j++)
           {
              Console.Write(matrix2[i,j] + "\t");
           }
           Console.WriteLine();
      }

for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      matrix[i,j] = sum;
    }
  }

  Console.WriteLine("Произведение матриц:");
  for(int i = 0; i < matrix.GetLength(0); i++)
      {
          for(int j = 0; j < matrix.GetLength(1); j++)
           {
              Console.Write(matrix[i,j] + "\t");
           }
           Console.WriteLine();
      }





  





























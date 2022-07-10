using System;

namespace Arrays
{
    class Program
    {
        //доп задания
        static void Main(string[] args)
        {
            int[] array = GetRandom(5, -1, 8);
            Write(array);
            GetBubble(array);
            Write(array);
            Console.WriteLine("Введите минимальное и максимальные число для матрицы: ");
            int minValue = int.Parse(Console.ReadLine());
            int maxValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк и столцов в матрице: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = GetRandomMatrix(n, m, minValue, maxValue);
            WriteMatrix(matrix, n, m);
            Console.WriteLine("введите норме строки для ее суммы: ");
            int row = int.Parse(Console.ReadLine());
            int summRow = GetSummMatrixRow(matrix, n, row);
            Console.WriteLine(summRow);
            Console.WriteLine("Введите номер столбца: ");
            int column = int.Parse(Console.ReadLine());
            int summColumn = GetSummMatrixColumn(matrix, m, column);
            Console.WriteLine(summColumn);
            int summMatrix = GetSummMatrix(matrix, n, m);
            Console.WriteLine(summMatrix);
            Console.WriteLine("введите число, мы проверим, есть ли оно в матрице: ");
            int number = int.Parse(Console.ReadLine());
        }
        static int[] GetRandom(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] rndArray = new int[size];
            for (int i = 0; i < rndArray.Length; i++)
            {
                rndArray[i] = rnd.Next(min, max);
            }
            return rndArray;
        }
        static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static void GetBubble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int numb = array[i];
                        array[i] = array[j];
                        array[j] = numb;
                    }
                }
            }
        }
        static int GetSumm(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }

        //25.04.22
        static void GetCastomeRead(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"значение: {array[i]}, индекс: {i}");
            }
            Console.WriteLine();
        }
        static int GetEvenCount(int[] array)
        {
            int evenCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            return evenCount;
        }
        static int GetSumEvenCount(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    summ += array[i];
                }
            }
            return summ;
        }
        static int PositiveCount(int[] array)
        {
            int positiveCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    positiveCount++;
                }
            }
            return positiveCount;
        }
        static int PositiveSumm(int[] array)
        {
            int positive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    positive += array[i];
                }
            }
            return positive;
        }
        static int NegativeCount(int[] array)
        {
            int negativeCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeCount++;
                }
            }
            return (negativeCount);
        }
        static int NegativeSumm(int[] array)
        {
            int negativeSumm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    negativeSumm += array[i];
                }
            }
            return (negativeSumm);
        }
        static int[] GetIndexesWithNegativeValue(int[] array)
        {
            int size = NegativeCount(array);
            int[] indexes = new int[size];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indexes[j] = i;
                    j++;
                }
            }
            return indexes;
        }
        static int[] GetIndexesWithPositiveValue(int[] array)
        {
            int size = PositiveCount(array);
            int[] indexPositive = new int[size];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    indexPositive[j] = i;
                    j++;
                }
            }
            return indexPositive;
        }
        static int GetBiggerTheLastOneCount(int[] array)
        {
            int biggerTheLastOne = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    biggerTheLastOne++;
                }
            }
            return biggerTheLastOne;
        }
        static int[] GetArrayBiggerTheLastOne(int[] array)
        {
            int size = GetBiggerTheLastOneCount(array);
            int[] arrayBiggerTheLastOne = new int[size];
            for (int i = 0, j = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    arrayBiggerTheLastOne[j] = array[i + 1];
                    j++;
                }
            }
            return arrayBiggerTheLastOne;
        }
        static int GetLessTheLastOne(int[] array)
        {
            int lessTheLastOne = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    lessTheLastOne++;
                }
            }
            return lessTheLastOne;
        }
        static int[] GetArrayLessTheLastOne(int[] array)
        {
            int size = GetLessTheLastOne(array);
            int[] arrayLessTheLAstOne = new int[size];
            for (int i = 0, j = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    arrayLessTheLAstOne[j] = array[i];
                    j++;
                }
            }
            return arrayLessTheLAstOne;
        }
        static int[] GetSummArray(int[] array1, int[] array2)
        {
            int[] summArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                summArray[i] = array1[i] + array2[i];

            }
            return summArray;
        }
        static int[] GetDifArray(int[] array1, int[] array2)
        {
            int[] difArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                difArray[i] = array1[i] - array2[i];
            }
            return difArray;
        }
        static int GetArraySumm(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }
        static bool IsSummArrayMore(int[] array1, int[] array2)
        {
            int summ1 = GetArraySumm(array1);
            int summ2 = GetArraySumm(array2);
            if (summ1 > summ2)
            {
                return true;
            }
            return false;
        }
        
        static int[,] GetRandomMatrix(int n, int m, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return matrix;
        }
        static void WriteMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int GetSummMatrixRow(int[,] matrix,int n, int row)
        {
            int summ = 0;
            for (int i = 0; i <= n; i++)
            {
                summ += matrix[row, i];
            }
            return summ;
        }
        static int GetSummMatrixColumn(int[,] matrix,int m, int column)
        {
            int summ = 0;
            for (int i = 0; i <= m; i++)
            {
                summ += matrix[i, column];
            }
            return summ;
        }
        static int GetSummMatrix(int[,] matrix, int n, int m)
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    summ += matrix[i, j];
                }
            }
            return summ;
        }
        static bool IsDigit(int[,]matrix, int n, int m,  int digit)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == digit)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool IsRowDigit(int[,] matrix, int n, int m, int row)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[row, i] == row)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsColumnDigit(int[,] matrix, int n, int m, int column)
        {
            for (int i = 0; i < m; i++)
            {
                if (matrix[i, column] == column)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
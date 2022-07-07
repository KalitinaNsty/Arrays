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

        //20.04.22
        static void Main(string[] args)
        {
            Console.WriteLine("ведите слово: ");
            string text = Console.ReadLine();
            Console.WriteLine("введите символ, мы посчитаем сколько раз он встречается в тексте: ");
            char symbol = Console.ReadKey().KeyChar;
            int countSymbol = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    countSymbol++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{countSymbol}");

            Console.WriteLine("введите минимальное значение: ");
            int minNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("введите максимальное значение: ");
            int maxNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("введите количество элементов массива: ");
            int arrayNumb = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[arrayNumb];
            for (int i = 0; i < arrayNumb; i++)
            {
                array[i] = rnd.Next(minNumb, maxNumb);
            }
            PrintArray(array);

            Console.WriteLine("введите размерность массива: ");
            int nNumb = int.Parse(Console.ReadLine());
            int[] arrayInt = new int[nNumb];
            int[] counters = new int[nNumb];
            Random rnd = new Random();
            for (int i = 0; i < nNumb; i++)
            {
                arrayInt[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < nNumb; i++)
            {
                Console.WriteLine($"{arrayInt[i]} ");
            }
            Console.Write($"четные числа: ");
            for (int i = 0; i < nNumb; i++)
            {
                if (arrayInt[i] % 2 == 0)
                {
                    Console.Write($"{arrayInt[i]} ");
                }
            }
            Console.Write($"нечетные числа: ");
            for (int i = 0; i < nNumb; i++)
            {
                if (arrayInt[i] % 2 != 0)
                {
                    Console.WriteLine($"{arrayInt[i]} ");
                }
            }
            Console.Write($"числа меньше 10: ");
            for (int i = 0; i < nNumb; i++)
            {
                if (arrayInt[i] < 10)
                {
                    Console.WriteLine($"{arrayInt[i]} ");
                }
            }
            Console.Write($"отрицательные: ");
            for (int i = 0; i < nNumb; i++)
            {
                if (arrayInt[i] < 0)
                {
                    Console.WriteLine($"{arrayInt[i]} ");
                }
            }
            Console.WriteLine($"встречаются один раз в массиве: ");
            for (int i = 0; i < nNumb; i++)
            {
                for (int j = 0; j < nNumb; j++)
                {
                    if (arrayInt[i] == arrayInt[j])
                    {
                        counters[i]++;
                    }
                }
            }
            for (int i = 0; i < nNumb; i++)
            {
                if (counters[i] == 1)
                {
                    Console.Write($"{arrayInt[i]} ");
                }
            }

            Console.WriteLine("введите число для массива: ");
            int arrayNumb = int.Parse(Console.ReadLine());
            int[] arrayVar = new int[arrayNumb];
            Random rnd = new Random();
            int maxNumb = 0;
            int minNumb = 0;
            int indMax = 0;
            int indMin = 0;
            for (int i = 0; i < arrayNumb; i++)
            {
                arrayVar[i] = rnd.Next(-100, 100);
            }
            for (int i = 0; i < arrayNumb; i++)
            {
                Console.Write($"{arrayVar[i]} ");
            }
            for (int i = 0; i < arrayNumb; i++)
            {
                if (i == 0)
                {
                    minNumb = arrayVar[i];
                    maxNumb = arrayVar[i];
                }
                if (arrayVar[i] > maxNumb)
                {
                    maxNumb = arrayVar[i];
                    indMax = i;
                }
                if (arrayVar[i] < minNumb)
                {
                    minNumb = arrayVar[i];
                    indMin = i;
                }
            }

            arrayVar[indMin] = maxNumb;
            arrayVar[indMax] = minNumb;
            Console.WriteLine();
            for (int i = 0; i < arrayNumb; i++)
            {
                Console.Write($"{arrayVar[i]} ");
            }

            Console.WriteLine("введите слово для проверки: ");
            string word = Console.ReadLine();
            bool palindrom = true;
            for (int i = 0, j = word.Length - 1; i <= j; i++, j--)
            {
                if (word[i] != word[j])
                {
                    palindrom = false;
                    break;
                }
            }
            Console.WriteLine(palindrom);

            Console.WriteLine("Задайте размерность массива: ");
            int arraySomeName = int.Parse(Console.ReadLine());
            int[] arrayName = new int[arraySomeName];
            Random rnd = new Random();
            for (int i = 0; i < arrayName.Length; i++)
            {
                arrayName[i] = rnd.Next(-100, 100);
                Console.Write($"{arrayName[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("выведем массив в обратном порядке: ");
            int reverseArray = 0;
            for (int i = 0, j = arrayName.Length - 1; i < j; i++, j--)
            {
                reverseArray = arrayName[i];
                arrayName[i] = arrayName[j];
                arrayName[j] = reverseArray;
            }
            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.Write($"{arrayName[i]} ");
            }

            Console.WriteLine("Введите размерность массива: ");
            int param = int.Parse(Console.ReadLine());
            int[] arrayNambers = new int[param];
            int minNamber = 0;
            int maxNamber = 0;
            int minNamberReverse = 0;
            int maxNamberReverse = 0;
            Random rnd = new Random();
            for (int i = 0; i < param; i++)
            {
                arrayNambers[i] = rnd.Next(-100, 100);
                Console.Write($"{arrayNambers[i]} ");
            }
            for (int i = 0; i < param; i++)
            {
                if (i == 0)
                {
                    minNamber = arrayNambers[i];
                    maxNamber = arrayNambers[i];
                }
                if (minNamber < arrayNambers[i])
                {
                    minNamber = arrayNambers[i];
                    minNamberReverse = i;
                }
                if (maxNamber > arrayNambers[i])
                {
                    maxNamber = arrayNambers[i];
                    maxNamberReverse = i;
                }
            }
            arrayNambers[minNamberReverse] = maxNamber;
            arrayNambers[maxNamberReverse] = minNamber;
            Console.WriteLine();
            for (int i = 0; i < param; i++)
            {
                Console.Write($"{arrayNambers[i]} ");
            }

            int size = 10;
            int[] arrayInt = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = rnd.Next(0, 10);

            }
            double sum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                sum += arrayInt[i];
            }
            double average = 0;
            average = sum / arrayInt.Length;
            int averageMoreCount = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (average < arrayInt[i])
                {
                    averageMoreCount++;
                }
            }
            int[] arrayMore = new int[averageMoreCount];
            for (int i = 0, j = 0; j < arrayMore.Length; i++)
            {
                if (average < arrayInt[i])
                {
                    arrayMore[j] = arrayInt[i];
                    j++;
                }
            }
            int lessAverage = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (average > arrayInt[i])
                {
                    lessAverage++;
                }
            }
            int[] arrayLess = new int[lessAverage];
            for (int i = 0, j = 0; j < arrayLess.Length; i++)
            {
                if (average > arrayInt[i])
                {
                    arrayLess[j] = arrayInt[i];
                    j++;
                }
            }
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.Write($"{arrayInt[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayMore.Length; i++)
            {
                Console.Write($"{arrayMore[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayLess.Length; i++)
            {
                Console.Write($"{arrayLess[i]} ");
            }
            Console.WriteLine();
            Console.Write($"{average} ");


        }
        }
    }
}
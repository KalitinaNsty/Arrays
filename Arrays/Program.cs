using System;

namespace Arrays
{
    class Program
    {
        //доп задания
        static void Main(string[] args)
        {
            /*int[] array = GetRandom(5, -1, 8);
            Write(array);
            GetBubble(array);
            Write(array);
            Console.WriteLine("введите новую размерность: ");
            int size = int.Parse(Console.ReadLine());
            int[] reSize = Resize(array, size);
            Write(reSize);
            int value = int.Parse(Console.ReadLine());
            int[] addValue = AddValue(array, value);
            Write(addValue);
            int[] removeFirst = RemoveFirst(array);
            Write(removeFirst);
            int[] removeLast = RemoveLast(array);
            Write(removeLast);
            int[] removeAt = RemoveAt(array, 1);
            Write(removeAt);
            int[] array2 = { 0, 1, 2, 1 };
            array2 = RemoveValue(array2, 1);
            Write(array2);*/
            int[] array3 = { 4, 5, 12, 17, 1, 88, -1, 4, 0 };
            Write(array3);
            array3 = RemoveAtSkip(array3, 2, 4);
            Write(array3);
            int[] array4 = { 1, 2, 3, 4, 7 };
            int[] array5 = { 4, 2, 3, 8, 7 };
            Write(array4);
            int compare = Compare(array4, array5);
            Console.WriteLine(compare);
            int[] array6 = UnionArrays(array3, array4);
            Write(array6);
        }

        //12.07
        static int[] Resize(int[] array, int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < array.Length && i < size; i++)
            {
                newArray[i] = array[i];

            }
            return newArray;
        }
        static int[] AddValue(int[] array, int value)
        {
            int[] newArray = Resize(array, array.Length + 1);
            newArray[newArray.Length - 1] = value;
            return newArray;
        }
        static int[] RemoveFirst(int[] array)
        {
            int[] newArray = new int [array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i+1];
            }
            return newArray;
        }
        static int[] RemoveLast(int[] array)
        {
            int[] newArray = Resize(array, array.Length - 1);
            return newArray;
        }
        static int[] RemoveAt(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0, j = 0; j < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    i++;
                }
                newArray[j] = array[i];

            }
            return newArray;
        }
        static int GetCountValue(int[] array, int value)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    count += 1;
                }
            }
            return count;
        }
        static int[] RemoveValue(int[] array, int value)
        {
            int count = GetCountValue(array, value);
            int[] newArray = new int[array.Length - count];
            for (int i = 0, j = 0; i < newArray.Length && j < array.Length; i++, j++)
            {
                while (array[j] == value)
                {
                    j++;
                }
                newArray[i] = array[j];
            }
            return newArray;
        }
        static int[] RemoveAtSkip(int[] array, int startInd, int finishInd)
        {
            int count = finishInd - startInd;
            int[] newArray = new int[array.Length - count - 1];
            for (int i = 0, j = 0; i < array.Length && j < newArray.Length; j++, i++)
            {
                while ((i >= startInd) && (i <= finishInd))
                {
                    i++;
                }
                newArray[j] = array[i];
            }
            return newArray;
        }
        static int Compare(int[] array1, int[] array2)
        {
            int result = 0;
            for (int i = 0; i < array1.Length && i < array2.Length; i++)
            {
                    if (array1[i] == array2[i])
                    {
                        result++;
                    }
            }
            return result;
        }
        static int[] UnionArrays(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length+array2.Length];
            for (int i = 0, j = 0; i < array1.Length; i++, j++)
            {
                newArray[i] = array1[j];
            }
            for (int i = array1.Length, j = 0; i < newArray.Length; i++, j++)
            {
                newArray[i] = array2[j];
            }
            return newArray;
        }

        //25.04
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

        static int GetSumm(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }

        static bool IsContains(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsPalindrom(string word)
        {
            for (int i = 0, j = word.Length-1; i < j; i++, j--)
            {
                if (word[i] == word[j])
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsEvenCount(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static double ToFaringate(double celsius)
        {
            return celsius * 1.8 + 32;
        }
        static string GetAddress(string city, string street, int house, int flat)
        {
            return ($"city:{city}, street:{street}, house: {house}, flat:{flat}");
        }
        static int CountDigit(int number)
        {
            int count = 1;
            while (number > 9)
            {
                count++;
                number = number / 10;
            }
            return count;
        }
        static int SummDigit(int number)
        {
            int summ = 0;
            while (number > 0)
            {
                int digit = number % 10;
                summ += digit;
                number /= 10;
            }
            return summ;
        }

        static int GetMinValue(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    min = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int GetMaxValue(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    max = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int GetSummElement(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }
        static double GetAverage(int[] array)
        {
            double average = 0;
            double summ = GetSummElement(array);
            average = summ / array.Length;
            return average;
        }
        static int GetCountEven(int[] array)
        {
            int even = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                }
            }
            return even;
        }
        static int GetCountOdd(int[] array)
        {
            int odd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    odd++;
                }
            }
            return odd;
        }

        static int GetIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        //16.06
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
    }
}
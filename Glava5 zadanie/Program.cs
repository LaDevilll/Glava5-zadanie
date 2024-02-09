using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava5_zadanie
{
    class DoubleFactorialDemo
    {
        // Метод для вычисления двойного факториала без рекурсии
        static int CalculateDoubleFactorialIterative(int n)
        {
            int result = 1;

            // Уменьшаем n на 2 до 1 или 2 в зависимости от четности/нечетности
            while (n > 0)
            {
                result *= n;
                n -= 2;
            }

            return result;
        }

        // Метод для вычисления двойного факториала с рекурсией
        static int CalculateDoubleFactorialRecursive(int n)
        {
            // Базовый случай: если n <= 1, возвращаем 1
            if (n <= 1)
            {
                return 1;
            }

            // Рекурсивный вызов для уменьшения n на 2
            return n * CalculateDoubleFactorialRecursive(n - 2);
        }

        static void Main()
        {
            // Примеры вызова методов
            int number1 = 6;
            int number2 = 5;
            // Вычисление двойного факториала без рекурсии
            int result1 = CalculateDoubleFactorialIterative(number1);
            Console.WriteLine($"{number1}!! (без рекурсии) = {result1}");
            // Вычисление двойного факториала с рекурсией
            int result2 = CalculateDoubleFactorialRecursive(number2);
            Console.WriteLine($"{number2}!! (с рекурсией) = {result2}");
        }
    }




    class SumOfSquaresDemo
    {
        // Метод для вычисления суммы квадратов без рекурсии
        static int CalculateSumOfSquaresIterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        // Метод для вычисления суммы квадратов с рекурсией
        static int CalculateSumOfSquaresRecursive(int n)
        {
            // Базовый случай: если n равно 1, возвращаем 1
            if (n == 1)
            {
                return 1;
            }
            // Рекурсивный вызов для уменьшения n на 1 и добавления квадрата текущего числа
            return n * n + CalculateSumOfSquaresRecursive(n - 1);
        }

        static void Main()
        {
            // Примеры вызова методов
            int number = 6;
            // Вычисление суммы квадратов без рекурсии
            int result1 = CalculateSumOfSquaresIterative(number);
            Console.WriteLine($"Сумма квадратов (без рекурсии) = {result1}");
            // Вычисление суммы квадратов с рекурсией:
            int result2 = CalculateSumOfSquaresRecursive(number);
            Console.WriteLine($"Сумма квадратов (с рекурсией) = {result2}");
            // Проверка результата формулой
            int formulaResult = number * (number + 1) * (2 * number + 1) / 6;
            Console.WriteLine($"Проверка формулой: {formulaResult}");
        }
    }




    class SumOfSquaresDemo3
    {
        // Метод для вычисления суммы квадратов без рекурсии
        static int CalculateSumOfSquaresIterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        // Метод для вычисления суммы квадратов с рекурсией
        static int CalculateSumOfSquaresRecursive(int n)
        {
            // Базовый случай: если n равно 1, возвращаем 1
            if (n == 1)
            {
                return 1;
            }
            // Рекурсивный вызов для уменьшения n на 1 и добавления квадрата текущего числа
            return n * n + CalculateSumOfSquaresRecursive(n - 1);
        }

        static void Main()
        {
            // Примеры вызова методов
            int number = 6;
            // Вычисление суммы квадратов без рекурсии
            int result1 = CalculateSumOfSquaresIterative(number);
            Console.WriteLine($"Сумма квадратов (без рекурсии) = {result1}");
            // Вычисление суммы квадратов с рекурсией:
            int result2 = CalculateSumOfSquaresRecursive(number);
            Console.WriteLine($"Сумма квадратов (с рекурсией) = {result2}");
            // Проверка результата формулой:
            int formulaResult = number * (number + 1) * (2 * number + 1) / 6;
            Console.WriteLine($"Проверка формулой: {formulaResult}");
        }
    }





    class CharArrayToIntegerArrayDemo
    {
        // Метод для преобразования символьного массива в целочисленный массив:
        static int[] ConvertCharArrayToIntArray(char[] charArray)
        {
            int[] intArray = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                intArray[i] = (int)charArray[i];
            }
            return intArray;
        }

        static void Main()
        {
            // Пример вызова метода:
            char[] charArray = { 'A', 'B', 'C', '1', '2', '3' };
            // Вызов метода для преобразования символьного массива в целочисленный массив:
            int[] intArray = ConvertCharArrayToIntArray(charArray);
            // Вывод результата:
            Console.WriteLine("Символьный массив:");
            Console.WriteLine(string.Join(" ", charArray));
            Console.WriteLine("Целочисленный массив (коды символов):");
            Console.WriteLine(string.Join(" ", intArray));
        }
    }




    class AverageArrayDemo
    {
        // Метод для вычисления среднего значения элементов целочисленного массива:
        static double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                // Если массив пуст или null, возвращаем NaN (не число) или можно выбрать другое значение по умолчанию.
                return double.NaN;
            }
            int sum = 0;
            // Вычисляем сумму элементов массива:
            foreach (int element in array)
            {
                sum += element;
            }
            // Вычисляем среднее значение:
            return (double)sum / array.Length;
        }

        static void Main()
        {
            // Пример вызова метода:
            int[] array = { 5, 10, 15, 20, 25 };
            // Вызов метода для вычисления среднего значения элементов массива:
            double average = CalculateAverage(array);
            // Вывод результата:
            Console.WriteLine("Целочисленный массив:");
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine($"Среднее значение: {average}");
        }
    }




    class SwapPairsInArrayDemo
    {
        // Метод для обмена попарно элементов символьного массива:
        static void SwapPairs(char[] charArray)
        {
            int length = charArray.Length;
            for (int i = 0; i < length / 2; i++)
            {
                // Обмен элементов попарно:
                char temp = charArray[i];
                charArray[i] = charArray[length - 1 - i];
                charArray[length - 1 - i] = temp;
            }
        }

        static void Main()
        {
            // Пример вызова метода:
            char[] charArray = { 'A', 'B', 'C', 'D', 'E' };
            // Вызов метода для обмена попарно элементов массива:
            SwapPairs(charArray);
            // Вывод результата:
            Console.WriteLine("Одномерный символьный массив до обмена:");
            Console.WriteLine(string.Join(" ", charArray));
            Console.WriteLine("Одномерный символьный массив после обмена попарно:");
            Console.WriteLine(string.Join(" ", charArray));
        }
    }


    class OverloadedMethodDemo
    {
        // Перегруженный метод для целочисленных аргументов:
        static int[] GenerateIntArray(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Начальное значение должно быть меньше или равно конечному значению.");
            }
            int[] resultArray = new int[end - start + 1];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = start + i;
            }
            return resultArray;
        }

        // Перегруженный метод для символьных аргументов:
        static char[] GenerateCharArray(char start, char end)
        {
            if (start > end)
            {
                throw new ArgumentException("Начальный символ должен быть меньше или равен конечному символу.");
            }
            char[] resultArray = new char[end - start + 1];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = (char)(start + i);
            }
            return resultArray;
        }

        static void Main()
        {
            // Примеры вызова методов:
            int[] intArray = GenerateIntArray(2, 4);
            char[] charArray = GenerateCharArray('B', 'D');
            // Вывод результатов:
            Console.WriteLine("Сгенерированный целочисленный массив:");
            Console.WriteLine(string.Join(" ", intArray));
            Console.WriteLine("Сгенерированный символьный массив:");
            Console.WriteLine(string.Join(" ", charArray));
        }
    }



    class MinMaxArrayDemo
    {
        // Метод для обработки произвольного количества целочисленных аргументов:
        static int[] FindMinMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                // Если аргументы отсутствуют, возвращаем пустой массив.
                return new int[0];
            }
            int min = numbers[0];
            int max = numbers[0];
            // Находим минимальное и максимальное значения среди аргументов:
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }
            // Возвращаем массив из двух элементов: минимального и максимального значения.
            return new int[] { min, max };
        }

        static void Main()
        {
            // Примеры вызова метода:
            int[] numbers1 = { 5, 10, 3, 8, 7 };
            int[] numbers2 = { -2, 0, 15, -7, 12, 5 };
            // Вызов метода для обработки произвольного количества целочисленных аргументов:
            int[] result1 = FindMinMax(numbers1);
            int[] result2 = FindMinMax(numbers2);
            // Вывод результатов:
            Console.WriteLine("Массив 1: " + string.Join(" ", numbers1));
            Console.WriteLine($"Минимальное и максимальное значения: {result1[0]}, {result1[1]}");
            Console.WriteLine("\nМассив 2: " + string.Join(" ", numbers2));
            Console.WriteLine($"Минимальное и максимальное значения: {result2[0]}, {result2[1]}");
        }
    }



    class AppendTextDemo
    {
        // Метод для добавления символьных значений в конец текста:
        static string AppendText(string originalText, params char[] characters)
        {
            // Создаем новую строку, добавляя символы в конец исходного текста:
            foreach (char character in characters)
            {
                originalText += character;
            }
            return originalText;
        }

        static void Main()
        {
            // Пример вызова метода:
            string initialText = "Привет, мир!";
            char[] additionalChars = { ' ', 'Э', 'т', 'о', ' ', 'д', 'о', 'п', 'о', 'л', 'н', 'е', 'н', 'и', 'е' };
            // Вызов метода для добавления символьных значений в конец текста:
            string resultText = AppendText(initialText, additionalChars);
            // Вывод результата:
            Console.WriteLine("Исходный текст: " + initialText);
            Console.WriteLine("Символы для добавления: " + string.Join(" ", additionalChars));
            Console.WriteLine("Результат после добавления: " + resultText);
        }
    }

}

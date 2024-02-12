
// // ЗАДАЧА № 1

// class Program
// {
//     static int SumOfDigits(int n)
//     {
//         int sum = 0;
//         while (n != 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//         return sum;
//     }

//     static void Main()
//     {
//         while (true)
//         {
//             Console.Write("Введите целое число или 'q' для выхода: ");
//             string userInput = Console.ReadLine()!;

//             if (userInput == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }
//             else if (int.TryParse(userInput, out int num))
//             {
//                 if (SumOfDigits(num) % 2 == 0)
//                 {
//                     Console.WriteLine($"Сумма цифр числа {num} чётная. Программа завершена.");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода.");
//             }
//         }
//     }
// }

// ЗАДАЧА 2

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int[] numbers = new int[100]; // Создаем массив из 100 элементов

//         // Заполняем массив случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//         }

//         int evenCount = 0;

//         // Подсчитываем количество четных чисел в массиве
//         foreach (int num in numbers)
//         {
//             if (num % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine("Сгенерированный массив трехзначных чисел:");
//         foreach (int num in numbers)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine("nКоличество четных чисел в массиве: " + evenCount);
//     }
// }

// ЗАДАЧА 3

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
        int length = array.Length;

        Console.WriteLine("Исходный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        // Переворачиваем массив
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }

        Console.WriteLine("nПеревернутый массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
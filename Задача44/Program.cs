// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Решение задачи без использования массива:

// Console.Write("Введите число n: ");
// string nStr = Console.ReadLine();
// int n = int.Parse(nStr);

// int a = 0;
// int b = 1;

// Console.Write(a + " " + b + " ");

// for (int i = 2; i < n; i++)
// {
//     int с = a + b;
//     Console.Write(с + " ");
//     a = b;
//     b = с;
// }


// Решение задачи с использованием массива:

const int N = 5;

int[] Fibonacсi = new int[N];

Fibonacсi[0] = 0;
Fibonacсi[1] = 1;

for(int i = 2; i < Fibonacсi.Length; i++)
{
    Fibonacсi[i] = Fibonacсi[i - 1] + Fibonacсi[i - 2];
}
Console.WriteLine(string.Join(", ", Fibonacсi));


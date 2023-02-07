// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());

// Fibonacci(num);
// void Fibonacci(int n)
// {
//     int first = 0, second = 1;
//     Console.Write($"Если N = {num} -> {first} {second} ");
//     for (int i = 2; i <= num; i++)
//     {
//         int newNumber = first + second;
//         Console.Write($"{newNumber} ");
//         first = second;
//         second = newNumber;
//     }
// }

int[] result= FiboArray(num);
PrintArray(result);


int[] FiboArray(int arr)
{
    int[] fiboArray = new int[arr];
    fiboArray[0] = 0;
    fiboArray[1] = 1;
    for (int i = 2; i < arr; i++)
    {
        fiboArray[i] = fiboArray[i - 2] + fiboArray[i - 1];
    }
    return fiboArray;
}

void PrintArray (int[] arr) 
{
    Console.Write("["); 
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    Console.Write("]");
}
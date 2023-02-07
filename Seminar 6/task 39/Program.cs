// Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
// [7, 8 , 9] -> [9, 8, 7]

int[] arr = CreateArrayRndInt(7, 1, 9);
PrintArray(arr);
Console.WriteLine();
ReverseArray(arr);
PrintArray(arr);
Console.WriteLine();
//следующая команда встроенна в vs code
Array.Reverse(arr);
PrintArray(arr);






void ReverseArray(int[] array) // Метод для переворачивания массива
{
    for (int i = 0; i < array.Length / 2; i++) // для числа в середине и чтобы выйти из условия правильно ставится /2
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[] CreateArrayRndInt (int size, int min, int max) 
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++) 
    {
        arr[i] = rnd.Next(min, max + 1); 
    }
    return arr; 
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
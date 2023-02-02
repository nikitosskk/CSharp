// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.WriteLine("Введите пятизначное число: ");
//         string number = Console.ReadLine();

//         void CheckingNumber(string number)
//         {
//             if (number[0] == number[4] || number[1] == number[3])
//             {
//                 Console.WriteLine($"Число: {number} - является палиндромом.");
//             }
//             else Console.WriteLine($"Число: {number} - не является палиндромом.");
//         }

//         if (number!.Length == 5)
//         {
//             CheckingNumber(number);
//         }
//         else Console.WriteLine($"Ошибка ввода данных");


// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Numbers(int number)

{
    if (number[0] == number[4] || number[1] == number[3])
        Console.WriteLine("Число является палиндромом");
    if (i[0] == i[4] && i[1] == i[3])
        Console.WriteLine("Число не является палиндромом");

}

/*
Задача 1: Программа запрашивает натуральное число M, пользователь вводит с 
клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write("Введите числа через пробел: ");
string[] numArray = Console.ReadLine().Split(" ");

Console.WriteLine(String.Join(" , ", numArray));

int counter = 0;
for (int i = 0; i < numArray.Length; i++)
{

    if (Convert.ToInt32(numArray[i]) > 0) { counter++; }
}
Console.WriteLine();
Console.WriteLine("Чисел больше 0: " + counter);

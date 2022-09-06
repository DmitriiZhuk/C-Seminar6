/*
Задача 2: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Рекомендую учесть три возможных случая расположения двух прямых.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите b1 k1 b2 k2 через пробел: ");
string[] numArray = Console.ReadLine().Split(" ");

double b1 = Convert.ToDouble(numArray[0]),
       k1 = Convert.ToDouble(numArray[1]),
       b2 = Convert.ToDouble(numArray[2]),
       k2 = Convert.ToDouble(numArray[3]);
// y = k1 * x + b1, y = k2 * x + b2;
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = (b2 - b1)
// x * (k1 - k2) = (b2 - b1)
// x = (b2 - b1) / (k1 - k2)

if ((k1 - k2) == 0)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine(x);
    Console.WriteLine(y);

}

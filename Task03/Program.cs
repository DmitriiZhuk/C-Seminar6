/*

*/


//1 Создаю массив
Console.Write("Введите размер массива: ");
int arrNum = Convert.ToInt32(Console.ReadLine());
int[] numbersArray = new int[arrNum];

// 2 Заполняю массив случайными числами
Random rnd = new Random();
for (int i = 0; i < arrNum; i++)
{
    numbersArray[i] = rnd.Next(1, 100);
}
Console.WriteLine("Содержимое  массива = " + string.Join(" ", numbersArray));

// 3 Считаю сумму произведений пар чисел
int pairSumProizved = 0;
for (int j = 0; j < (numbersArray.Length / 2); j++)
{
    pairSumProizved = pairSumProizved + numbersArray[j] * numbersArray[numbersArray.Length - (j + 1)];
}
Console.WriteLine("Сумма произведений пар чисел = " + pairSumProizved);

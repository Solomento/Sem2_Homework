/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int CutNum (int num)
{
    int tens = num / 10;
    int result = tens % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = CutNum(num);
Console.Write($"Новая версия {num} это {num1}");
*/

//Напишите программу, которая выводит третью цифру заданного числа.

int CutNum(int[] num)
{
    int count = num.Length;
    int index = 0;
    int pos = -1;
    while(index < count)
    {
        if(num[index] == num[2])
            pos = num[2];
        index++;
    }
    return pos;
}

Console.Write("Введите колличесво цифр числа: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] num = new int[elementsCount];
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"Введите цифру числа по порядку {i}: ");
    num[i] = int.Parse(Console.ReadLine());
}
int num1 = CutNum(num);
Console.Write("Вывод цифры: " + num1);
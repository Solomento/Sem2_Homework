//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа

/*
int CutNum (int num)
{
    int tens = num / 10;
    int result = tens % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = CutNum(num);
Console.Write($"Вторая цифра числа это: {num1}");
*/


//Напишите программу, которая выводит третью цифру 
//заданного числа.

/*
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result; 
}
    
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (ThirdDigit(num1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Третья цифра: {ThirdDigit(num1)}");
*/


/* Худший вариант для пользователя
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

Console.Write("Введите колличество цифр числа: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] num = new int[elementsCount];
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"Введите цифру числа по порядку {i}: ");
    num[i] = int.Parse(Console.ReadLine());
}
int num1 = CutNum(num);
Console.Write("Вывод цифры: " + num1);
*/


//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, 
//и проверяет, является ли этот день выходным.

/*
bool DayWeek(int num1)
{
    if (num1== 7 || num1== 6) return true;
    else return false;
}

Console.Write("Введите день недели по счету: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = DayWeek(num);
Console.Write(result);
*/
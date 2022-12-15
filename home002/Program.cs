// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summa(int C)
{
    int res = 0;
    while ((C / 10 != 0) || (C % 10 !=0))
    {
        res = res + C % 10;
        C = C / 10;
    }
    return Math.Abs(res);
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввести число
int number = EnterData("Введите число: ");
// найти сумму цифр числа
int summ = Summa(number);
// вывести результат на экран
Console.WriteLine(summ);

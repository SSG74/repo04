// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B (без использования Math.Pow).

int Multi(int X, int Y)
{
    int res = 1;
    for (int count = 0; count < Y; count++)
    {
        res = res * X;
    }
    return res;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// ввести число А
int A = EnterData("Введите число А: ");
// ввести число В
int B = EnterData("Введите число B: ");
// возвести число А в степень В
int C = Multi(A, B);
// вывести результат на экран
Console.WriteLine(C);
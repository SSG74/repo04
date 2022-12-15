// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateMassiv(int el)
{
    int[] array = new int[el];
    for (int i = 0; i < el; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}


// Задать массив из 8 случайн;
int[] arr = CreateMassiv(8);
// Вывести массив на экран
Console.WriteLine(String.Join(", ", arr));
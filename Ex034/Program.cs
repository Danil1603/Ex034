/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/



int[] InitArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(99,999);
    }
    return result;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool numberIsExist = false;

var count = 0;
int[] array = InitArray(5);
Print(array);
for (int i = 0; i < array.Length; i++)
{
    if((array[i] % 2 == 0))
    {
        count++;
        numberIsExist = true;
    }
}

if(numberIsExist)
{
    Console.WriteLine($"Четных чисел {count} ");
}
else
{
    Console.WriteLine("Нет четнs[] числа");
}


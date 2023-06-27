// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int Chetnoe(int[] massive)
{
    int chetnoeChislo = 0;
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] %2 == 0)
        {
            count++;
            chetnoeChislo = count;
            
        }
    }
    return count;
}

int[] myArray = GetRandomArray();
int chetnoeChislo = Chetnoe(myArray);

Console.WriteLine($"[ {String.Join(", ", myArray)} ]");
Console.WriteLine($"Количество Четных Чисел в Массиве = {chetnoeChislo}");
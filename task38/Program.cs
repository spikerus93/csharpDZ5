// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// (не использовать стандартные функции/методы)
// [3 7 22 2 78] -> 76

int[] GetRandomArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 100);
    }
    return array;
}


int RazOfMaxMin(int[] massive)
{
    int numberOfMax = massive[0];
    int numberOfMin = massive[0];
    int i = 0;
    while (i < massive.Length)
    {
        if (numberOfMax < massive[i])
        {
            numberOfMax = massive[i];

        }
        if(numberOfMin > massive[i])
        {
            numberOfMin = massive[i];
        }
        i++;
    }
    return numberOfMax-numberOfMin;
}

int[] myArray = GetRandomArray();
int RazOfMaxMin1 = RazOfMaxMin(myArray);
Console.WriteLine($"{RazOfMaxMin1}");
Console.WriteLine($"[ {String.Join(" ,", myArray)} ]");

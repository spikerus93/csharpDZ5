//  Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()
{
    int[] array = new int[4];
    for(int i =0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-10, 100);
    }
     return array;        
}

int Chislo (int[]massive)
{
    int count = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(i%2!=0)
        {
            count +=massive[i];

            Console.WriteLine(massive[i]);
        }
        }
    return count;
}
int[] myArray = GetRandomArray();
int myChislo = Chislo(myArray);

Console.WriteLine($"[ {String.Join(", ", myArray)} ]");
Console.WriteLine($"Cумма Нечетных индексов = {myChislo}");
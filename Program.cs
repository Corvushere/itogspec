

    Console.WriteLine("Введите размер массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int size = n;
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите " + (i + 1) + " элемент массива из " + n);
        array[i] = Console.ReadLine(); ;
    }
Console.WriteLine("Исходный массив");
    for (int i = 0; i < n; i++)
    {
        
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 Console.WriteLine("Отсортированный массив");
 for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(result[i] + " ");
    }
    Console.WriteLine();

 
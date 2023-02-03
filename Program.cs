Main();
void Main()
{
    Console.WriteLine("Введите размер массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int size = n;
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите " + (i + 1) + " элемент массива из " + n);
        array[i] = Console.ReadLine(); ;
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

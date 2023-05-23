int[] GenerationArray(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

int DifferenceMaxAndMin(int[] array)
{
    return array.Max() - array.Min();
}

Console.WriteLine("Введите размер массива: ");
string number = Console.ReadLine();
if(int.TryParse(number, out int num))
{
    int[] array = GenerationArray(num);

    Console.WriteLine($"Массив = [{String.Join(", ", array)}]\n");
    Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {DifferenceMaxAndMin(array)}");
}
else
{
    Console.WriteLine("\nВ веденных данных присутсвует специальный символ или буква! Программа остановлена!");
}
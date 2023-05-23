int[] GenerationArray(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int SearchForEvenNumbers(int[] array)
{
    int SumCount = 0;
    foreach (int item in array)
    {
        if(item % 2 == 0)
        {
            SumCount += 1;
        }
    }
    return SumCount;
}


 
Console.WriteLine("Введите размер массива: ");
string number = Console.ReadLine();
if(int.TryParse(number, out int num))
{
    int[] array = GenerationArray(int.Parse(number));

    Console.WriteLine($"Массив = [{String.Join(", ", array)}]\n");
    Console.WriteLine($"Сумма четных чисел в массиве = {SearchForEvenNumbers(array)}");
}
else
{
    Console.WriteLine("\nВ веденных данных присутсвует специальный символ или буква! Программа остановлена!");
}

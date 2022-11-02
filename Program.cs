//___________________Задача 34.
/*int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
     return res;
}
int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}*/

//________________Задача 36
/*int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма четных элементов в массиве = {GetSumOdd(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}
    int GetSumOdd(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1) sum += array[i];
        }
        return sum;
    }*/
//_____________________Задача 38
/*Console.WriteLine("Введи размерность");
int m = int.Parse(Console.ReadLine()!);
double[] startArray = new double[m] ;
FillArray(startArray);
Console.WriteLine($"[{String.Join(" ", startArray)}]");
Console.WriteLine($"Разница = {GetDifference(startArray):f2}");

void FillArray(double[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        matr[i] = new Random().NextDouble();
    }
}
double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}*/
int[] GenerateArr(int n, int min, int max)
{
    int[] arrayNum = new int[n];
    Random random = new Random();
    for (int i = 0; i < arrayNum.Length; arrayNum[i++] = random.Next(min, max + 1))
    {

    }
    return arrayNum;
}

void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(",", array)}]\n");
}

int MinMax(int[] array)
{
    int min = 0;
    int max = 0;
    int minindex = 0;
    int maxindex = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxindex])
        {
            max = array[i];
            maxindex = i - 1;
            i++;
        }
        else
        {
            max = array[maxindex];
            maxindex = i;
        }






        if (array[i] < array[minindex])
        {
            min = array[i];
            minindex = i - 1;
            i++;
        }
        else
        {
            min = array[minindex];
            minindex = i;
        }




    }
    int result = max - min;
    return result;


}
int[] array = GenerateArr(10, 1, 10);
PrintArray(array);

int minmax = MinMax(array);
Console.WriteLine($"Разность между максимальным и минимальным значением: {minmax}");
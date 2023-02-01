int[] GenerateArr(int n, int min, int max)
{
    int[] arrayNum = new int[n];
    Random random = new Random();
    for (int i = 0; i < arrayNum.Length; arrayNum[i++] = random.Next(min, max + 1))
    {

    }
    return arrayNum;
}

void PrintArray(int [] array)
{
    Console.Write($"[{String.Join(",",array)}]\n");
}

int SummElements(int [] array)
{
    int result=0;
    for (int i =1; i < array.Length; i++)
    {
        
            if(i%2!=0)
        {
            result+=array[i];
        }

    }
    return result;
}
int[] array = GenerateArr(10,-100,100);
PrintArray(array);

int summ =SummElements(array);
Console.WriteLine($"Сумма элеметов стоящих на нечетных позициях массива: {summ}");

//Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

Console.WriteLine("Массив:");
int Size = 8;
PrintArray(RandomArray(Size));

int[] RandomArray(int Arg)
{
    int[] Array = new int[Arg];
    for (int i = 0; i < Arg; i++)
    {
        Array[i] = new Random().Next(0, 9);
    }
    return Array;
}

void PrintArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++) Console.Write(Arr[i] + " ");

}
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num>0)
{
    int A = num % 10;
    num = num/10;
    sum=sum+A;
}
Console.WriteLine($"сумма всех числел равно:{sum}");
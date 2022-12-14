Console.Clear();
int k = 1;
Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень");
int b = int.Parse(Console.ReadLine());
for (int i = 1; i <= b; i++)
{
    k = k * a ;
}
Console.WriteLine(k);
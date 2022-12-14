Console.Clear();
int sum = 0;
Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
 while (a > 0)
 {
    sum = sum + a % 10;
    a = a /10 ;
 }
 Console.WriteLine(sum);
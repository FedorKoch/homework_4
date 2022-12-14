Console.Clear();
int b = 0;
Console.WriteLine("введите количество элементов массива");
int a = int.Parse(Console.ReadLine());
int[] mas = new int[a];
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine("введите элемент массива");
     b = int.Parse(Console.ReadLine());
   mas[i] = b;
}
var str = string.Join(" ", mas);
Console.WriteLine(str);
// See https://aka.ms/new-console-template for more information

static void Print32Str(int n)
{
    for (int i = 31; i >=0; i--)
    {
        var str = ( n & (1 << i)) == 0 ? "0" : "1";
        Console.Write(str);
    }
}


Print32Str(2);
Console.WriteLine();
Print32Str(-1);
Console.WriteLine();
Console.WriteLine(int.MinValue);
Console.WriteLine(-Math.Pow(2,31));
Print32Str(int.MinValue);

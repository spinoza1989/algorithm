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

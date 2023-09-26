Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 10;
int b1 = 12;
int c1 = 8;

int a2 = 102;
int b2 = 1232;
int c2 = 80;

int a3 = 1011;
int b3 = 1222;
int c3 = 8;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);

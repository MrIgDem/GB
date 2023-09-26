int[] mass = {11, 22, 33, 44, 55, 66, 77, 44, 88};
int n = mass.Length;

int find = 44;
int index = 0;

while(index < n)
{
    if(mass[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
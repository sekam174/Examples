int[] array = { 41, 54, 83, 54, 45, 26, 37, 68, 19};

int n = array.Length;
int find = 54;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

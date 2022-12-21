Console.Write("Enter an array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
}
Console.WriteLine($"[{string.Join(", ", array)}]");



int[] arr = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    arr[i] = array[i];
}

Console.WriteLine($"[{string.Join(", ", arr)}]");


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Method1(int numb)
{
   int i = 0;
   while (numb > 0)
   {
      numb = numb / 2;
      i++;
   }
   return i;
}

int[] array = new int[Method1(n)];
int b = array.Length - 1;
while (n > 0)
{
   array[b] = n % 2;
   n = n / 2;
   b--;
}
Console.WriteLine(string.Join("", array));
// int div = 0;
// int mult = 0;
// int nul = 0;
// int i = 0;
// int[] array = new int{i};
// while (i < n)
// {
//    div = n / 2;
//    mult = div * 2;
//    nul = n - mult;
//    n = div;
//    i++;
//    Console.WriteLine(array[i] = nul);
// }

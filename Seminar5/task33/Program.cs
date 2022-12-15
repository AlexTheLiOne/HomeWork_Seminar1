// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GetRandomMassive(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

// true - element found, false - element not found
bool isNumberInArray(int[] array, int findNumber)
{
    bool res = false; // originally we suppose, there's no element in array
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findNumber)
        {
            res = true;
            break;
        } 
    }
    return res;
} 


const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
// const int FINDNUMBER = 5;

Console.WriteLine("Enter a number: ");
int findNumber2 = Convert.ToInt32(Console.ReadLine());

int[] arr = GetRandomMassive(SIZE, LEFTRANGE, RIGHTRANGE);
Console.Write($"[{string.Join(", ", arr)}]");

bool result = isNumberInArray(arr, findNumber2);
if (result == true)
{
    Console.WriteLine(" -> Yes");
}
else
{
    Console.WriteLine(" -> No");
}
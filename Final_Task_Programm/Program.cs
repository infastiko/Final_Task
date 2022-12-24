// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

Console.Write("Введите желаемую длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(num);
Console.WriteLine();
PrintArray(array);
string[] newArray = new string[array.Length];

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
}
Console.WriteLine();
PrintArray(newArray);

string[] FillArray(int size)
{
    string[] arr = new string[size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите желаемый элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

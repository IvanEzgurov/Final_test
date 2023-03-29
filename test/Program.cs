// Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string [] startArray = new string [6] {"1236", "start", "12", "exe", "-45", "date"};
string [] finalArray = new string [startArray.Length];
int count = 0;
void SortArray(string[] startArray, string [] finalArray)
{
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
            finalArray[count] = startArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1)
        {
            Console.Write($"{array[i]}");
            Console.Write("]");
        }
        else
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
SortArray(startArray, finalArray);
Array.Resize(ref finalArray, count);
PrintArray(finalArray);

string[] array = new string [4] {"hello", "2", "word", ":-)"};
string[] newArray = new string[array.Length];

void Array(string[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[index] = array[i];
        index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(null != array[i])
        {   
            Console.Write($"{array[i]},\t");
        }
    }
}

Console.Write($"из исходного массива -> ");
Array(array);
PrintArray(array);
Console.WriteLine();
Console.Write($" -> получаем массив массив строк ->");
PrintArray(newArray);


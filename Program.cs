string[] FirstArray = new string [7] { "Hello", "Russia", "One", "Burn", "Tag", "Su", "Target" };
string[] SecondArray = new string[FirstArray.Length];

void SortArray(string[] array1, string[] array2)
{
    int help = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
        array2[help] = array1[i];
        help++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

SortArray(FirstArray, SecondArray);
PrintArray(SecondArray);
string[] FirstArray = { "Hello", "Russia", "One", "Burn", "Tag", "Su", "Target" };
string[] SecondArray = new string[FirstArray.Length];

void SortArray(string array1, string array2)
{
    int Count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <=3);
        {
        array2[count] = array1[i];
        Count++;
        }
    }
}
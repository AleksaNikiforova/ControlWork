int GetNewFirstArraySize(string[] arr)
{
    int newIndex = 0;
    foreach (string s in arr)
    {
        if (s.Length <= 3)
        {
            newIndex += 1;
        }
    }
    return newIndex;
}

string[] CreateNewArray(int newIndex, string[] arr)
{
    string[] newFirstArray = new string[newIndex];
    newIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newFirstArray[newIndex] = arr[i];
            newIndex +=1;
        }
    }
    return newFirstArray;
}

void ArrayInConsole (string[] arr)
{
    Console.Write($"[{string.Join(", ", arr)}]");
}

string[] firstArray = {"Hello", "2", "world", ":-)"};
string[] newFirstArray = CreateNewArray(GetNewFirstArraySize(firstArray), firstArray);
ArrayInConsole(firstArray);
Console.Write("->");
ArrayInConsole(newFirstArray);
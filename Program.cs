int getNewFirstArraySize(string[] arr)
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

string[] createNewArray(int newIndex, string[] arr)
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
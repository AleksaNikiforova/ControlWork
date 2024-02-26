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
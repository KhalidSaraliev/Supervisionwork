string[] inputArray = { "cat", "dog", "apple", "hi", "yes", "no", "banana", "pie" };
string[] resultArray = new string[inputArray.Length];
int resultCount = 0;

foreach (var str in inputArray)
{
    if (str.Length <= 3)
    {
        resultArray[resultCount] = str;
        resultCount++;
    }
}



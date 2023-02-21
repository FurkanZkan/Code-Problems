string[] input = {"Bilmek", "bilmem","bilhakis"};

Console.WriteLine("The longest Common"+ " Prefix is : "+ longestCommonPrefix(input));

string longestCommonPrefix(string[] input)
{
    int size = input.Length;
    if (size == 0)
        return "";
    if (size == 1)
        return input[0];

    Array.Sort(input);

    int end = Math.Min(input[0].Length, input[size - 1].Length);

    int i = 0;
    while (i < end && input[0][i] == input[size - 1][i])
        i++;

        string pre = input[0].Substring(0, i);
        return pre;
    
}
// Given two strings, write a method to decide if one is a permutation of the other.


// Sorting the strings O(N)
bool IsPermutationBySort(string s1, string s2)
{
    if (s1.Length != s2.Length) return false;

    var ch1 = s1.ToCharArray();
    var ch2 = s2.ToCharArray();

    Array.Sort(ch1);
    Array.Sort(ch2);

    for (var i = 0; i < s1.Length; i++)
        if (ch1[i] != ch2[i])
            return false;

    return true;
}

// Counting the characters ASCII O(N)
bool IsPermutationByCounting(string s1, string s2)
{
    if (s1.Length != s2.Length) return false;
    var charArray = new int[128];

    foreach (var ch in s1.ToCharArray())
    {
        charArray[ch]++;
    }

    foreach (var ch in s2.Select(t => (int)t))
    {
        charArray[ch]--;
        if (charArray[ch] < 0) return false;
    }

    return true;
}


const string input1 = "abcd";
const string input2 = "dabc";

Console.WriteLine(IsPermutationBySort(input1, input2));
Console.WriteLine(IsPermutationByCounting(input1, input2));

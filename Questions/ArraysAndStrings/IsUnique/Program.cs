/* Implement an algorithm to determine if a string has all unique characters. what if you cannot use additional data structures? */

// no additional data structure O(N^2)
bool AllUnique(string input)
{
    for (var i = 0; i < input.Length; i++)
    {
        for (var j = i + 1; j < input.Length; j++)
        {
            if (input[i] == input[j]) return false;
        }
    }

    return true;
}

// with Hash Set data structure O(N)
bool IsUnique(string input)
{
    var seen = new HashSet<char>();

    foreach (var c in input)
    {
        if (seen.Contains(c)) return false;
        seen.Add(c);
    }

    return true;
}


// with a boolean char set O(N)

bool HasUnique(string input)
{
    if (input.Length > 128) return false;

    var charSet = new bool[128];

    foreach (var charValue in input.Select(c => (int)c))
    {
        if (charSet[charValue]) return false;
        charSet[charValue] = true;
    }

    return true;
}


// Execute Code

const string text = "omid";

var resultAllUnique = AllUnique(text);
var resultIsUnique = IsUnique(text);
var resultHasUnique = HasUnique(text);

Console.WriteLine($"All Unique : {resultAllUnique}");
Console.WriteLine($"Is Unique : {resultIsUnique}");
Console.WriteLine($"Has Unique : {resultHasUnique}");

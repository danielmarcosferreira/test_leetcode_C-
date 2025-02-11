using System;

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        // Test Cases
        Console.WriteLine(solution.DetectCapitalUse("USA"));
        Console.WriteLine(solution.DetectCapitalUse("FlaG"));
    }
}

// To run on the LeetCode site only copy the code below
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int capitalCount = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                capitalCount++;
            }
        }

        return capitalCount == word.Length ||
            capitalCount == 0 ||
            (capitalCount == 1 && char.IsUpper(word[0]));
    }
}
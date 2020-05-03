public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineDict = new Dictionary<char, long>();
        foreach (char c in magazine)
        {
            if (magazineDict.ContainsKey(c))
                magazineDict[c] += 1;
            else
                magazineDict.Add(c, 1);
        }
        foreach (char c in ransomNote)
        {
            if (!magazineDict.ContainsKey(c))
            {
                return false;
            }
            else if (magazineDict[c] == 0)
            {
                return false;
            }
            else
            {
                magazineDict[c] -= 1;
            }
        }
        return true;
    }
}
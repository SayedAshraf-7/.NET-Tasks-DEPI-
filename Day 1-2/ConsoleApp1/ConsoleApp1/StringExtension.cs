public static class StringExtension
{
    
    public static bool IsPalindrome(this string s)
    {
        for (int i = 0; i < s.Length/2; i++)
        {
            if (s[i] != s[s.Length - i - 1])
                return false;
        }
        return true;
    }

}

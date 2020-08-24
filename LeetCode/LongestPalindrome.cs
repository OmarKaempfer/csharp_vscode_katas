namespace LeetCode
{
    public class LongestPalindrome
    {
        public static string Of(string text)
        {
            for (int i = text.Length; i >= 1; i--)
            {
                for (int j = 0; j < text.Length - i + 1; j++)
                {
                    if(IsPalindrome(text, j, j + i - 1)) {
                        return text.Substring(j, i);
                    }
                }
            }

            return "";
        }

        public static bool IsPalindrome(string text, int left, int right)
        {
            while(left < right)
            {
                if(text[left] != text[right])
                {
                    return false;
                }
                
                right--;
                left++;
            }

            return true;
        }
    }
}
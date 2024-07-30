namespace InterviewbitAndLitcode
{
    public class IsSubsequence
    {
        public bool IsSubsequenceMethod(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }
            int i = 0;
            int j = 0;
            while (j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                    if (i == s.Length)
                    {
                        return true;
                    }
                }
                j++;
            }
            return false;
        }
    }
}
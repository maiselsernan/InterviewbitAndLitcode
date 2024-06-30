namespace InterviewbitAndLitcode
{
    public class IndexOfFirstAccurrence
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;
            if (haystack.Length < needle.Length)
                return -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0] && Compare(haystack, i, needle))
                {
                    return i;
                }
            }

            return -1;
        }

        private bool Compare(string haystack, int index, string needle)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[index + j] != needle[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

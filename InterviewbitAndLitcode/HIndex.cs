namespace InterviewbitAndLitcode
{
    public class HIndex
    {
        public int HIndexMethod(int[] citations)
        {
            citations = citations.OrderByDescending(x => x).ToArray();
            int h = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= i + 1)
                {
                    h = i + 1;
                    continue;
                }
                break;
            }
            return h;
        }
    }
}



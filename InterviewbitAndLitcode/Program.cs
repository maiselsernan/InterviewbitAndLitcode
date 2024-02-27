namespace InterviewbitAndLitcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pascalsTriangleRow = GetKthRowOfPascalsTriangle(3);
        }
        static List<int> GetKthRowOfPascalsTriangle(int k)
        {
            //https://www.interviewbit.com/problems/kth-row-of-pascals-triangle/ 
            
            List<int> row = new List<int>();
            row.Add(1); // First element is always 1

            for (int i = 1; i <= k; i++)
            {
                // Calculate next row based on the previous row
                List<int> nextRow = new List<int>();
                nextRow.Add(1); // First element of each row is 1

                // Calculate the middle elements of the row
                for (int j = 1; j < i; j++)
                {
                    nextRow.Add(row[j - 1] + row[j]);
                }

                nextRow.Add(1); // Last element of each row is 1
                row = nextRow; // Update row to the next row
            }

            return row;
        }
    }

}

using System.Collections.Generic;
using System.Security;

namespace ConsoleApp1
{
    public class AnalysisDataModule
    {
        static public void SortBooks(List<string> books, List<int> counts)
        {
                for (int i = 0; i < counts.Count; ++i)
                {
                    for (int j = 0; j < counts.Count - 1; ++j)
                    {
                        bool condition = counts[j + 1] > counts[j];
                        if (condition)
                        {
                            int temp_counts = counts[j];
                            counts[j] = counts[j + 1];
                            counts[j + 1] = temp_counts;

                            string temp_books = books[j];
                            books[j] = books[j + 1];
                            books[j + 1] = temp_books;
                    }
                    }
                }
        }

        static public double CalculateAverage(List<int> counts)
        {
            int sum = 0;
            foreach(int count in counts)
            {
                sum += count;
            }

            return sum / counts.Count;
        }
    }
}

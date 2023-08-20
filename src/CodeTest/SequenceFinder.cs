namespace CodeTest
{
    public static class SequenceFinder
    {
        public static string FindSequence(string input)
        {
            var uSeq = ConvertInput(input);
            var fSeq = new List<(int, int, int)>();
            var start = -1;
            var last = -1;
            var preVal = 0;

            for (var i = 0; i < uSeq.Count; i++)
            {
                if (i == 0)
                {
                    start = last = i;
                    preVal = uSeq[i];
                    continue;
                }

                if (uSeq[i] > preVal)
                {
                    if (start == -1)
                    {
                        start = i - 1;
                    }
                    last = i;

                    if (i == uSeq.Count - 1)
                    {
                        fSeq.Add((start, last, last - start));
                    }
                }
                else
                {
                    if (start != last)
                    {
                        fSeq.Add((start, last, last - start));
                    }
                    start = last = -1;
                }
                preVal = uSeq[i];
            }
            var highestSeries = fSeq.OrderByDescending(x => x.Item3).FirstOrDefault();
            var res = string.Join(' ', uSeq.Take(new Range(highestSeries.Item1, highestSeries.Item2 + 1)));
            return res;
        }

        private static List<int> ConvertInput(string input)
        {
            try
            {
                var uSeq = input.Split(' ', StringSplitOptions.TrimEntries);
                return uSeq.Select(x => Convert.ToInt32(x)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
                throw;
            }
        }
    }
}
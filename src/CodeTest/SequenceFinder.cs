namespace CodeTest
{
    public static class SequenceFinder
    {
        /// <summary>
        /// This function finds a longest increasing subsequence. 
        /// </summary>
        /// <param name="input"> String input of any number of integers separated by single whitespace </param>
        /// <returns>Long sequence from the given input</returns>
        public static string FindSequence(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "invalid input";
            }
            var uSeq = ConvertIntListInput(input);
            var longestSeries = FindLongestSequence(uSeq);
            if (longestSeries == null)
            {
                return "no sequence found";
            }
            //Get the specified range from the sequence
            var res = string.Join(' ', uSeq.Take(new Range(longestSeries.StartIndex, longestSeries.LastIndex + 1)));
            return res;
        }


        /// <summary>
        /// Finds longest sequence from the given sequence list 
        /// </summary>
        /// <param name="seq"></param>
        /// <returns>SequenceMetadataModel</returns>
        private static SequenceMetadataModel? FindLongestSequence(IList<int> seq)
        {
            var sequenceMetadataList = new List<SequenceMetadataModel?>();
            var start = -1;
            var last = -1;
            var preVal = 0;
            for (var i = 0; i < seq.Count; i++)
            {
                if (i == 0) //set first element in preVal
                {
                    start = last = i;
                    preVal = seq[i];
                    continue;
                }

                if (seq[i] > preVal)
                {
                    if (start == -1) // if start is -1 then set preVal index to start
                    {
                        start = i - 1;
                    }

                    last = i;

                    if (i == seq.Count - 1) //if last element sequence is part of a sub sequence 
                    {
                        sequenceMetadataList.Add(new SequenceMetadataModel(start, last));
                    }
                }
                else
                {
                    if (start != last)
                    {
                        sequenceMetadataList.Add(new SequenceMetadataModel(start, last));
                    }
                    start = last = -1;
                }
                preVal = seq[i];
            }
            return sequenceMetadataList.OrderByDescending(x => x.Length).FirstOrDefault();
        }

        /// <summary>
        /// Convert string to integers separated by single whitespace
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integer</returns>
        private static IList<int> ConvertIntListInput(string input)
        {
            try
            {
                var uSeq = input.Split(' ', StringSplitOptions.TrimEntries);
                return uSeq.Select(x => Convert.ToInt32(x)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error thrown while converting to int list due to : {e.Message}");
                throw;
            }
        }
    }
}
namespace CodeTest
{
    public class SequenceMetadataModel
    {
        public SequenceMetadataModel(int startIndex, int lastIndex)
        {
            StartIndex = startIndex;
            LastIndex = lastIndex;
        }
        public int StartIndex { get; set; }
        public int LastIndex { get; set; }
        public int Length => LastIndex - StartIndex;
    }
}

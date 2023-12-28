namespace Indexes
{
    public class Sentence
    {
        readonly string[] words = "The quick brown fox".Split();

        public string this[Index index] => words[index];
        public string[] this[Range range] => words[range];
    }
}
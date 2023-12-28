// See https://aka.ms/new-console-template for more information

string[] words = "The quick brown fox".Split();

System.Console.WriteLine(LetterCounter(words));


int LetterCounter(string[] sentence)
{
  int counter = 0;

  foreach (var word in sentence)
  {
    counter += LettersInWord(word);
  }

  static int LettersInWord(string word)
  {
    return word.Length;
  }

  return counter;
}

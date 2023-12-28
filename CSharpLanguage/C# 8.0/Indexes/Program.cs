// See https://aka.ms/new-console-template for more information
using Indexes;

var sentence = new Sentence();
Range firstTwo = 0..2;

System.Console.WriteLine(sentence[0]);
System.Console.WriteLine(sentence[1]);
System.Console.WriteLine(sentence[2]);
System.Console.WriteLine(string.Join(" ", sentence[firstTwo]));

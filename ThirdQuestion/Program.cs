// See https://aka.ms/new-console-template for more information
using ThirdQuestion;

var fileSystem = new WordCounter(string.Empty);
var wordCounter = fileSystem.GetWordCount();
foreach (var word in wordCounter)
{
    Console.WriteLine($"{word.Value} {word.Key}");
}
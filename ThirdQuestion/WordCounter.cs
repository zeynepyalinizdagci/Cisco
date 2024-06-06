using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThirdQuestion
{
    public class WordCounter
    {
        private string _path;
        public WordCounter(string path)
        {
            _path = string.IsNullOrEmpty(path) ? "Data\\sample.txt" : path;
        }

        public Dictionary<string, int> GetWordCount()
        {
            try
            {
                var allWords = File.ReadAllText(Path.GetFullPath(_path)).ToLower();
                var current = new List<char>();
                var wordCount = new Dictionary<string, int>();

                foreach (var letter in allWords)
                {
                    if (char.IsLetterOrDigit(letter) || letter == '\'')
                    {
                        current.Add(letter);
                    }
                    else if (current.Count > 0)
                    {
                        var word = new string(current.ToArray());

                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                        current.Clear();
                    }
                }

                if (current.Count > 0)
                {
                    var word = new string(current.ToArray());
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount[word] = 1;
                    }
                }
                return wordCount;

            }
            catch (Exception)
            {

                throw;
            }
            return new Dictionary<string, int>();
        }
    }
}

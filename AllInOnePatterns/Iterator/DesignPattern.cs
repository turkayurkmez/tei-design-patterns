using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /*
     * Bir özelleşmiş koleksiyon yeter!
     */

    public class Iterator : IEnumerator<string>
    {
        int position = 0;

        List<string> words = new List<string>();
        public void Add(string word) => words.Add(word);
        public string Current => words[position];
        object IEnumerator.Current => Current;
        public void Dispose()
        {
          words.Clear();
        }

        public bool MoveNext()
        {
            position++;
            return position < words.Count;
        }

        public void Reset()
        {
           position = 0;
        }

        public string Next() => words[position++];
        public string First()
        {
            position = 0;
            return words[position];
        }
    }
}

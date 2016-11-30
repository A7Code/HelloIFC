using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloRegex
{
    class a7Message
    {
        string _full;
        List<Match> _find = new List<Match>();
        public a7Message(ref string _inputString)
        {
            _full = _inputString;
        }

        public void setRegex(string _set)
        {
            _find = new List<Match>();
            MatchCollection getMatches = Regex.Matches(_full, _set);
            for (int i = 0; i < getMatches.Count; i++)
                _find.Add(getMatches[i]);
        }

        public void showSomething()
        {
            Console.WriteLine("Count : " + _find.Count);
            Console.WriteLine("First : " + _find[0]);
            Console.WriteLine("Last : " + _find.Last());
        }
        public void showCount()
        {
            Console.WriteLine(_find.Count);
        }
        public void showMessage()
        {
           for (int i = 0; i < _find.Count; i++)
                Console.WriteLine(_find[i]);
            Console.WriteLine();
        }
    }
}

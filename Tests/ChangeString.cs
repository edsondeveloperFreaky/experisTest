using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ChangeString
    {
        public string build(string value)
        {
            var alphabetSpanish = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var result = "";
            foreach (var v in value.ToCharArray())
            {
                var next = new char();
                if (Char.IsLetter(v))
                    if (char.IsUpper(v))
                        next = Char.ToUpper(char.ToLower(v) == 'z' ? 'A' : alphabetSpanish[alphabetSpanish.IndexOf(char.ToLower(v)) + 1]);
                    else
                        next = Char.ToLower(char.ToLower(v) == 'z' ? 'a' : alphabetSpanish[alphabetSpanish.IndexOf(char.ToLower(v)) + 1]);
                else
                    next = v;

                result = result + next;
            }
            return result;
        }
    }
}

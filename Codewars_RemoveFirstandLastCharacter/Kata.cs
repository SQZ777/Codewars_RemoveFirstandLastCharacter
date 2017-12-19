using System;

namespace Codewars_RemoveFirstandLastCharacter
{
    public class Kata
    {
        public string Remove_char(string s)
        {
            return s.Length > 1 ? s.Substring(1, s.Length - 2) : "ok";
        }
    }
}

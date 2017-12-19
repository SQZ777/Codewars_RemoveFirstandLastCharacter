using System;

namespace Codewars_RemoveFirstandLastCharacter
{
    public class Kata
    {
        public string Remove_char(string s)
        {
            if (s.Length>1)
                return s.Substring(1, s.Length - 2);
            return "ok";
        }
    }
}

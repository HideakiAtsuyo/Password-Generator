using System;
using System.Linq;

namespace Password_Generator
{
    public static class Utils
    {
        private static Random rdm = new Random();
        public static string RandomPassword(int l, string c)
        {
            return new string(Enumerable.Repeat(c, l).Select(s => s[rdm.Next(s.Length)]).ToArray());
        }
    }
}

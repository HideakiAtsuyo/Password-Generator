using System;
using System.Linq;
using System.Windows.Forms;

namespace Password_Generator
{
    public static class Utils
    {
        private static Random rdm = new Random();
        public static string RandomPassword(int l, string c)
        {
            return new string(Enumerable.Repeat(c, l).Select(s => s[rdm.Next(s.Length)]).ToArray());
        }
        public static string S3CUR3(this string x)
        {
            //Replace Chars
            return x.Replace("A", "4").Replace("E", "3").Replace("O", "0").Replace("L", "7").Replace("I", rdm.Next(1, 2) == 1 ? "|" : "!").Replace("S", rdm.Next(1, 2) == 1 ? "$" : "5").Replace("a", "@").Replace("e", "3").Replace("o", "0").Replace("l", "7").Replace("i", rdm.Next(1, 2) == 1 ? "!" : "|").Replace("s", rdm.Next(1, 2) == 1 ? "$" : "5");
        }
    }
}

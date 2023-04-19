using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_small_HR
{
    internal class Randomid
    {
        private static Random rdm = new Random();

        public static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rdm.Next(s.Length)]).ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dugga
{
    public class Shortcut
    {
        public long Convert(string str)
        {
            //Convert to lower case. Always work with lower case from now on.
            str = str.ToLower();

            //Extract all letters and digits.
            var letters = new String(str.Where(Char.IsLetter).ToArray());
            string digitsStr = new String(str.Where(Char.IsDigit).ToArray());

    
            long digits = 1;
    
            //Convert our digitsStr string to our digits (if we have any digits...)
            if (digitsStr.Length > 1) 
            {
                bool res = long.TryParse(digitsStr, out digits);
                //FIXME: Check result
            }
                     
            //Make sure we have one or zero letters.
            if (letters.Length > 1)
            {
                //Error: More than one character. Return -1.
                return -1;
            }

            //If we have a character, check that they are only k, m, b or t
            if (letters.Length == 1)
            {
                var match = letters.IndexOfAny("kmbt".ToCharArray());
                if (match == -1) return -1;
            }

            //If we have a letter, check that it is last in our str
            string temp = digitsStr + letters;
            if (temp != str) return -1;

            //If we have only digits, return them.
            if (letters.Length == 0)
                return digits;

            long result = 0;

            //Do the conversion
            switch(letters)
            {
                case "k": 
                    result = digits * 1000;
                    break;
                case "m": 
                    result = digits * 1000000;
                    break;
                case "b": 
                    result = digits * 1000000000;
                    break;
                case "t":
                    result = digits * 1000000000000;
                    break;
            }

            return result;
        }
    }
}

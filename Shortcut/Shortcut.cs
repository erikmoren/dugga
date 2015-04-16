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
            //Strip whitespaces
            str = str.Trim();
            
            //Check if we have empty string
            if (String.IsNullOrEmpty(str))
            {
                return -1;
            }

            //Convert to lower case. Always work with lower case from now on.
            str = str.ToLower();

            //Extract all letters and digits.
            var letters = new String(str.Where(Char.IsLetter).ToArray());
            string digitsStr = new String(str.Where(Char.IsDigit).ToArray());

            //Init digits to 1 in case we do not have any characters in our string
            long digits = 1;
    
            //Convert our digitsStr string to our digits (if we have any digits...)
            if (digitsStr.Length > 1) 
            {
                bool res = long.TryParse(digitsStr, out digits);
                if (res == false)
                    return -1;  //TryParse failed.
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

                //If we have only digits, return them.
                default: 
                    result = digits;
                    break;

            }

            return result;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
	public static class RomanNumeralsConverter
	{
        public static string Convert(int number)
        {
            var lookupDict = new SortedDictionary<int, string>()
            {
                {1, "I"},
                {5, "V"},
                {10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"}
            };

            var romanNumber = string.Empty;
            var lastKey = -1;

            foreach (var item in lookupDict.Reverse())
            {
                if(number >= item.Key)
                {
                    var quotient = number / item.Key;

                    if ((lastKey == 1000 || lastKey == 100 || lastKey == 10) && number != number % (lastKey - lastKey/10))
                    {
                        romanNumber += lookupDict[lastKey / 10];
                        romanNumber += lookupDict[lastKey];
                        romanNumber += Convert(number % (lastKey - lastKey / 10));
                        break;
                    }
                    else if(quotient * item.Key != item.Key && quotient * item.Key == lastKey - item.Key)
                    {
                        romanNumber += lookupDict[item.Key];
                        romanNumber += lookupDict[lastKey];
                    }
                    else
                    {
                        romanNumber += string.Concat(Enumerable.Repeat(lookupDict[item.Key], quotient));
                    }

                    romanNumber += Convert(number % item.Key);
                    break;
                }

                lastKey = item.Key;
            }

            return romanNumber;
        }
	}
}
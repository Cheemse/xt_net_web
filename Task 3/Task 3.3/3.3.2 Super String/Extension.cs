using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._3._2_Super_String
{
    
        public static class StringExtension
        {
            
            public static StringType GetStringType(this string inputString)
            {
                if (!string.IsNullOrEmpty(inputString))
                {
                    if (StringIsRussian(inputString))
                    {
                        return StringType.Russian;
                    }
                    else if (StringIsEnglish(inputString))
                    {
                        return StringType.English;
                    }
                    else if (StringIsDigit(inputString))
                    {
                        return StringType.Number;
                    }
                    else if (StringIsMixed(inputString))
                    {
                        return StringType.Mixed;
                    }
                    else
                    {
                        return StringType.None;
                    }
                }

                else
                {
                    return StringType.None;
                }
            }

            private static bool StringIsEnglish(string str)
            {
                return Regex.IsMatch(str, @"\b([a-z])+\b");
            }

            private static bool StringIsRussian(string str)
            {
                return Regex.IsMatch(str, @"\b([а-яё])+\b");
            }

            private static bool StringIsMixed(string str)
            {
                return Regex.IsMatch(str, @"([a-zA-Z]|[а-яА-Я]|[0-9])+\w");
            }

            private static bool StringIsDigit(string str)
            {
                return Regex.IsMatch(str, @"\b[\d]+\b");
            }

            public enum StringType
            {

                  None,
                  Russian,
                  English,
                  Number,
                  Mixed

            }
        
        }

}

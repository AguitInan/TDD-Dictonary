using System.Collections.Generic;

namespace TDD_DictionaryCore
{
    public class StringReplacer
    {
        //public static string ReplaceString(string input, Dictionary<string, string> replacements)
        //{
        //    return input;
        //}

        //public static string ReplaceString(string input, Dictionary<string, string> replacements)
        //{
        //    foreach (var pair in replacements)
        //    {
        //        input = input.Replace($"${pair.Key}$", pair.Value);
        //    }
        //    return input;
        //}

        public static string ReplaceString(string input, Dictionary<string, string> replacements)
        {
            foreach (var pair in replacements)
            {
                input = input.Replace($"${pair.Key}$", pair.Value);
            }
            return input;
        }
    }
}
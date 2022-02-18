using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solutions11_23
{
    static class PigLatin
    {
        public static string Translate(string line)
        {
            string res = string.Empty;
            foreach (string word in line.Split())
            {
                res += TranslateWord(word) + " ";
            }
            return res.Trim();
        }
        public static string TranslateWord(string word)
        {
            word = word.ToLower();
            Regex r1 = new Regex("^([aeiou]|yt|xr)[a-z]+$");
            Regex r2 = new Regex("^(thr?|sch|ch|qu|rh|[^aeiou](qu)?)([a-z]+)$");
            if (r1.IsMatch(word))
            {
                return word + "ay";
            }
            if (r2.IsMatch(word))
            {
                Match m = r2.Match(word);
                return m.Groups[3].Value + m.Groups[1].Value + "ay";
            }
            throw new ArgumentException();
        }
    }
}

/*
 * Instructions
Implement a program that translates from English to Pig Latin.

Pig Latin is a made-up children's language that's intended to be confusing. It obeys a few simple rules (below), but when it's spoken quickly it's really difficult for non-children (and non-native speakers) to understand.

Rule 1: If a word begins with a vowel sound, add an "ay" sound to the end of the word. Please note that "xr" and "yt" at the beginning of a word make vowel sounds (e.g. "xray" -> "xrayay", "yttria" -> "yttriaay").
Rule 2: If a word begins with a consonant sound, move it to the end of the word and then add an "ay" sound to the end of the word. Consonant sounds can be made up of multiple consonants, a.k.a. a consonant cluster (e.g. "chair" -> "airchay").
Rule 3: If a word starts with a consonant sound followed by "qu", move it to the end of the word, and then add an "ay" sound to the end of the word (e.g. "square" -> "aresquay").
Rule 4: If a word contains a "y" after a consonant cluster or as the second letter in a two letter word it makes a vowel sound (e.g. "rhythm" -> "ythmrhay", "my" -> "ymay").
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solutions11_23
{
    static class CryptoSquare
    {
        public static string NormalizedPlaintext(string plaintext)
        {
            return Regex.Replace(plaintext.ToLower(), @"[\s+,*.*%*@*!*]", "");
        }
        static (int rows, int columns) GetDivisors(string plaintext)
        {
            int textLength = NormalizedPlaintext(plaintext).Length;
            int columns = 0;
            int rows = (int)Math.Sqrt(textLength);
            if (textLength == 0)
            {
                columns = rows = 0;
            }
            if (textLength == 1)
            {
                columns = rows = 1;
            }
            if (rows * rows == textLength)
            {
                columns = rows;
            }
            else
            {
                columns = rows + 1;
                if (columns * rows < textLength)
                {
                    rows++;
                }
            }
            return (rows, columns);
        }
        public static IEnumerable<string> PlaintextSegments(string plaintext)
        {
            (int rows, int columns) = GetDivisors(plaintext);
            string text = NormalizedPlaintext(plaintext);
            int spaceToAdd = 0;
            if (rows * columns > text.Length)
            {
                spaceToAdd = rows * columns - text.Length;
            }
            while (spaceToAdd > 0)
            {
                text += " ";
                spaceToAdd--;
            }

            return Enumerable.Range(0, rows).Select(i => text.Substring(i * columns, columns));
        }
        public static string Encoded(string plaintext)
        {
            (int rows, int columns) = GetDivisors(plaintext);
            var plaintextSegments = PlaintextSegments(plaintext);
            string rez = "";
            for (int i = 0; i < columns; i++)
            {
                foreach (var item in plaintextSegments)
                {
                    rez += item[i];
                }
            }
            return rez;
        }
        public static string Ciphertext(string plaintext)
        {
            (int rows, int columns) = GetDivisors(plaintext);
            var rez = Enumerable.Range(0, columns).Select(i => Encoded(plaintext).Substring(i * rows, rows));
            string final = "";
            foreach (var item in rez)
            {
                final += " " + item;
            }
            return final.TrimStart();
        }
    }
}

/*
 * Instructions
Implement the classic method for composing secret messages called a square code.

Given an English text, output the encoded version of that text.

First, the input is normalized: the spaces and punctuation are removed from the English text and the message is down-cased.

Then, the normalized characters are broken into rows. These rows can be regarded as forming a rectangle when printed with intervening newlines.

For example, the sentence

"If man was meant to stay on the ground, god would have given us roots."
is normalized to:

"ifmanwasmeanttostayonthegroundgodwouldhavegivenusroots"
The plaintext should be organized in to a rectangle. The size of the rectangle should be decided by the length of the message.

If c is the number of columns and r is the number of rows, then for the rectangle r x c find the smallest possible integer c such that:

r * c >= length(message),
and c >= r,
and c - r <= 1.
Our normalized text is 54 characters long, dictating a rectangle with c = 8 and r = 7:

"ifmanwas"
"meanttos"
"tayonthe"
"groundgo"
"dwouldha"
"vegivenu"
"sroots  "
The coded message is obtained by reading down the columns going left to right.

The message above is coded as:

"imtgdvsfearwermayoogoanouuiontnnlvtwttddesaohghnsseoau"
Output the encoded text in chunks that fill perfect rectangles (r X c), with c chunks of r length, separated by spaces. For phrases that are n characters short of the perfect rectangle, pad each of the last n chunks with a single trailing space.

"imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn  sseoau "
Notice that were we to stack these, we could visually decode the ciphertext back in to the original message:

"imtgdvs"
"fearwer"
"mayoogo"
"anouuio"
"ntnnlvt"
"wttddes"
"aohghn "
"sseoau "
*/

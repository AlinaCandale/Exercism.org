using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions11_23
{
    class ScrabbleScore
    {
        public static int Score(string input)
        {
            int score = 0;
            foreach (char letter in input.ToUpper())
            {
                switch (letter)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'L':
                    case 'N':
                    case 'R':
                    case 'S':
                    case 'T':
                        score += 1;
                        break;
                    case 'D':
                    case 'G':
                        score += 2;
                        break;
                    case 'B':
                    case 'C':
                    case 'M':
                    case 'P':
                        score += 3;
                        break;
                    case 'F':
                    case 'H':
                    case 'V':
                    case 'W':
                    case 'Y':
                        score += 4;
                        break;
                    case 'K':
                        score += 5;
                        break;
                    case 'J':
                    case 'X':
                        score += 8;
                        break;
                    case 'Q':
                    case 'Z':
                        score += 10;
                        break;
                }
            }
            return score;
        }
    }
}

/*
 * Instructions
Given a word, compute the Scrabble score for that word.

Letter Values
You'll need these:

Letter                           Value
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10
Examples
"cabbage" should be scored as worth 14 points:

3 points for C
1 point for A, twice
3 points for B, twice
2 points for G
1 point for E
And to total:

3 + 2*1 + 2*3 + 2 + 1
= 3 + 2 + 6 + 3
= 5 + 9
= 14
Extensions
You can play a double or a triple letter.
You can play a double or a triple word.
*/
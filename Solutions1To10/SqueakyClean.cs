using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions1To10
{
    static class SqueakyClean
    {
        public static string Clean(string identifier)
        {
            StringBuilder sb = new StringBuilder(identifier.Length);
            for (int i = 0; i < identifier.Length; i++)
            {

                if (Char.IsWhiteSpace(identifier[i]))
                    sb.Append('_');
                else if (Char.IsControl(identifier[i]))
                    sb.Append("CTRL");
                else if (identifier[i] == '-')
                {
                    i++;
                    sb.Append(Char.ToUpper(identifier[i]));
                }
                else if ((identifier[i] >= 0x03b1) && (identifier[i] <= 0x03c9))
                {
                }
                else if ((identifier[i] == '\ud83d') || (identifier[i] == '\ude00'))
                {
                }
                else if (Char.IsDigit(identifier[i]))
                {
                }
                else
                    sb.Append(identifier[i]);
            }
            return sb.ToString();
        }
    }
}
/*
 * Instructions
In this exercise you will implement a partial set of utility routines to help a developer clean up identifier names.
In the 4 tasks you will gradually build up the routine Clean A valid identifier comprises zero or more letters and underscores.
In all cases the input string is guaranteed to be non-null. If an empty string is passed to the Clean function, an empty string should be returned.

Note that the caller should avoid calling the routine Clean with an empty identifier since such identifiers are ineffectual.

1. Replace any spaces encountered with underscores
Implement the (static) Identifier.Clean() method to replace any spaces with underscores. This also applies to leading and trailing spaces.

Identifier.Clean("my   Id");
// => "my___Id"

2. Replace control characters with the upper case string "CTRL"
Modify the (static) Identifier.Clean() method to replace control characters with the upper case string "CTRL".

Identifier.Clean("my\0Id");
// => "myCTRLId",

3. Convert kebab-case to camelCase
Modify the (static) Identifier.Clean() method to convert kebab-case to camelCase.

Identifier.Clean("à-ḃç");
// => "àḂç"

4. Omit Greek lower case letters
Modify the (static) Identifier.Clean() method to omit any Greek letters in the range 'α' to 'ω'.

Identifier.Clean("MyΟβιεγτFinder");
// => "MyΟFinder"

*/

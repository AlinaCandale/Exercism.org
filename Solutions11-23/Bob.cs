using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions11_23
{
    public static class Bob
    {
        public static string Response(string statement)
        {
            var input = statement.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return "Fine. Be that way!";
            }

            if (input.EndsWith("?") && !input.ToCharArray().Any(char.IsLower) && input.ToCharArray().Any(char.IsUpper))
            {
                return "Calm down, I know what I'm doing!";
            }

            else if (!input.ToCharArray().Any(char.IsLower) && input.ToCharArray().Any(char.IsUpper))
            {
                return "Whoa, chill out!";
            }

            return input.EndsWith("?") ? "Sure." : "Whatever.";
        }
    }
}

/*
 * Instructions
Bob is a lackadaisical teenager. In conversation, his responses are very limited.

Bob answers 'Sure.' if you ask him a question, such as "How are you?".

He answers 'Whoa, chill out!' if you YELL AT HIM (in all capitals).

He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

He says 'Fine. Be that way!' if you address him without actually saying anything.

He answers 'Whatever.' to anything else.

Bob's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.
*/

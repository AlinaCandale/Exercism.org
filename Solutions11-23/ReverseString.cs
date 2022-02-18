using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions11_23
{
    static class ReverseString
    {
        public static string Reverse(string input) => string.Join("", input.Reverse().ToArray());
    }
}

/*
 * Instructions
Reverse a string

For example: input: "cool" output: "looc"
*/

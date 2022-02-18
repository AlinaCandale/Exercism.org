using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions11_23
{
    static class SecretHandshake
    {
        public static Dictionary<int, string> sequence = new Dictionary<int, string> {
        {1,"wink"},
        {2,"double blink"},
        {4,"close your eyes"},
        {8, "jump"}};

        public static string[] Commands(int commandValue)
        {
            var result = sequence.Where(c => (c.Key & commandValue) == c.Key)
            .Select(v => v.Value);
            if ((16 & commandValue) == 16) { result = result.Reverse(); }
            return result.ToArray();
        }
    }
}

/*
 * Instructions
There are 10 types of people in the world: Those who understand binary, and those who don't.

You and your fellow cohort of those in the "know" when it comes to binary decide to come up with a secret "handshake".

1 = wink
10 = double blink
100 = close your eyes
1000 = jump


10000 = Reverse the order of the operations in the secret handshake.
Given a decimal number, convert it to the appropriate sequence of events for a secret handshake.

Here's a couple of examples:

Given the input 3, the function would return the array ["wink", "double blink"] because 3 is 11 in binary.

Given the input 19, the function would return the array ["double blink", "wink"] because 19 is 10011 in binary. 
Notice that the addition of 16 (10000 in binary) has caused the array to be reversed.
*/

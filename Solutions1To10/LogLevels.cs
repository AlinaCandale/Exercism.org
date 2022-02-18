using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions1To10
{
    static class LogLevels
    {
        public static string Message(string logLine)
        {
            string[] logLine1 = logLine.Split(' ', '\r', '\n');
            char[] charsToTrim = { '\r', '\n', ' ' };
            logLine = logLine.Replace("\t", "");

            logLine = logLine.Substring(logLine1[0].Length + 1);
            logLine = logLine.Trim(charsToTrim);
            return $"{logLine}";
        }
        public static string LogLevel(string logLine)
        {
            string[] logLine1 = logLine.Split('[', ']');
            logLine = logLine.Substring(1, logLine1[1].Length);
            return logLine.ToLower();
        }
        public static string Reformat(string logLine)
        {
            string info = LogLevel(logLine);
            string message = Message(logLine);
            return message + ' ' + '(' + info + ')';
        }
    }
}
/*Instructions - Log Levels
In this exercise you'll be processing log-lines.
Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".
There are three different log levels:
INFO
WARNING
ERROR
You have three tasks, each of which will take a log line and ask you to do something with it.

1. Get message from a log line
Implement the (static) LogLine.Message() method to return a log line's message:

LogLine.Message("[ERROR]: Invalid operation")
// => "Invalid operation"

Any leading or trailing white space should be removed:

LogLine.Message("[WARNING]:  Disk almost full\r\n")
// => "Disk almost full"

2. Get log level from a log line
Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:

LogLine.LogLevel("[ERROR]: Invalid operation")
// => "error"

3. Reformat a log line
Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:

LogLine.Reformat("[INFO]: Operation completed")
// => "Operation completed (info)"
 */

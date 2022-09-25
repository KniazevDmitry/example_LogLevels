using System;

static class LogLine
{
    //Implement the (static) LogLine.Message() method to return a log line's message:
    //LogLine.Message("[ERROR]: Invalid operation")
    // => "Invalid operation"
    public static string Message(string logLine) 
        => logLine[(logLine.IndexOf(":") + 1)..].Trim();

    //Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:
    //LogLine.LogLevel("[ERROR]: Invalid operation")
    // => "error"
    public static string LogLevel(string logLine)
        => logLine.Substring(1, (logLine.IndexOf("]") - 1)).ToLower();

    //Implement the (static) LogLine.Reformat() method that reformats the log line,
    //putting the message first and the log level after it in parentheses:
    //LogLine.Reformat("[INFO]: Operation completed")
    // => "Operation completed (info)"
    public static string Reformat(string logLine)
        => $"{Message(logLine)} ({LogLevel(logLine)})";
    
}

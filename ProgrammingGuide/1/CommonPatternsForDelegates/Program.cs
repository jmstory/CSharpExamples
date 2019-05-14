using System;
using System.IO;

namespace CommonPatternsForDelegates
{
    public enum Severity
    {
        Verbose,
        Trace,
        Information,
        Warning,
        Error,
        Critical
    }


    


    public static class Logger
    {
        
        public static Action<string> WriteMessage;
        public static Severity LogLevel {get;set;} = Severity.Warning;
        public static void LogMessage(string msg)
        {
            WriteMessage(msg);
        }
        public static void LogMessage(Severity s , string component , string msg)
        {
            if (s < LogLevel)
                return;
            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
            WriteMessage(outputMsg);
        }    
        
        public static void LogToConsole(string message)
        {
            Console.Error.WriteLine(message);
        }        

        public class FileLogger
        {
            private readonly string logPath;
            public FileLogger(string path)
            {
                logPath = path;
                Logger.WriteMessage += LogMessage;
            }
            public void DetahLog() => Logger.WriteMessage -= LogMessage;
            private void LogMessage(string msg)
            {
                try
                {
                    using (var log = File.AppendText(logPath))
                    {
                        log.WriteLine(msg);
                        log.Flush();
                    }
                }
                catch (Exception)
                {
                    // Hmm. We caught an exception while 
                    // logging. We can't really log the 
                    // problem (since it's the log that's failing).
                    // So, while normally, catching an exception
                    // and doing nothing isn't wise, it's really the
                    // only reasonable option here.
                }
            }
        }

        //Handling Null Delegates
        //public static LogMessage(string msg)
        //{
        //    WriteMessage?.Invoke(msg);
        //}
        static void Main(string[] args)
        {
            

            var file = new FileLogger("log.txt");
            var fileOutput = new FileLogger("log.txt");
            Logger.WriteMessage += LogToConsole;
            Logger.WriteMessage -= LogToConsole;
        }
    }
}

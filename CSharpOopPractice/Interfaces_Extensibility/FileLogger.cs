using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        private void Log(string message, string messageType)
        {
            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + message);
            }
        }

        public void LogError(string message)
        {
            Log(message, "Error: ");
       
        }

        public void LogInfo(string message)
        {
            Log(message, "Info: ");
        }
    }
}

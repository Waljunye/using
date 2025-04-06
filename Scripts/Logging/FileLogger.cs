using System;
using System.IO;
using UnityEngine;

namespace Logging
{
    public class FileLogger : IDisposable
    {
        private StreamWriter _streamWriter;

        public FileLogger(string filePath)
        {
            _streamWriter = new StreamWriter(filePath, true);
        }

        public void Log(string message)
        {
            _streamWriter.WriteLine(message);
        }

        public void Dispose()
        {
            Debug.Log("FileLogger disposed");
            _streamWriter.Close();
            GC.SuppressFinalize(this);
        }
        
        ~FileLogger()
        {
            Dispose();
        }
    }
}
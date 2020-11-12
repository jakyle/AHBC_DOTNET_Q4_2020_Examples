using System;
using System.Collections.Generic;
using System.IO;

namespace FILE_IO
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileHandler = new FileHandler();

            fileHandler.WriteFileContent("Hello class el oh el!!!");
            var content = fileHandler.GetFileContent();

            Console.WriteLine(content);

            Console.ReadLine();

        }
        // we just the method
        // ALL VALUE TYPES GET REMOVED FROM MEMORY IMMEDIATLY

        public void ReferenceTypeExample()
        {
            var things = new List<string>();

            var otherThings = things;
        }
        // We clean up all of our variables, so things will NO LONGER EXIST, BUT!!!!!!!!! the actual
        // THING in memory (Heap) will still exist.
        // at some random point in time, the GC (Garbage Collector) will check to see if that reference type
        // is still being referenced by some variable (if a pointer to your object exist), if it is NOT, the
        // GC (Garbage Collector) will free up that object (ie remove) it from memory.

        public interface IRead
        {
            string GetFileContent();
        }

        public interface IWrite
        {
            void WriteFileContent(string content);
        }

        public class FileHandler : IWrite, IRead
        {
            private string _filePath;

            public FileHandler()
            {
                string myDocumentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                _filePath = Path.Combine(myDocumentsDirectory, "CLASS_EXAMPLE.txt");
            }

            public string GetFileContent()
            {
                using (var outputFile = new StreamReader(_filePath))
                {
                    return outputFile.ReadToEnd();
                }
            }

            public void WriteFileContent(string content)
            {
                
                // A stream is a set of data that is being proccessed in CHUNKS, ie, 
                // not all at once
                using (StreamWriter outputFile = new StreamWriter(_filePath, true)) 
                { 
                    outputFile.WriteLine(content);
                }
            }
        }
    }
}

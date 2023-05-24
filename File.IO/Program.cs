using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


// the system io namespace contains classes that are used to use operations on files like read from file and write to file 
// delete and create files . 

// here are some non abstract classes that we can use . 

// binary reader : reads primitive data from binary stream.
// binary writer : writes primitive data in binary format .
// buffered stream : a temprary storage for a stream of types.
// Directory :  Helps in manipulating a directory structure . 
// DirectoryInfo : used to perform operations on directiores.
// DriveInfo : Provides information for the drivers 
// File : Helps in Manipulating files . 
// FileInfo : used to perform operations on files.
// FileStream : used to read and write to any location in a file.
// MemoryStream : used for random access to streamed data stored in memory .
// Path : performs operations on path information . 
// StreamReader : used for reading characters from a byte stream.
// StreamWriter : used for writing characters to stream.
// StringWriter : used to wrtie to a string buffer  
// StringReader : used to Read from a string buffer. 




namespace File.IO
{
    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("b.txt", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

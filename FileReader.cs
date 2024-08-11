using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CST276Assign1
{
    class FileReader : Reader
    {
        //instantiate with a filename
        //it should open the  file for reading
        //when Read() is called, it will return the next line of text in the file
        //when Close() is called, it will close the file

        public string fileName;
        public FileStream fileStream;
        public StreamReader streamReader;


        public FileReader(string fileName)
        {
            this.fileName = fileName;
            fileStream = File.OpenRead(fileName);
            streamReader = new StreamReader(fileStream);
        }

        public override string Read()
        {
            return streamReader.ReadLine();
        }

        public override void Close()
        {
            fileStream.Close();
            streamReader.Close();
        }

    }
}

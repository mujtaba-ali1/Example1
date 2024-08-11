using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    class CSVReader : ReaderDecorator
    {
        public string[] values;
        public int index;

        public CSVReader(Reader wrapped) : base(wrapped)
        {
            values = null;
            index = 0;
        }

        public override string Read()
        {
            if (values == null || index >= values.Length)
            {
                //this call to our wrapped reader, should return a line of text
                //containing a collation of values, separated by commas
                // example: "A,24,33,Paddles,Absorbs  B C

                string line = wrapped.Read();

                if (line == null)
                    return null;

                values = line.Split(',');
                index = 0;

            }
            //return the next value
            return values[index++];
        }

        public override void Close()
        {
            wrapped.Close();
        }
    }
}

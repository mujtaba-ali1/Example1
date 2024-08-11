using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276Assign1
{
    abstract class Reader
    {
        abstract public string Read();
        abstract public void Close();
    }

    abstract class ReaderDecorator : Reader
    {
        protected Reader wrapped;
        public ReaderDecorator(Reader wrapped)
        {
            this.wrapped = wrapped;
        }
    }
}

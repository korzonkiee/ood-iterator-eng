using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.CustomCollections;

namespace A3.CustomCollections
{
    class ParsedDataList : ICustomCollection<String>
    {
        private String[] values;
        private int length = 0;

        public ParsedDataList()
        {
            this.values = new String[10];
        }

        public int Size
        {
            get
            {
                return length;
            }
        }

        public void Add(String value)
        {
            values[length] = value;
            if(++length == values.Length)
            {
                String[] newValues = new String[values.Length * 2];
                Array.Copy(values, 0, newValues, 0, values.Length);
                values = newValues;
            }
        }

        public String Get(int n)
        {
            if (n >= length)
            {
                // throw new Exception here
            }

            return values[n];
        }

        public AbstractIterator CreateIterator()
        {
            return new ParsedDataListIterator(this);
        }

        private class ParsedDataListIterator : AbstractIterator
        {
            private readonly ParsedDataList list;
            private int index;
            public ParsedDataListIterator(ParsedDataList list)
            {
                this.list = list;
                index = -1;
            }

            public object Next()
            {
                if (index < list.length - 1)
                {
                    index++;

                    while (index < list.length - 1 && list.values[index].Any(c => char.IsDigit(c)))
                    {
                        index++;
                    }

                    if (index >= list.length)
                        return null;

                    return list.values[index];
                }

                return null;
            }
        }
    }
}

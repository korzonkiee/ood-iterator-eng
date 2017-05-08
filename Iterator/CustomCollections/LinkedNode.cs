using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.CustomCollections
{
    class LinkedNode
    {
        private readonly String _value;

        internal LinkedNode Prev { get; set; }
        internal LinkedNode Next { get; set; }

        internal String Value { get { return _value; } }

        internal LinkedNode(String value)
        {
            this._value = value;
        }
    }
}

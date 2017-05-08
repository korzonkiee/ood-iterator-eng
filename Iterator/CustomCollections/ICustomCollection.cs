using Iterator.CustomCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.CustomCollections
{
    public interface ICustomCollection<T> : ITraversableCollection
    {
        int Size { get; }
    }
}

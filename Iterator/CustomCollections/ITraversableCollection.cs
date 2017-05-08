﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.CustomCollections
{
    public interface ITraversableCollection
    {
        AbstractIterator CreateIterator();
    }
}

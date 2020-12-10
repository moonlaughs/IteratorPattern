using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface BadIIterator
    {
        public void Add(int i);
        public void Remove(int i);
        public bool Find(int i);
    }
}

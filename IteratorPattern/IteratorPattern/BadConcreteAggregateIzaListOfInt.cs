using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class BadConcreteAggregateIzaListOfInt : BadIAggregateIzaListOfInt
    {
        public List<int> myList;
        public BadConcreteAggregateIzaListOfInt()
        {
            myList = new List<int>();
        }
        public BadIIterator Iterator()
        {
            BadConcreteIterator ci = new BadConcreteIterator();
            return ci;
        }
    }
}

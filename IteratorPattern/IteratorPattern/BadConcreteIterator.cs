using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class BadConcreteIterator : BadIIterator
    {
        BadConcreteAggregateIzaListOfInt ca;

        public BadConcreteIterator()
        {
            ca = new BadConcreteAggregateIzaListOfInt();
        }
        public void Add(int i)
        {
            ca.myList.Add(i);
        }

        public bool Find(int myIntObj)
        {
            return ca.myList.Contains(myIntObj);
        }

        public void Remove(int i)
        {
            ca.myList.Remove(i);
        }
    }
}

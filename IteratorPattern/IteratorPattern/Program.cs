using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator pattern");
            Console.WriteLine("==============");

            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }



















            //BadConcreteAggregateIzaListOfInt izaListOfInt = new BadConcreteAggregateIzaListOfInt();
            //BadIIterator ci = izaListOfInt.Iterator();
            //int a = 78;
            //int b = 98;
            //ci.Add(a);
            //ci.Add(b);
            //Console.WriteLine("Do we have 98? " + ci.Find(b));
        }
    }
}

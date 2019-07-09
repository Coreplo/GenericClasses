using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{

    struct Person
    {
        string Name;
        int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Generic Classes");

            Stack<int> intStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            Stack<Person> PersonStack = new Stack<Person>();


            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);

            Console.WriteLine(intStack.Get(1));

            Console.ReadKey();

        }
    }

    class Stack<T>
    {
        int index = 0;
        T[] innerArray = new T[100];
        public void Push(T item)
        {
            innerArray[index++] = item;
        }
        public T Pop()
        {
            return innerArray[--index];
        }
        public T Get(int k)
        {
            return innerArray[k];
        }

    }
}

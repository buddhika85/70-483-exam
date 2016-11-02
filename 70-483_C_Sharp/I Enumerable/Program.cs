using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("");

            string[] array = new string[3];
            array[0] = "A";
            array[1] = "B";
            array[2] = "C";
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("");

            // custom collection with an indexer
            // if you want to use forach on a custom collection,
            // you must implement IEnumerable
            StringCollection stringCollection = new StringCollection();
            stringCollection[0] = "A";
            stringCollection[1] = "B";
            stringCollection[2] = "C";
            foreach (string str in stringCollection)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }

    class StringCollection : IEnumerable
    {
        // string array
        string[] strings = new string[3];

        public string this[int index]
        {
            get
            { /* return the specified index here */
                return strings[index];
            }
            set
            { /* set the specified index to value here */
                strings[index] = value;
            }
        }

        // implement IEnumerable - provide our own implemenation
        public IEnumerator GetEnumerator()
        {
            foreach (string str in strings)
            {
                yield return str;
            }
        }

        //// asking to use IEnumerator on System.Array class
        //public IEnumerator GetEnumerator()
        //{
        //    return strings.GetEnumerator();
        //}
    }

}

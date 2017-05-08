using A3.CustomCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<String> lastNames1 = initLinkedList1();
            ICustomCollection<String> lastNames2 = initLinkedList2();
            ICustomCollection<String> parsedFirstNames = initParsedData();

            var mergedLastNames = new List<string>();
            var firstNames = new List<string>();
            var mergedList = new List<string>();

            Console.WriteLine("\n\n/**** lastNames1 ****/\n");
            var linkedListIterator = lastNames1.CreateIterator();
            var linkedListItem = linkedListIterator.Next();
            while(linkedListItem != null)
            {
                mergedLastNames.Add(((LinkedNode)linkedListItem).Value);
                mergedList.Add(((LinkedNode)linkedListItem).Value);

                Console.WriteLine(((LinkedNode)linkedListItem).Value);
                linkedListItem = linkedListIterator.Next();
            }

            Console.WriteLine("\n\n/**** parsedFirstNames ****/\n");
            var linkedListIterator2 = lastNames2.CreateIterator();
            var linkedListItem2 = linkedListIterator2.Next();
            while (linkedListItem2 != null)
            {
                mergedLastNames.Add(((LinkedNode)linkedListItem2).Value);
                mergedList.Add(((LinkedNode)linkedListItem2).Value);

                Console.WriteLine(((LinkedNode)linkedListItem2).Value);
                linkedListItem2 = linkedListIterator2.Next();
            }

            Console.WriteLine("\n\n/**** parsedFirstNames ****/\n");
            var parsedIterator = parsedFirstNames.CreateIterator();
            var parsedItem = parsedIterator.Next();
            while(parsedItem != null)
            {
                firstNames.Add((string)parsedItem);
                mergedList.Add((string)parsedItem);

                Console.WriteLine((string)parsedItem);
                parsedItem = parsedIterator.Next();
            }

            Console.WriteLine("\n\n/**** Variations of last names and first names ****/\n");
            Display2ElementsVariations(mergedList);

            Console.WriteLine("\n\n/**** Variations of first names and last names ****/\n");
            Display2ElementsVariationsFL(firstNames, mergedLastNames);
        }

        static void Display2ElementsVariations(IList<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    Console.Write($"{{{list.ElementAt(i)}, {list.ElementAt(j)}}}, ");
                }
            }
            Console.WriteLine("\n\n");
        }

        static void Display2ElementsVariationsFL(IList<string> firstNames, IList<string> lastNames)
        {
            for (int i = 0; i < firstNames.Count; i++)
            {
                for (int j = 0; j < lastNames.Count; j++)
                {
                    Console.Write($"{{{firstNames.ElementAt(i)}, {lastNames.ElementAt(j)}}}, ");
                }
            }
            Console.WriteLine("\n\n");
        }

        //DO NOT change code below
        static CustomLinkedList initLinkedList1()
        {
            CustomLinkedList result = new CustomLinkedList();

            result.Add("Smith");
            result.Add("Johnson");
            result.Add("Williams");
            result.Add("Jones");
            result.Add("Davis");
            result.Add("Miller");
            result.Add("Wonder");

            return result;
        }

        static CustomLinkedList initLinkedList2()
        {
            CustomLinkedList result = new CustomLinkedList();

            result.Add("Taylor");
            result.Add("Anderson");
            result.Add("Clark");
            result.Add("Lee");
            result.Add("Schabtsky");

            return result;
        }


        static ParsedDataList initParsedData()
        {
            ParsedDataList result = new ParsedDataList();

            String[] names = { "John", "Marcus", "Steve", "Lucas"};
            Random rnd = new Random();
            int i = 0;
            while (i < names.Length)
            {
                //Console.WriteLine(rnd.Next(0, 100));
                if(rnd.Next(0, 100) > 20)
                {
                    result.Add(rnd.Next(-10, 0).ToString());
                }
                else
                {
                    result.Add(names[i++]);
                }
            } 

            return result;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.CustomCollections;

namespace A3.CustomCollections
{
    class CustomLinkedList : ICustomCollection<String>
    {
        private LinkedNode head;
        private LinkedNode tail;
        private int length = 0;
        
        public void Add(String value)
        {
            LinkedNode newNode = new LinkedNode(value);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public AbstractIterator CreateIterator()
        {
            return new LinkedListIterator(this);
        }

        public int Size
        {
            get
            {
                return length;
            }
        }

        private class LinkedListIterator : AbstractIterator
        {
            private readonly CustomLinkedList list;
            private LinkedNode currentElement;
            public LinkedListIterator(CustomLinkedList list)
            {
                this.list = list;
                currentElement = list.head;
            }

            public object Next()
            {
                if (currentElement != null)
                {

                    while (currentElement != null && currentElement.Value.Any(c => char.IsDigit(c)))
                    {
                        currentElement = currentElement.Next;
                    }

                    if (currentElement == null)
                        return null;

                    var temp = currentElement;
                    currentElement = currentElement.Next;
                    return temp;
                }

                return null;
            }
        }
    }

}

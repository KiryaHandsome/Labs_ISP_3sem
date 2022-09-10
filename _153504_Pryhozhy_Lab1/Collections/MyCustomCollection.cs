using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _153504_Pryhozhy_Lab1.Interfaces;

namespace _153504_Pryhozhy_Lab1.Collections
{
    class Node<T>
    {
        public Node() { }
        public Node(T value, Node<T>? next = null)
        {
            this.value = value;
            this.next = next;
        }

        public Node<T>? next;
        public T? value;
    }
    public class MyCustomCollection<T> : ICustomCollection<T>
    {
        private Node<T>? current, head, tail;
        private int count = 0;

        public MyCustomCollection() { }

        public T this[int index]
        {
            get
            {
                var curr = head;
                for (int i = 0; i < index; i++)
                {
                    curr = curr.next;
                }
                return curr.value;
            }
            set
            {
                var curr = head;
                for (int i = 0; i < index; i++)
                {
                    curr = curr.next;
                }
                curr.value = value;
            }
        }

        public int Count
        {
            get => count;
        }

        public T? Current()
        {
            return current.value;
        }

        public void Next()
        {
            if (current != null)
            {
                current = current.next;
            }
        }

        public T? RemoveCurrent()
        {
            var curr = head;
            while (curr.next != null && curr.next != current)
            {
                curr = curr.next;
            }
            this.current = curr;
            if (curr.next != null)
            {
                curr.next = curr.next.next;
                count--;
            }

            return curr.value;
        }

        public void Reset()
        {
            current = head;
        }

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            //create new node
            Node<T> new_node = new Node<T>(item);
            if (count == 0)
            {
                current = head = tail = new_node;
            }
            else
            {
                tail.next = new_node;
                tail = tail.next;
            }
            count++;
        }
    }
}

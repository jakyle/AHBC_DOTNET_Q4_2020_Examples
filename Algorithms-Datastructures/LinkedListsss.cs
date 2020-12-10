using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class LinkedList<T>
    { 
        // The first Element inside of your LINKED LIST!!!
        private Node<T> Head;  

        public void InsertFront(T item)
        {
            var newNode = new Node<T>(item); 

            newNode.NextNode = Head;
            newNode.PreviousNode = null; 

            if (Head != null)
            {
                Head.PreviousNode = newNode;
            }

            this.Head = newNode;
        }

        public void InsertLast(T item)
        {
            var newNode = new Node<T>(item);

            if (Head == null)
            {
                Head = newNode;
            }

            var lastNode = GetLastNode();
            lastNode.NextNode = newNode;
        }  

        public Node<T> GetLastNode()
        {
            var currentNode = Head;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode;
        }

        public T GetElement(T item)
        {
            var currentNode = Head;
            
            if (currentNode == null)
            {
                return item;
            }

            do
            {
                if (currentNode.Item.Equals(item))
                {
                    return currentNode.Item;
                }

                currentNode = currentNode.NextNode;
            } while (currentNode.NextNode != null);

            return item;
        } 
    }


    public class Node<T>
    {
        public T Item { get; set; }
        public Node<T> NextNode { get; set; }
        public Node<T> PreviousNode { get; set; }

        public Node(T item)
        {
            Item = item;
            PreviousNode = null;
            NextNode = null;
        }
    }
}

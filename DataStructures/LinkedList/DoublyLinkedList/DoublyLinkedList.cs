using System;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size = 0;

        //Addlast
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (IsEmpty()) { head = tail = newNode; }
            else
            {
                tail.next = newNode;
                tail = tail.next;
            }
            size++;
        }

        //Addfirst
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (IsEmpty()) { head = tail = newNode; }
            else
            {
                head.Prev = newNode;
                head = head.Prev;
            }
            size++;
        }

        //Add after

        public void AddAfter(int index, T data)
        {
            if (index < 0 || index > size) { throw new Exception($"Invalid index! It should be from {0} to {size}"); }
            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            Node<T> newNode = new Node<T>(data);
            newNode.next = current.next;
            newNode.Prev = current;
            current.next.Prev = newNode;
            current.next = newNode;
        }

        //Add before

        //Remove At

        //Remove with data

        // Remove first

        // Remove last

        // Clear
        public void Clear()
        {
            Node<T> current = head;
            while (current != null)
            {
                current = current.next;
                current.next = current.Prev = null;
                current = current.next.next;
            }
            head = tail = null;
            size = 0;
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        //COntain

        //Find
    }
}
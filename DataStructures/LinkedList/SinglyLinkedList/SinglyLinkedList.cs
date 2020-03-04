namespace SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        private int size = 0;
        private Node<T> head = null;

        //Add the data at the end of the linked list
        public void AddLast(T data)
        {
            Node<T> current = head;
            if (head == null) { head = new Node<T>(data); return; }
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node<T>(data);
        }

        //Add data at the beginning of the linked list
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = head;
            head = newNode;
        }

        //Add after a sepecific node
        public void AddAfter(Node<T> node, T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }

            Node<T> current = head;
            while (current != node)
            {
                current = current.next;
            }

            Node<T> newNode = new Node<T>(data);
            newNode.next = current.next;
            current.next = newNode;
        }

        //Add before a specific node
        public void AddBefore(Node<T> node, T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }

            Node<T> current = head;
            while (current.next != node)
            {
                current = current.next;
            }

            Node<T> newNode = new Node<T>(data);
            newNode.next = current.next;
            current.next = newNode;
        }

        //Remove value base on node input
        public void RemoveAt(Node<T> node)
        {
            Node<T> current = head;
            if (current.next != node)
            {
                current = current.next;
            }
            current = current.next.next;
        }

        //Remove balue base on data input
        public void RemoveWithData(T Data)
        {
        }

        //RemoveFirst
        public void RemoveFirst()
        {
            Node<T> current = head;
            head = current.next;
            current = null;
        }

        //RemoveLast
        public void RemoveLast()
        {
            Node<T> current = head;
            if (current.next != null)
            {
                current = current.next;
            }
            current.next = null;
        }

        //Clear

        //Contains

        //Find

        //FindLast
    }
}
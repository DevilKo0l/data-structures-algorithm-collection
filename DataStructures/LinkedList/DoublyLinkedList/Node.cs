namespace DoublyLinkedList
{
    public class Node<T>
    {
        public Node<T> next;
        public Node<T> Prev;
        private T data;

        public Node(T newData)
        {
            data = newData;
        }
    }
}
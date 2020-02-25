namespace SinglyLinkedList
{
    public class Node<T>
    {
        public Node<T> next;
        private T data;

        public Node(T newData)
        {
            data = newData;
        }
    }
}
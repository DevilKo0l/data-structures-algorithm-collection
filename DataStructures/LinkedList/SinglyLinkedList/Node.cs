namespace SinglyLinkedList
{
    public class Node<T>
    {
        private Node<T> next;
        private T data;

        public Node(T newData)
        {
            data = newData;
        }
    }
}
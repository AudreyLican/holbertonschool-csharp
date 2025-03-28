using system;

/// <summary>
/// A generic queue class that allows adding and counting elements
/// </summary>
public class Queue<T>
{
    /// <summary> Fisrt node in the queue</summary>
    public Node head = null;

    /// <summary> Last node in the queue</summary>
    public Node tail = null;

    /// <summary> Count Element </summary>
    int count = 0;

    /// <summary> check type of parameter</summary>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary> Count a queue.</summary>
    public int Count()
    {
        return (count);
    }

    /// <summary> Adds to a queue </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public class Node
    {
        /// <summary> The value of a node. </summary>
        public T value;

    /// <summary> NenewNodet node. </summary>
        public Node next;

    /// <summary> Constructor for node.
    // Initializes a new node with the given value</summary>
        public Node(T val)
        {
            this.value = val;
        }
    }
}

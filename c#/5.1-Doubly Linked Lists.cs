public class Node
{
    public int val;
    public Node next;
    public Node prev;

}

public class MyLinkedList
{

    public Node head;
    public Node tail;

    public MyLinkedList()
    {

    }

    public int Get(int index)
    {

        if (head == null) return -1;
        if (index < 0) return -1;

        Node node = head;
        index--;
        while (index >= 0)
        {
            if (node == null) return -1;
            node = node.next;
            index--;
        }

        return node == null ? -1 : node.val;

    }

    public void AddAtHead(int val)
    {
        Node newNode = new Node();
        newNode.next = head;
        newNode.val = val;

        if (head != null) head.prev = newNode;
        head = newNode;

        if (tail == null) tail = head;
    }

    public void AddAtTail(int val)
    {
        Node newNode = new Node();
        newNode.prev = tail;
        newNode.val = val;

        if (tail != null) tail.next = newNode;
        tail = newNode;

        if (head == null) head = tail;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0) return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        int length = 0;
        Node curr = head;
        Node nodeToMove = null;
        while (curr != null)
        {
            length++;

            if (index == length - 1) nodeToMove = curr;

            curr = curr.next;
        }

        if (index == length)
        {
            AddAtTail(val);
            return;
        }

        if (index > length - 1) return;

        Node newNode = new Node();
        newNode.next = nodeToMove;
        newNode.prev = nodeToMove.prev;
        newNode.val = val;

        nodeToMove.prev.next = newNode;
        nodeToMove.prev = newNode;

    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0) return;

        if (index == 0)
        {
            if (head == null) return;
            head = head.next;

            if (head != null) head.prev = null;
            return;
        }

        int length = 0;
        Node curr = head;
        Node nodeToMove = null;
        while (curr != null)
        {
            length++;

            if (index == length - 1) nodeToMove = curr;

            curr = curr.next;
        }

        if (index == length - 1)
        {
            if (tail == null) return;
            tail = tail.prev;

            if (tail != null) tail.next = null;
            return;
        }

        if (index > length - 1) return;
        nodeToMove.prev.next = nodeToMove.next;
        nodeToMove.next.prev = nodeToMove.prev;

        nodeToMove.next = null;
        nodeToMove.prev = null;
    }
}
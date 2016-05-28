using System.IO;
using System;

class Node {
    public int data;
    public Node next;
    
    public void print() {
        Node currentNode = this;
                
        while (currentNode != null) {
            Console.WriteLine(currentNode.data.ToString());
            currentNode = currentNode.next;
        }
    }
    public static Node generateExampleNodeList(int start, int len) {
        if (len == 0) {
            return null;
        }
        Node headNode = null, currentNode = null;
        int val = start;
        var rnd = new System.Random();
        while (len > 0) {
            Node newNode = new Node();
            newNode.data = val;
            newNode.next = null;
            if (headNode == null) {
                headNode = currentNode = newNode;                
            } else {
                currentNode.next = newNode;
                currentNode = newNode;
            }
            len--;
            if (rnd.NextDouble() > 0.5) {
                val++;
            }
        }
        return headNode;
    }
    
    public static Node Merge (Node head1, Node head2) {
        Node headNode = null, currentNode = null;
        while (head1 != null || head2 != null) {
            Node newNode = new Node();
            newNode.next = null;        
            if (head1 == null || (head2 != null && head1.data > head2.data)) {
                newNode.data = head2.data;
                head2 = head2.next;
            } else {
                newNode.data = head1.data;
                head1 = head1.next;
            }
            if (headNode == null) {
                headNode = currentNode = newNode;        
            } else {
                currentNode.next = newNode;
                currentNode = newNode;        
            }
        }
        return headNode;
    }
};

class Program
{
    static void Main()
    {
        var list1 = Node.generateExampleNodeList(1, 10);
        var list2 = Node.generateExampleNodeList(1, 5);
        Console.WriteLine("list1");
        list1.print();
        Console.WriteLine("list2");
        list2.print();
        Console.WriteLine("merge");
        Node.Merge(list1, list2).print();
    }
}


Node Merge (Node head1, Node head2) {
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

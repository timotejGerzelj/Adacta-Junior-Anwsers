using System;
//It works but need too work on error handling, testing it out a bit more, etc.. etc.., Implement an iterator
//The challenge was nice and tested out my skills, but implementing a singly linked list definetly limited some coding solutions
//The biggest one I can think of is the Pop method since instead of just viewing the previousNode that a doubly linked list would have
//I have too iterate all the way too the Tail too find the 2nd last element   
namespace LinkedList
{
    public class List
    {
        private int length = 0;
        private Node head;
        private Node tail;
        public List(){
            head = null;
            tail = null;   
        }
        
        public Node Head {
            get {return head;}
            set {head = value;}
        }
        public Node Tail {
            get {return tail;}
            set {tail = value;}
        }
        
        public Node Iterate(Node n)
        {
            return n.NextNode;
        }

        /* checks if the array is empty with first if and checks
        if Tail is empty if either one is empty we fill make the new Node 
        Head AND/OR Tail 
        */ 
        public void Append(int e) {
            Node newNode = new Node(e);
            if (Head == null){
                Head = newNode;
            }
            if (Tail == null){
                Tail = newNode;
            } 
            else {
                Tail.NextNode = newNode;
            }
            length++;
            Tail = newNode;
        }
        // Replaces Head with the newNode and gives newNode the original Head as nextNode
        public void Prepend(int e) {
            Node newNode = new Node(e, Head);
            newNode.setNext(Head);
            Head = newNode;
            length++;
        }

        // Returns the index at which the element is located
        public int Search(int x){
            int count = -1; 
            Node currentNode = Head;
            while (true) {
                if (currentNode.NextNode == null){
                    Console.WriteLine("Failure: Number is not inside of the Array");
                    break;
                }
                if (currentNode.Element == x){
                    break;
                }
                else {
                    count++;
                    currentNode = Iterate(currentNode);
                }

            }
            return count == -1 ? 0 : count;
        }
        private Node FindNode(int index){
            Node current = Head; 
            for (int i = 0; i < index; i++){
                current = Iterate(current);
            }
            Console.WriteLine(current.Element); 
            return current;
        }
        // Returns the Tail and removes it from array, assigning the next last node as the Tail
        public int Pop(){
            if (Head == null){
                throw new ArgumentNullException("Array is empty");
            }
            int tooReturn = Tail.Element;
            Node currentNode = Head;
            while (true)  { 
                if (currentNode.NextNode == Tail){
                    currentNode.NextNode = null;
                    Tail = currentNode;
                    break;
                }
                else {
                    currentNode = Iterate(currentNode);
                }
            }
            return tooReturn;
        } 
        // Works only with positive numbers, checks if the index isn't to long
        public void Insert(int e, int index){
            if (length < index){
                Console.WriteLine("Index longer than the list!");
                return;
            }
            if (index == 0){
                Prepend(e);
                return;
            }
            Node newNode = new Node(e);
            Node lastNode = FindNode(index - 1);
            newNode.NextNode = lastNode.NextNode;
            lastNode.NextNode = newNode;
            if (newNode.NextNode == null){
                Tail = newNode; 
            }
        }
        // Prints a formatted array
        public void PrintList(){
            Node currentNode = Head;
            bool over = false;
            System.Console.Write("[ ");
            while (over != true)  { 
                if (currentNode == Tail){
                    System.Console.Write(currentNode.Element + " ]");
                    over = true;
                }
                else {
                    Console.Write(currentNode.Element + " -> ");  
                    currentNode = Iterate(currentNode);
                }
            }
            Console.WriteLine();  
        }
    }
}
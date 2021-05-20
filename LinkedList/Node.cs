using System;

namespace LinkedList
{
    public class Node
    {
        private int element;
        private Node nextnode;
        public Node(int elementVal, Node nextnode = null ) { 
            element = elementVal;    
        }
        public int Element 
        {
            get { return element; }
            set {element = value;} }
        public Node NextNode {
            get {return nextnode;}
            set {nextnode = value;
            }}
        public void setNext(Node newNext) {NextNode = newNext;}
    }


    }
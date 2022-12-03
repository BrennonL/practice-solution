using System;

namespace LinkedList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myLinkedList = new LinkedList();
            myLinkedList.addNewElement("Sam");
            myLinkedList.addNewElement("Jill");
            myLinkedList.addNewElement("Bob");
            
            // Test
            // Test
            myLinkedList.insertAfterSecond("Sally");
            myLinkedList.insertAfterSecond("Jimmy");
            
            myLinkedList.printLinkedList();
        }
    }
}
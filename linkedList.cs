
namespace LinkedList
{
    public class LinkedList 
    {
        private Node? _head {get; set;} 
        private Node? _tail {get; set;}
        private class Node
        {
            public Node? Next = null;
            public Node? Previous = null;
            public string? Data = null;

            public Node(string data)
            {
                Data = data;
            }
        }

        public void addNewElement(string value)
        {
            var newNode = new Node(value);
            if (_head is null)
            {
                _head = newNode;
                _tail = newNode;
            }

            else
            {
                Console.WriteLine(_head.Data);
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
                
            }

        }

        public void printLinkedList()
        {
            var curr = _head;
            Console.WriteLine(curr.Data);
            curr = curr.Next;
            bool run = true;
            while (run)
            {

                if (curr == _tail)
                {
                    Console.WriteLine(curr.Data);
                    run = false;
                }
                else
                {
                    Console.WriteLine(curr.Data);
                    curr = curr.Next;
                }
            }
            
        }

        public void insertAfterSecond(string name)
        {
            var newNode = new Node(name);
            _head.Next.Previous = newNode;
            newNode.Next = _head.Next;
            _head.Next = newNode;
            newNode.Previous = _head;
            


        }
    }
}
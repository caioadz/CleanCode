public class Queue<T>
{
    Stack<T> _input = new Stack<T>();
    Stack<T> _output = new Stack<T>();

    public void Enqueue(T item)
    {
        _input.Push(item);
    }

    public T Dequeue()
    {
        RefillOutputIfEmpty();
        return _output.Pop();
    }

    public T Peek()
    {
        RefillOutputIfEmpty();
        return _output.Peek();
    }

    private void RefillOutputIfEmpty()
    {
        if (!IsOutputEmpty()) return;
        RefillOutput();
    }

    private void IsOutputEmpty()
    {
        return _output.Count == 0;
    }

    private void RefillOutput()
    {
        while (_input.Count > 0)
            _output.Push(_input.Pop());
    }
}
    
class Solution
{
    var _queue = new Queue<string>();

    static void Main(string[] args) 
    {
        int num_of_operations = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < num_of_operations; i++)
        {
            string[] operation = Console.ReadLine().Split(' ');
            ExecuteOperation(operation)
        }
    }

    static void ExecuteOperation(string[] operation)
    {            
        switch(operation[0])
        {
            case "1":
                _queue.Enqueue(operation[1]);
                break;
            case "2":
                Console.WriteLine(_queue.Dequeue());
                break;
            case "3":
                Console.WriteLine(_queue.Peek());
                break;
        }
    }
}
# https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem

class Solution
{
    static void Main(String[] args) 
    {
        Stack<T> _input = new Stack<T>();
        Stack<T> _output = new Stack<T>();

        int num_of_operations = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < num_of_operations; i++)
        {
            string[] operation = Console.ReadLine().Split(' ');

            switch(operation[0])
            {
                case "1":
                    _input.Push(operation[1]);
                    break;
                case "2":
                    if (_output.Count == 0)
                    {
                        while (_input.Count > 0)
                            _output.Push(_input.Pop());
                    }
                    Console.WriteLine(_output.Pop());
                    break;
                case "3":
                    if (_output.Count == 0)
                    {
                        while (_input.Count > 0)
                            _output.Push(_input.Pop());
                    }
                    Console.WriteLine(_output.Peek())
                    break;
            }
        }
    }
}

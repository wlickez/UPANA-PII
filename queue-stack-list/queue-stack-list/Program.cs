internal class Program
{
    private static void Main(string[] args)
    {
        //Queue<int> queue = new Queue<int>();

        //Console.WriteLine("Cantidad elementos:" + queue.Count);

        //for (int i = 0; i < 100; i++)
        //{
        //    queue.Enqueue(i);
        //}
        //int n = queue.Count;
        //for(int i = 0; i < n; i++)
        //{           
        //    Console.WriteLine("Se está atendiendo: {0}", queue.Dequeue());
        //    Console.WriteLine("Cantidad elementos:" + queue.Count);
        //}

        //Console.WriteLine("Cantidad elementos:" + queue.Count);


        Stack<int> stack = new Stack<int>();
        Console.WriteLine("Cantidad elementos:" + stack.Count);

        for (int i = 0; i < 100; i++)
        {
            stack.Push(i);
        }
        int n = stack.Count;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Se está atendiendo: {0}", stack.Pop());
            Console.WriteLine("Cantidad elementos:" + stack.Count);
        }

        Console.WriteLine("Cantidad elementos:" + stack.Count);

        List<int> enteros = new List<int>();

        enteros.Add(0);

        enteros.Remove(0);

        enteros[0] = enteros[1];


    }

    public class Alumno() { }

}
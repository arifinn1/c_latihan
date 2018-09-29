using System;
using System.Collections;

namespace Latihan1.BAB6
{
    class StackCol
    {
        static void Stack1()
        {
            Stack myStack = new Stack();
            myStack.Push("Selamat Datang");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            foreach (var item in myStack) Console.WriteLine(item);
        }

        static void Stack2()
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());
        }

        static void Stack3()
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine("Jumlah elemen pada Stack : {0}", myStack.Count);

            while (myStack.Count > 0) Console.WriteLine(myStack.Pop());

            Console.WriteLine("Jumlah elemen pada Stack : {0}", myStack.Count);
        }

        static void Stack4()
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine(myStack.Contains(2));
            Console.WriteLine(myStack.Contains(10));
        }

        static void Stack5()
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            myStack.Clear();

            Console.Write("Jumlah elemen pada Stack : {0}", myStack.Count);
        }

        static void Queue1()
        {
            Queue q1 = new Queue();
            q1.Enqueue(3);
            q1.Enqueue(2);
            q1.Enqueue(1);
            q1.Enqueue("Empat");

            Console.WriteLine("Jumlah elemen pada Queue : {0}", q1.Count);

            while (q1.Count > 0) Console.WriteLine(q1.Dequeue());

            Console.WriteLine("Jumlah elemet pada Queue : {0}", q1.Count);
        }

        static void Queue2()
        {
            Queue q1 = new Queue();
            q1.Enqueue(3);
            q1.Enqueue(2);
            q1.Enqueue(1);
            q1.Enqueue("Empat");

            Console.WriteLine("Jumlah elemen pada Queue: {0}", q1.Count);

            Console.WriteLine(q1.Peek());
            Console.WriteLine(q1.Peek());
            Console.WriteLine(q1.Peek());

            Console.WriteLine("Jumlah elemen pada Queue: {0}", q1.Count);
        }

        static void Queue3()
        {
            Queue q1 = new Queue();
            q1.Enqueue(3);
            q1.Enqueue(2);
            q1.Enqueue(1);
            q1.Enqueue("Empat");

            Console.WriteLine(q1.Contains(2));
            Console.WriteLine(q1.Contains(100));
        }

        static void Queue4()
        {
            Queue q1 = new Queue();
            q1.Enqueue(3);
            q1.Enqueue(2);
            q1.Enqueue(1);
            q1.Enqueue("Empat");

            Console.WriteLine("Jumlah elemen pada Queue: {0}", q1.Count);

            q1.Clear();

            Console.WriteLine("Jumlah elemen pada Queue: {0}", q1.Count);
        }

        static void Main()
        {
            Queue4();
            Console.ReadLine();
        }
    }
}

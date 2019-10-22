using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise_06
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyStack S = new MyStack();
            S.Push(4);
            S.Push(2);
            S.Push(3);
            S.Push(9);

            Console.WriteLine("stack");
            Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", S.Pop());
            Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", S.Pop());
            Console.WriteLine("số lượng phần tử trong danh sách {0}", S.count);

            Console.WriteLine("=======================================");
            MyQueue Q = new MyQueue();
            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);

            Console.WriteLine("Queue");
            Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", Q.Dequeue());
            Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", Q.Dequeue());
            Console.WriteLine("số lượng phần tử trong danh sách {0}", Q.count);

            Console.ReadKey();
        }
    }
}
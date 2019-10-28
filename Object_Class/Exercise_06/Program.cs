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
        //    MyStack S = new MyStack(6);
        //    S.Push("4");
        //    S.Push("2");
        //    S.Push("3");
        //    S.Push("9");

        //    Console.WriteLine("stack");
        //    Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", S.Pop());
        //    Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", S.Pop());
        //    Console.WriteLine("Bạn đã lấy phần tử {0}", S.peek());
        //    Console.WriteLine("số lượng phần tử trong danh sách {0}", S.Count());
        //    S.Clear();
        //    Console.WriteLine("số luong con sau khi clear {0}", S.Count());

            Console.WriteLine("=======================================");
            MyQueue Q = new MyQueue(5);
            Q.EnQueue("3");
            Q.EnQueue("4");
            Q.EnQueue("5");
            Q.EnQueue("6");
            Console.WriteLine("số lượng phần tử là ban đầu: {0}", Q.count());
            Console.WriteLine("DeQueue phần tử : {0}", Q.DeQueue());
            Console.WriteLine("số lượng phần tử là {0}", Q.count());
            Console.WriteLine("Peek phần tử {0}", Q.Peek());
            Console.WriteLine("số lượng phần tử là {0}", Q.count());
            Console.WriteLine("DeQueue phần tử : {0}", Q.DeQueue());
            Console.WriteLine("số lượng phần tử là {0}", Q.count());


            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise_06
{
    public class MyStack
    {
        //public Stack S = new Stack();
        //int top = 0;
        //public int Count;
        //public void Push(int item)
        //{
        //    S.Push(item);
        //    top++;
        //    Count = top;
        //}
        //public int Pop()
        //{
        //    top--;
        //    Count = top;
        //    return (int)S.Pop();
        //}



        //public int Peek()
        //{
        //    return (int)S.Peek();
        //}

        int Length = 10;
        int top = 0;
        int[] array = new int[10];
        int a = 0;
        public int count;
        public bool IsEmpty()
        {
            return top == 0 ? true : false;
        }

        public bool IsFull()
        {
            return top == Length ? true : false;
        }

        public void Push(int item)
        {
            if (IsFull() == true)
            {
                Console.WriteLine("phần tử đã đầy");
                return;
            }
            top++;
            count = top;
            array[top] = item;
        }

        public int Pop()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("ko còn phần tử để xóa");
                return 0;
            }

            a = array[top];
            array[top] = 0;
            top--;
            count = top;
            return a;
        }

        public int peek()
        {
            return array[top];
        }


    }
}
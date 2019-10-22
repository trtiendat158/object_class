using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise_06
{
    class MyQueue
    {
        int Length = 10;
        int top = 0;
        int[] array = new int[10];
        int a = 0;
        int i = 0;
        public int count;

        public bool IsEmpty()
        {
            return top == -1 ? true : false;
        }

        public bool IsFull()
        {
            return top == Length ? true : false;
        }


        public void Enqueue(int item)
        {
            if (IsFull() == true)
            {
                Console.WriteLine("ko thể Enqueue thêm");
                return;
            }
            top++;
            count = top;
            array[top] = item;
        }

        public int Dequeue()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("ko thể xóa thêm");
                throw new IndexOutOfRangeException();
            }
            a = array[i + 1];
            i++;
            top--;
            count = top;
            return a;
        }

        public int Peek()
        {
            return (int)array[i];
        }

    }
}
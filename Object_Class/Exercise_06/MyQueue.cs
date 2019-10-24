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
       
        int top;
        int[] array;
        int i;

        public MyQueue(int size)
        {
            array = new int[size];
        }
        public bool IsEmpty()
        {
            return top == -1 ? true : false;
        }

        public bool IsFull()
        {
            return top == array.Length-1 ? true : false;
        }


        public void Enqueue(int item)
        {
            if (IsFull() == true)
            {
                return;
            }
            top++;           
            array[top] = item;
        }

        public int Dequeue()
        {
            if (IsEmpty() == true)
            {
                throw new IndexOutOfRangeException();
            }
            i++;
            top--;
            return array[i+1];
        }

        public int Peek()
        {
            return (int)array[i];
        }

        public int Count()
        {
            int Count;
            return Count = top + 1;
        }
        public void Clear()
        {
            top = -1;
        }

    }
}
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
        int top = -1;
        string[] array;

        public MyStack(int size)
        {
            array = new string[size];
        }
        public void Push(string item)
        {
            top++;
            array[top] = item;
        }
        public string Pop()
        {
            string a = array[top];
            top--;
            return a;
        }
        public string peek()
        {
            return array[top];
        }
        public int Count()
        { 
            return top + 1;
        }
        public void Clear()
        {
            top = -1;
        }

    }
}
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

        int top=-1, i, length;
        string[] array;

        public MyQueue(int size)
        {
            array = new string[size];
        }

        public void EnQueue(string item)
        {   
            array[top + 1] = item;
            top++;
            length = top + 1;
        }

        public string DeQueue()
        {
            string a = array[i];
            i++;
            top++;
            length = top - i;
            return a;
        }

        public string Peek()
        {
            return array[i];
        }

        public int count()
        {
            return length ;
        }
        
    }
}
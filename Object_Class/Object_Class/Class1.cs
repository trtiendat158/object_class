using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          
            Account ql = new Account(0);
            while (true)
            {
                ql.Showmenu();
            }
        }
    }
}
    
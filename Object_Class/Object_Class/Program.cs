using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
   public class Account
    {
        private int tongtien;
        public int TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public Account(int money)
        {
            TongTien = money;
        }

        public int WithDraw(int amount)
        {
            TongTien -= amount;
            return TongTien;
        }

        public int Deposit(int amount)
        {
            TongTien += amount;
            return TongTien;
        }

        public int Balance()
        {
            Console.WriteLine("Your current amount is {0} ", TongTien);
            return TongTien;
        }
        public void WithDrawUser()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw:     (Press Q to return to menu)");
            String ADDuser = Console.ReadLine();
            int a = 0;
            if (Int32.TryParse(ADDuser, out a))
            {
                WithDraw(a);
                Console.WriteLine(" You have withdraw {0} VND from your account", a);
            }
            else if (ADDuser.ToUpper().Equals("Q"))
            {
                Console.Clear();
                Showmenu();
            }
            else
            {
                Console.WriteLine("Error ! Please enter the amount to be paid");
            }
        }
        public void DepositUser()
        {
            Console.WriteLine("Please enter the amount you want to send:     (Press Q to return to the menu)");
            String ADDuser = Console.ReadLine();
            int a = 0;
            if (Int32.TryParse(ADDuser, out a))
            {
                Deposit(a);
                Console.WriteLine("You have added {0} to your account ", a);
            }
            else if (ADDuser.ToUpper().Equals("Q"))
            {
                Console.Clear();
                Showmenu();
            }
            else
            {
                Console.WriteLine("Error ! Please enter a valid amount");
            }
        }
        public void Showmenu()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("\t BANK ACCOUNT MANAGEMENT"
                + Environment.NewLine
                + "1. Deposit"
                + Environment.NewLine
                + "2. Withdraw"
                + Environment.NewLine
                + "3. Balance");
            Console.Write("Choose: ");
            string usercomand = Console.ReadLine();
            Console.Clear();
            int a = 0;
            if (int.TryParse(usercomand, out a))
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("You have choose DrawUser on your Account");
                        DepositUser();
                        break;
                    case 2:
                        Console.WriteLine("You have choose Deposit on your Account");   
                        WithDrawUser();
                        break;
                    case 3:
                        Console.WriteLine("You have choose Banlance on your Account");
                        Balance();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter the correct index in the menu");
            }
        }
    }
}
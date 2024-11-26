//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Event_Delegate
//{
//    public delegate void DisplayMessage();
//    public class Bank
//    {
//        public event DisplayMessage LowBal;
//        public event DisplayMessage ZeroBal;
//        public event DisplayMessage InsufficientBal;
//        private double bal;
//        public Bank(double bal)
//        {
//            this.bal = bal;
//        }
//        public void Debit(double amt)
//        {
//            if (amt > bal)
//            {
//                Console.WriteLine("Debit amount : " + amt);
//                InsufficientBal();
//            }
//            else
//            {
//                bal -= amt;
//                Console.WriteLine("Debit amount : " + amt);
//                Console.WriteLine("Balance : " + bal);
//                Balance();
//            }
//        }
//        public void Credit(double amt)
//        {
//            if (amt > 0)
//            {
//                bal += amt;
//                Console.WriteLine("Credit amount : " + amt);
//                Console.WriteLine("Balance : " + bal);
//                Balance();
//            }
//        }
//        public void Balance()
//        {
//            if (bal == 0)
//            {
//                ZeroBal();
//            }
//            else if (bal < 3000)
//            {
//                LowBal();
//            }
//        }
//    }
//    public class Program
//    {
//        static void LowBalance()
//        {
//            Console.WriteLine("Low balance");
//        }
//        static void ZeroBalance()
//        {
//            Console.WriteLine("Zero balance");
//        }
//        static void InsufficientBalance()
//        {
//            Console.WriteLine("Insufficient balance");
//        }
//        static void Main(string[] args)
//        {
//            Bank b1 = new Bank(10000);
//            b1.LowBal += new DisplayMessage(LowBalance);
//            b1.ZeroBal += new DisplayMessage(ZeroBalance);
//            b1.InsufficientBal += new DisplayMessage(InsufficientBalance);
//            b1.Credit(12000);
//            b1.Debit(21000);
//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Event_Delegate
//{
//    public class Event
//    {
//        public delegate void DisplayMessage();
//        public class Student
//        {
//            // event
//            public event DisplayMessage Pass;// it is an event name
//            public event DisplayMessage Fail;

//            public void AcceptMarks(int marks)
//            {
//                if (marks >= 40)
//                {
//                    Pass();  // raise an event /  call to event
//                }
//                else
//                {
//                    Fail();
//                }
//            }
//        }


//        public class Program
//        {
//            static void PassMsg()
//            {
//                Console.WriteLine("Congratulations ! You are pass with good score");
//            }
//            static void FailMsg()
//            {
//                Console.WriteLine("OOPs ! You are Fail");
//            }
//            static void Main(string[] args)
//            {
//                Student stud = new Student();
//                // bind event with delegate / configuration
//                stud.Pass += new DisplayMessage(PassMsg);
//                stud.Fail += new DisplayMessage(FailMsg);

//                stud.AcceptMarks(30);
//            }
//        }
//    }
//}

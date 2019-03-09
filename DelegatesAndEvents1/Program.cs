using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents1
{
    // Saksham Saksham (C0732116)
    // CSD3354 Section 2
    // Assignment 2
    // March 8, 2019
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate();

            void Method1()
            {
                System.Console.WriteLine("MyDelegate");
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }


    }
}


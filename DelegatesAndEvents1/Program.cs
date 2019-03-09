﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents1
{
    // Saksham Saksham (C0732116)
    // Manjot Kaur (C0732136)
    // Chetan Rahanoo (C0732135)
    // CSD3354 Section 2
    // Assignment 2
    // March 8, 2019
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            try
            {
                delegateExercises.Method3();
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Exception Occurred.");
                Console.ReadLine();

            }
        }
    }

    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method1()
        {
            throw new System.Exception();
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}


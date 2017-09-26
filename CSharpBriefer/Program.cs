﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBriefer
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Integer: " + 10 +
                " Double: " + 3.14 +
                " Boolean: " + true);
            string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";
            Console.WriteLine(fooString);

            char charFromString = fooString[2];
            string fooFs = string.Format("Check Check, {0} {1}, {0} {1:0.0}", 1, 2);
            DateTime fooDate = DateTime.Now;
            Console.WriteLine(fooDate.ToString("hh:mm, dd MMM yyyy"));
            string bazString = @"Here's some stuff
on a new line! ""Wow!"", the masses 
cried";
            const int HoursWorkPerWeek = 9001;
            Console.WriteLine("\n->Operators");
            int i1 = 1, i2 = 2; // Shorthand for multiple declarations

            // Arithmetic is straightforward
            Console.WriteLine(i1 + i2 - i1 * 3 / 7); // => 3


            //Change Git
            //Change 2

            string s = "Hello Extension Methods";
            int i = s.WordCount();

            A a = new A();
            B b = new B();
            C c = new C();

            a.MethodA(1);           // Extension.MethodA(object, int)
            a.MethodA("hello");     // Extension.MethodA(object, string)

            a.MethodB();            // A.MethodB()

            b.MethodA(1);           // B.MethodA(int)
            b.MethodB();            // B.MethodB()

            b.MethodA("hello");     // Extension.MethodA(object, string)

            c.MethodA(1);           // C.MethodA(object)
            c.MethodA("hello");     // C.MethodA(object)
            c.MethodB();            // C.MethodB()

            int? nullable = null; // short hand for Nullable<int>
            Console.WriteLine("Nullable variable: " + nullable);

            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

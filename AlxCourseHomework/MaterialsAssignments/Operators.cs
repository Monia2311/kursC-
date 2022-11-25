using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Operators
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 17=================");

            int A = 3;
            int B = 6;
            int C = 15;
            //int Result2 = (A ^ B);
            //Console.WriteLine(Result2);
            int Result = ((A ^ B) / 2) % C;
            Console.WriteLine($"The result of a matehematical operation: {Result}");
            Result += 5;
            Console.WriteLine($"The value of result after adding 5: {Result}");
            int D = Result > A ? Result : A;
            Console.WriteLine($"{D} has the greater value.");


            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 17=================");
            Console.WriteLine("___________de Morgan's first law___________________");
            Console.WriteLine("(~(p & q)) <=> ((~p) || (~q))");
            bool a = true;
            Console.WriteLine($"a = {a}");
            bool b = true;
            Console.WriteLine($"b = {b}");
            bool p1 = !(a && b);
            Console.WriteLine($"!(a && b) = {p1}");
            bool q1 = ((!a)||(!b));
            Console.WriteLine($"((!a) || (!b)) = {q1}");
            bool s = (p1 == q1) ? a : (!a);
            Console.WriteLine($"De Morgan's first low is: {s}");
            Console.WriteLine("///////////////////////////////////////////");
            bool c = false;
            Console.WriteLine($"a = {c}");
            bool d = false;
            Console.WriteLine($"b = {d}");
            bool p2 = !(c && d);
            Console.WriteLine($"!(a && b) = {p2}");
            bool q2 = ((!c) || (!d));
            Console.WriteLine($"((!a) || (!b)) = {q2}");
            bool s2 = (p2 == q2) ? a : (!a);
            Console.WriteLine($"De Morgan's first low is: {s2}");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {d}");
            bool p3 = !(a && d);
            Console.WriteLine($"!(a && b) = {p3}");
            bool q3 = ((!a) || (!d));
            Console.WriteLine($"((!a) || (!b)) = {q3}");
            bool s3 = (p3 == q3) ? a : (!a);
            Console.WriteLine($"De Morgan's first low is: {s3}");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine($"a = {d}");
            Console.WriteLine($"b = {a}");
            bool p4 = !(d && a);
            Console.WriteLine($"!(a && b) = {p4}");
            bool q4 = ((!d) || (!a));
            Console.WriteLine($"((!a) || (!b)) = {q4}");
            bool s4 = (p4 == q4) ? a : (!a);
            Console.WriteLine($"De Morgan's first low is: {s4}");
            Console.WriteLine("///////////////////////////////////////////");

        }
    }
}

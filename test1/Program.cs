using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class methed
    {
        public double plus(double p1, double p2)
        {
            return p1 + p2;
        }
        public void plus(string p1, string p2)
        {
            Console.Write(p1);
            Console.WriteLine(p2);
        }
        public double subtract(double s1, double s2)
        {
            return s1 - s2;
        }
        public string subtract(string s1, string s2)
        {
            var s3 = s1.Replace(s2, string.Empty);//将要减去的字符串变成空
            return s3;
        }
        public double multiplication(double m1, double m2)
        {
            return m1 * m2;
        }
        public double division(double d1, double d2)
        {
            return d1 / d2;
        }
        public bool equal(double e1, double e2)
        {
            if (e1 == e2)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            methed count = new methed();
            Console.WriteLine("选择进行的操作，进行字符串输入：字符串，进行数字操作输入：数字");
            string f = Console.ReadLine();
            Console.WriteLine("输入,enter结束");
            string a = Console.ReadLine();
            Console.WriteLine("输入+、-、*、/、=？（是否等于）任意一个符号");
            string c = Console.ReadLine();
            Console.WriteLine("再次输入,enter结束");
            string b = Console.ReadLine();
            if (f == "字符串")
            {
                if (c == "+")
                {
                    count.plus(a, b);
                }
                else if (c == "-")
                {
                    Console.Write("{0}", a);
                    Console.Write("-{0}", b);
                    Console.WriteLine("={0}", count.subtract(a, b));
                }
            }
            else if (f == "数字")
            {
                double d = double.Parse(a);
                double e = double.Parse(b);
                if (c == "+")
                {
                    Console.Write("{0}", a);
                    Console.Write("+{0}", b);
                    Console.WriteLine("={0}", count.plus(d, e));
                }
                else if (c == "-")
                {
                    Console.Write("{0}", a);
                    Console.Write("-{0}", b);
                    Console.WriteLine("={0}", count.subtract(d, e));
                }
                else if (c == "*")
                {
                    Console.Write("{0}", a);
                    Console.Write("*{0}", b);
                    Console.WriteLine("={0}", count.multiplication(d, e));
                }
                else if (c == "/")
                {
                    Console.Write("{0}", a);
                    Console.Write("/{0}", b);
                    Console.WriteLine("={0}", count.division(d, e));
                }
                else if (c == "=?")
                {
                    if (count.equal(d, e))
                    {
                        Console.Write("{0}", a);
                        Console.Write("={0}", b);
                    }
                    else
                    {
                        Console.Write("{0}", a);
                        Console.Write("!={0}", b);
                    }
                }
                else
                    Console.WriteLine("输入错误");
            }
            else
                Console.WriteLine("输入错误");
            //try
            //{
            //    double d = double.Parse(a);
            //    double e = double.Parse(c);
            //    if (c == "+")
            //    {
            //        Console.Write("{0}", a);
            //        Console.Write("+{0}", b);
            //        Console.WriteLine("={0}", count.plus(d, e));
            //    }
            //    else if (c == "-")
            //    {
            //        Console.Write("{0}", a);
            //        Console.Write("-{0}", b);
            //        Console.WriteLine("={0}", count.subtract(d, e));
            //    }
            //    else if (c == "*")
            //    {
            //        Console.Write("{0}", a);
            //        Console.Write("*{0}", b);
            //        Console.WriteLine("={0}", count.multiplication(d, e));
            //    }
            //    else if (c == "/")
            //    {
            //        Console.Write("{0}", a);
            //        Console.Write("/{0}", b);
            //        Console.WriteLine("={0}", count.division(d, e));
            //    }
            //    else if (c == "=?")
            //    {
            //        if (count.equal(d, e))
            //        {
            //            Console.Write("{0}", a);
            //            Console.Write("={0}", b);
            //        }
            //        else
            //        {
            //            Console.Write("{0}", a);
            //            Console.Write("!={0}", b);
            //        }
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("无法进行数字运算，进行字符串运算");
            //}
            //finally
            //{
            //    if (c == "+")
            //    {
            //        Console.Write("{0}", a);
            //        Console.Write("+{0}", b);
            //        Console.WriteLine("={0}", count.plus(a,b));
            //    }
            //    else if (c == "-")
            //    {
            //        Console.Write("{0}", a);
            //        Console.Write("-{0}", b);
            //        Console.WriteLine("={0}", count.subtract(a, b));
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
                //Console.WriteLine("输入数字,enter结束");
                //double a = double.Parse(Console.ReadLine());
                //Console.WriteLine("输入+、-、*、/、=？（是否等于）任意一个符号");
                //string c = Console.ReadLine();
                //Console.WriteLine("再次输入数字,enter结束");
                //double b = double.Parse(Console.ReadLine());
                //if (c == "+")
                //{
                //    Console.Write("{0}", a);
                //    Console.Write("+{0}", b);
                //    Console.WriteLine("={0}", count.plus(a, b));
                //}
                //else if (c == "-")
                //{
                //    Console.Write("{0}", a);
                //    Console.Write("-{0}", b);
                //    Console.WriteLine("={0}", count.subtract(a, b));
                //}
                //else if (c == "*")
                //{
                //    Console.Write("{0}", a);
                //    Console.Write("*{0}", b);
                //    Console.WriteLine("={0}", count.multiplication(a, b));
                //}
                //else if (c == "/")
                //{
                //    Console.Write("{0}", a);
                //    Console.Write("/{0}", b);
                //    Console.WriteLine("={0}", count.division(a, b));
                //}
                //else if (c == "=?")
                //{
                //    if (count.equal(a, b))
                //    {
                //        Console.Write("{0}", a);
                //        Console.Write("={0}", b);
                //    }
                //    else
                //    {
                //        Console.Write("{0}", a);
                //        Console.Write("!={0}", b);
                //    }
                //}
            //}
        }
    }
}

using System;
using System.Collections.Generic;

namespace DZ_3_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Values: ");
            Console.WriteLine();

            var dict_a = new Dictionary<int, int>()
            {
                { 1, 1 }, { 2, 2}, { 3, 3}
            };
            
            Console.Write("dict_a = ");

            foreach (var i in dict_a.Values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Leingth = " + dict_a.Count);
            Console.WriteLine();


            var dict_b = new Dictionary<int, int>()
            {
                [11] = 1, [12] = 2, [13] = 3, [14] = 4, [15] = 5
            };

            Console.Write("dict_b = ");

            foreach (var i in dict_b.Values)
            {
                Console.Write(i + " ");
            };
            Console.WriteLine();
            Console.WriteLine("Leingth = " + dict_b.Count);
            Console.WriteLine();


            var dict_c = new Dictionary<int, int>(dict_a);

            foreach (var i in dict_b)
            {
                dict_c[i.Key] = i.Value;
            }

            Console.Write("dict_c = a -> b = ");

            foreach (var i in dict_c.Values)
            {
                Console.Write(i + " ");
            };
            Console.WriteLine();
            Console.WriteLine("Leingth = " + dict_c.Count);
            Console.WriteLine();

            
            var dict_d = new Dictionary<int, int>(dict_a);

            foreach (var i in dict_c)
            {
                dict_d[i.Key+10] = i.Value;
            }

            foreach (var i in dict_b)
            {
                dict_d[i.Key+100] = i.Value;
            }

            Console.Write("dict_d = a -> c -> b = ");

            foreach (var i in dict_d.Values)
            {
                Console.Write(i + " ");
            };
            Console.WriteLine();
            Console.WriteLine("Leingth = " + dict_d.Count);
            Console.WriteLine();

            
            
            
            //В предыдущих сериях:
            //DZ2:
            /*

            List<int> a = new List<int>();

            a.AddRange(new[] { 1, 2, 3 });

            var s = "a = ";

            foreach (var i in a)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length a = " + a.Count);
            Console.WriteLine();


            List<int> b = new List<int> { 1, 2, 3, 4, 5 };

            s = "b = ";

            foreach (var i in b)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length b = " + b.Count);
            Console.WriteLine();


            List<int> c = new();
            c.AddRange(a);
            c.AddRange(b);

            s = "c = a -> b = ";

            foreach (var i in c)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length c = " + c.Count);
            Console.WriteLine();


            List<int> d = new();
            d.AddRange(a);
            d.AddRange(c);
            d.AddRange(b);

            s = "d = a -> c -> b = ";

            foreach (var i in d)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length d = " + d.Count);
            Console.WriteLine();



            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "sdfghjk");
            var f = dict[1];


            Dictionary<int, int> dict_a = new Dictionary<int, int>();
            dict_a.Add(1, 1);
            dict_a.Add(2, 2);
            dict_a.Add(3, 3);

            s = "dict_a = ";

            foreach (var i in dict_a)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length dict_a = " + dict_a.Count);
            Console.WriteLine();

            var dict_aa = 0;

            foreach (var i in s)
            {
                dict_aa = i;
            }
            Console.WriteLine(dict_aa);

            Dictionary<int, int> dict_b = new Dictionary<int, int>() { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 } };

            s = "dict_b = ";

            foreach (var i in dict_b)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length dict_b = " + dict_b.Count);
            Console.WriteLine();




            //DZ1:
            /*
            int m = 3;
            int n = 5;

            var list = new List<int>();
            

            int[] a = new int[m]; //[]
                a[0] = 1;
                a[1] = 2;
                a[2] = 3;

            int[] b = new int[n] ; //{}
                b[0] = 1;
                b[1] = 2;
                b[2] = 3;
                b[3] = 4;
                b[4] = 5;

                                //.add()


            // a -> c -> b
            // writeline
            // writeline .lenght

            // github создать учетку (можно использовать от windows), посмотреть туторы в интернете по тому, как создать репозиторий и залить туда код. ссылку на репозиторий в телеграм
            list.AddRange(a);
            list.AddRange(b);

            var s = "c = ";
            
            foreach(var i in list)
            {
                s += i + ", ";             
            }
            Console.WriteLine(s);
            */
        }
    }
}

using System;
using System.Collections.Generic;
using Ex21Set.Entities;

namespace Ex21Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> a = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int code = int.Parse(Console.ReadLine());
                a.Add(new Student(code));
            }
            


            HashSet<Student> b = new HashSet<Student>();

            Console.Write("How many students for course B? ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                int code = int.Parse(Console.ReadLine());
                b.Add(new Student(code));
            }
            b.UnionWith(a);

            HashSet<Student> c = new HashSet<Student>();
            
            Console.Write("How many students for course C? ");
            int z = int.Parse(Console.ReadLine());

            for (int i = 1; i <= z; i++)
            {
                int code = int.Parse(Console.ReadLine());
                c.Add(new Student(code));
            }
            c.UnionWith(b);

            Console.WriteLine("Total students: " + c.Count);
        }
    }
}

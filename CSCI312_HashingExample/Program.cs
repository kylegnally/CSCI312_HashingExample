using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_HashingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = null;

            OurHashTable<Student> table = new OurHashTable<Student>();

            // I've replaced the values given by the example file with two values
            // I'd like to know the result of after they're handled.
            for (int i = 100; i < 10000; i += 100)
            {
                s = new Student();
                s.Id = (uint)(99999999);

                table.Add((int)s.Id, s);
            }

            s = new Student();
            s.Id = (uint)(99999899);

            //for (int i = 100; i < 10000; i+= 100)
            //{
            //    s = new Student();
            //    s.ID = (uint)(97+i);

            //    table.Add((int)s.ID, s);
            //}

            //s = new Student();
            //s.ID = (uint)(97 + 9800);

            //table.Add((int)s.ID, s);

            var z = table.Get(999997, new Student { Id = 197 });

            s = new Student();
            s.Id = (uint)(97 + 9900);

            table.Add((int)s.Id, s);

        }
    }
}

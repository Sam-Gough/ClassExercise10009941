using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ID = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] Name = {"Mark", "Jeremy", "Johhny", "Tony", "Andrew", "Pete", "Tim", "Jacob", "Tom", "Greg"};
            int[] ID_2 = new int[10];
            string[] Name_2 = new string[10];

            Console.WriteLine(ID.Length);
            Console.WriteLine("ID Array Length: " + ID.Length);

            Console.WriteLine(Name.Length);
            Console.WriteLine("Name Array Length: " + Name.Length);

            ID.CopyTo(ID_2, 0);
            Name.CopyTo(Name_2, 0);

            

            foreach (int i in ID_2)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            foreach (string i in Name_2)
            {
                Console.Write(i +", ");
            }

            Console.WriteLine();

            Type type = ID.GetType().GetElementType();
            Console.WriteLine(type.ToString());

            Console.WriteLine();

            Type type2 = Name.GetType().GetElementType();
            Console.WriteLine(type2.ToString());

            Console.WriteLine(ID.GetValue(5));
            Console.WriteLine();

            int Find = int.Parse(Console.ReadLine());
            foreach (int x in ID)
            {
               if (x.Equals(Find))
                {
                    Console.WriteLine(x);
                }
            }

            string findname = Console.ReadLine();
            foreach (string x in Name)
            {
                if (x.Equals(findname))
                {
                    Console.WriteLine(x);
                }
            }

            Console.WriteLine();

            Console.ReadKey();


        }
    }
}

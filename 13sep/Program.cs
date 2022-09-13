using System;

namespace _13sep
{

    //program for multicast  deligate...

    class Program
    {
        public delegate void Shape(int length, int height);
        public void show(int l, int h)
        {
            int area = l * h;
            Console.WriteLine("Area is " + area);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Shape s = new Shape(p.show);
            s.Invoke(3, 4);
        }

    }
}


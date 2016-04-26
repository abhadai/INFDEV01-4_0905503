using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        interface INumber
        {
            void visit(INumberVisitor INumberVisitor);
        }

        interface INumberVisitor
        {
            void onMyInt(MyInt MyInt);
            void onMyFloat(MyFloat MyFloat);
        }

        class MyInt : INumber
        {
            public MyInt()
            {
            }

            public void visit(INumberVisitor INumberVisitor)
            {
                INumberVisitor.onMyInt(this);
            }
        }

        class MyFloat : INumber
        {
            public MyFloat()
            {
            }

            public void visit(INumberVisitor INumberVisitor)
            {
                INumberVisitor.onMyFloat(this);
            }
        }

        class NumberVisitor : INumberVisitor
        {
            public void onMyFloat(MyFloat MyFloat)
            {
                Console.WriteLine("Found float!");
            }

            public void onMyInt(MyInt MyInt)
            {
                Console.WriteLine("Found int!");
            }
        }

        static void Main(string[] args)
        {
            NumberVisitor num = new NumberVisitor();
            num.onMyFloat(new MyFloat());
            num.onMyInt(new MyInt());
            Console.Read();
        }
    }
}

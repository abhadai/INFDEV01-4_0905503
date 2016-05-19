using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        interface IOption<T>
        {
            U Visit<U>(IOptionVisitor<T, U> OptionVisitor);
        }

        interface IOptionVisitor<T, U>
        {
            U onSome<U>(T Value);
            U onNone<U>();
        }

        class None<T> : IOption<T>
        {
            public U Visit<U>(IOptionVisitor<T, U> OptionVisitor)
            {
                return OptionVisitor.onNone();
            }
        }

        class Some<T> : IOption<T>
        {
            T Value;

            public Some(T value)
            {
                this.Value = value;
            }

            public U Visit<U>(IOptionVisitor<T, U> OptionVisitor)
            {
                return OptionVisitor.onSome(this.Value);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}


using System;

namespace Tree
{
    public class Quote : Special
    {
	public Quote() { }

        public override void print(Node t, int n, bool p)
        {
            car = t.getCar();
            cdr = t.getCdr();
            t.indent(n);

            Console.Write("'");

            car.print(0, false);

            if(!cdr.isNull()) { Console.Write(" "); }

            cdr.print(0, true);
        }
    }
}


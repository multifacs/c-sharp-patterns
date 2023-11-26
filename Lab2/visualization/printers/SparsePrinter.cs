using Matrices;
using System;

namespace Visualization
{
    internal class SparsePrinter<T> : AbstractPrinter<T>
    {
        protected override string PrintValue(T value)
        {
            if (!Equals(value, default(T)))
            {
                return value.ToString().PadLeft(2, ' ');
            }
            return "  ";
        }
    }
}

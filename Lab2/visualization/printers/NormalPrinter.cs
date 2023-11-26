using Matrices;
using System;

namespace Visualization
{
    internal class NormalPrinter<T> : AbstractPrinter<T>
    {
        protected override string PrintValue(T value)
        {
            return value.ToString().PadLeft(2, ' ');
        }
    }
}

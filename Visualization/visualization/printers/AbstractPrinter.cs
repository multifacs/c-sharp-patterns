using Matrices;
using System.Drawing.Drawing2D;

namespace Visualization
{
    public abstract class AbstractPrinter<T> : IPrinter<T>
    {
        protected abstract string PrintValue(T value);
        public string[] Print(T[] data)
        {
            string[] string_data = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                string_data[i] = PrintValue(data[i]);
            }

            return string_data;
        }
    }
}

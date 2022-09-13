using System;

namespace CustomValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise: Create a custom value type");
            Month mes = 13;
            Console.WriteLine("setValue=" + mes);
            Console.WriteLine("MinValue="+mes.MinValue());
            Console.WriteLine("MaxValue=" + mes.MaxValue());
        }
    }

    public readonly struct Month
    {
        private readonly int _monthValue;

        public Month(int _monthValue)
        {
            if (_monthValue > 12 || _monthValue < 1)
            {
                throw new ArgumentOutOfRangeException("The number must be between 1 and 12 (number of months).");
            }
            this._monthValue = _monthValue;
        }

        public int MinValue() => 1;

        public int MaxValue() => 12;
        

        public static implicit operator Month(int value) => new Month(value);
    
        public override string ToString() => $"{_monthValue}";

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mony mony1 = new Mony(10m);
            Mony mony2 = new Mony(10m);

            Mony mony3 = mony1 + mony2;
            Mony mony4 = mony1 - mony2;

            mony1 = ++mony1;
            mony1 = --mony1;

            bool isTrue = mony1 > mony2;
        }
    }
    public class Mony
    {
        private decimal amount;

        public decimal Amount { get => this.amount; set => this.amount = value; }

        public Mony(decimal amount)
        {
            this.amount = Math.Round(amount, 2);
        }

        public static Mony operator +(Mony mony1, Mony mony2)
        {
            return new Mony(mony1.Amount + mony2.Amount);
        }

        public static Mony operator -(Mony mony1, Mony mony2)
        {
            return new Mony(mony1.Amount + mony2.Amount);
        }

        public static Mony operator ++(Mony mony)
        {
            return new Mony(mony.Amount + 1);
        }

        public static Mony operator --(Mony mony)
        {
            return new Mony(mony.Amount - 1);
        }

        public static bool operator >(Mony mony1, Mony mony2)
        {
            return mony1.Amount > mony2.Amount;
        }

        public static bool operator <(Mony mony1, Mony mony2)
        {
            return mony1.Amount < mony2.Amount;
        }

        public static bool operator >=(Mony mony1, Mony mony2)
        {
            return mony1.Amount >= mony2.Amount;
        }

        public static bool operator <=(Mony mony1, Mony mony2)
        {
            return mony1.Amount <= mony2.Amount;
        }

        public static bool operator ==(Mony mony1, Mony mony2)
        {
            return mony1.Amount == mony2.Amount;
        }

        public static bool operator !=(Mony mony1, Mony mony2)
        {
            return mony1.Amount != mony2.Amount;
        }
    }
}

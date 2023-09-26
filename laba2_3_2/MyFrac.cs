using System;

namespace laba2_3_2
{
    public class MyFrac
    {
        private long nominative, denominative;
        public long Nominative
        {
            get
            {
                return nominative;
            }
        }
        public long Denominative
        {
            get
            {
                return denominative;
            }
        }

        public MyFrac(long nom, long denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denominative can't be zero");
            }
            long sign = 1;
            if ((denom < 0) ^ (nom < 0))
            {
                sign = -1;
            }
            nom = Math.Abs(nom);
            denom = Math.Abs(denom);

            long divisor = CalculateGCD(nom, denom);

            nominative = sign * (nom / divisor);
            denominative = (denom / divisor);
        }
        private long CalculateGCD(long nom, long denom)
        {

            while (nom != 0 && denom != 0)
            {
                if (nom > denom)
                {
                    nom %= denom;
                }
                else
                {
                    denom %= nom;
                }
            }
            return nom + denom;
        }
        public override string ToString()
        {
            return nominative + "/" + denominative;
        }
        public string ToStringWithIntegerPart()
        {
            string sign = "";
            if ((this.nominative < 0))
            {
                sign = "-";
            }
            long nominative = Math.Abs(this.nominative);
            long denominative = this.denominative;
            if (nominative < denominative)
            {
                return sign + nominative + "/" + denominative;
            }
            int integer = (int)Math.Truncate((double)nominative / denominative);
            nominative = nominative - integer * denominative;
            if (nominative == 0)
            {
                return sign + integer.ToString();
            }
            return sign + "(" + integer + "+" + nominative + "/" + denominative + ")";
        }
        public double DoubleValue()
        {
            double res = (double)nominative / denominative;
            return res;
        }
        public static MyFrac Plus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.Nominative * f2.Denominative + f1.Denominative * f2.Nominative, f1.Denominative * f2.Denominative);
        }
        public static MyFrac Minus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.Nominative * f2.Denominative - f1.Denominative * f2.Nominative, f1.Denominative * f2.Denominative);
        }
        public static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.Nominative * f2.Nominative, f1.Denominative * f2.Denominative);
        }
        public static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.Nominative * f2.Denominative, f1.Denominative * f2.Nominative);
        }
        public static MyFrac CalcSum1(int n)
        {
            MyFrac res = new MyFrac(0, 1);
            for (int i = 1; i <= n; i++)
            {
                MyFrac add = new MyFrac(1, i * (i + 1));
                res = Plus(res, add);
            }
            return res;
        }
        public static MyFrac CalcSum2(int n)
        {
            MyFrac res = new MyFrac(1, 1);
            MyFrac one = new MyFrac(1, 1);
            for (int i = 2; i <= n; i++)
            {
                MyFrac minus = Minus(one, new MyFrac(1, i * i));
                res = Multiply(res, minus);
            }
            return res;
        }
    }

}
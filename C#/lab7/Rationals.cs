using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Numbers
{
    class Rationals : IComparable<Rationals>
    {
        private long n;
        private long m;
        public long N
        {
            get { return n; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Not natural enumerator");
                }
                n = value;
            }
        }
        public long M 
        {
            get { return m; }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("0 denominator");
                }
                m = value;
            }
        }

        public Rationals(long n, long m)
        {
            N = n;            
            M = m;
            Cancel(ref this.n, ref this.m);
        }
        public Rationals() 
        {
            M = 1;
            N = 1;            
        }
        
        //conversions 
        public static implicit operator double(Rationals r)
        {
            return (double)r.N / r.M;
        }
        public static implicit operator string(Rationals r)
        {
            return r.ToString();
        }
        public static implicit operator Rationals(double r)
        {
            if (r == 0)
            {
                return new Rationals(0, 1);
            }
            StringBuilder rToString = new StringBuilder(r.ToString());            
            int powOf10 = 0;
            int ind;
            if ((ind = rToString.ToString().IndexOf(',') + 1) != 0)
            {
                rToString.Remove(0, ind);
                powOf10 = rToString.Length;
            }            
            if (powOf10 <= 18)
            {
                long m = (long)Math.Pow(10, powOf10);
                long n = (long)(r * m);
                Cancel(ref n, ref m);
                return new Rationals(n, m);
            }
            else
            {
                throw new ArgumentException("Exceeded maximum length of number");
            }                
        }
        public static implicit operator Rationals(string s)
        {
            //checking with regular expression pattern
            string pattern = @"^\d{1,18}[\.|\,]?\d{0,18}";
            if (Regex.IsMatch(s, pattern))
            {
                StringBuilder result = new StringBuilder(s);
                if (s.Contains("."))
                {
                    result = result.Replace('.', ',');
                }
                return double.Parse(result.ToString());
            }
            else
            {
                throw new ArgumentException("Wrong string format for conversion to Rationals");
            }
        }

        //operators overloading
        public static Rationals operator +(Rationals r1, Rationals r2) 
        {
            long n = r1.N * r2.M + r2.N * r1.M;
            long m = r1.M * r2.M;
            Sign(ref n, ref m);
            return new Rationals(n, m);
        }
        public static Rationals operator -(Rationals r1, Rationals r2)
        {
            long n = r1.N * r2.M - r2.N * r1.M;
            long m = r1.M * r2.M;
            Sign(ref n, ref m);
            return new Rationals(n, m);
        }
        public static Rationals operator *(Rationals r1, Rationals r2)
        {
            long n = r1.N * r2.N;
            long m = r1.M * r2.M;
            Sign(ref n, ref m);
            return new Rationals(n, m);
        }
        public static Rationals operator /(Rationals r1, Rationals r2)
        {
            long n = r1.N * r2.M;
            long m = r1.M * r2.N;
            Sign(ref n, ref m);
            return new Rationals(n, m);
        }
        public static Rationals operator ++(Rationals r1)
        {
            long n = r1.N + r1.M;
            long m = r1.M;
            Sign(ref n, ref m);
            return new Rationals(n, m);
        }
        public static Rationals operator --(Rationals r1)
        {
            long n = r1.N - r1.M;
            long m = r1.M;
            Sign(ref n, ref m);
            return new Rationals(n, m);            
        }

        //method to ensure Enumerator is Natural
        private static void Sign(ref long n, ref long m) 
        {
            if (n < 0)
            {
                n = Math.Abs(n);
                m *= -1;
            }
        }
        //method to reduce fraction
        private static void Cancel(ref long n, ref long m) 
        {
            int maxSieve;
            long absN = Math.Abs(n);
            long absM = Math.Abs(m);
            if (absN > absM)
            {                
                maxSieve = (int)Math.Sqrt(absN);
            }
            else
            {
                maxSieve = (int)Math.Sqrt(absM);
            }
            for (int i = 2; i < maxSieve; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    n /= i;
                    m /= i;
                }
            }
            Sign(ref n, ref m);
        }

        //different string format
        public string DoubleView() 
        {
            return ToString();
        }
        public string FactionView() 
        {
            return $"{N}/{M}";
        }
        public string ScientificView() 
        {
            return $"{(double)N/M:E}";
        }

        //comparisons + System.Object mehods override
        public override string ToString()
        {
            return ((double)N / M).ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }
        public static bool operator ==(Rationals a, Rationals b) => a.Equals(b);
        public static bool operator !=(Rationals a, Rationals b) => !(a.Equals(b));

        int IComparable<Rationals>.CompareTo(Rationals other)
        {
            if ((double)N / M > (double)other.N / other.M)
            {
                return 1;
            }
            if ((double)N / M < (double)other.N / other.M)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static bool operator >(Rationals a, Rationals b) => ((IComparable<Rationals>)a).CompareTo(b) == 1;
        public static bool operator <(Rationals a, Rationals b) => ((IComparable<Rationals>)a).CompareTo(b) == -1;
        public static bool operator >=(Rationals a, Rationals b) => ((IComparable<Rationals>)a).CompareTo(b) >= 0;
        public static bool operator <=(Rationals a, Rationals b) => ((IComparable<Rationals>)a).CompareTo(b) <= 0;
    }
}

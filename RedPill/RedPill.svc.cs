using System;
using System.Linq;

namespace RedPill
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            return new Guid("43d4ab89-202b-42fc-93ce-c5a74a1d2a28");
        }

        public long FibonacciNumber(long n)
        {

            if (n > 100L || n < 0)
                throw new ArgumentOutOfRangeException("n", "Out of range exception");

            if (n == 0L) return 0L;
            if (n == 1) return 1L;

            var result = 0L;
            var prev = 1L;
            var prevPrev = 0L;

            for (var i = 2; i <= n; i++)
            {
                result = prev + prevPrev;
                prevPrev = prev;
                prev = result;
            }
            return result;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.Error;
            if (a == b && a == c)
                return TriangleType.Equilateral;
            if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            return TriangleType.Scalene;
        }

        public string ReverseWords(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s", "null exception");

            var arrWords = s.Split(' ');
            var revWords = arrWords.Select(x => new String(x.Reverse().ToArray())).ToArray();

            return string.Join(" ", revWords);
        }

    }


}


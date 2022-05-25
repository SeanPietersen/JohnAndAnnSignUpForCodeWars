using System;
using System.Collections.Generic;
using System.Linq;

namespace TheNumberOfKatasJohnAndAnnDo.App
{
    public class NumberOfKatasJohnAndAnnDid : INumberOfKatasJohnAndAnnDid
    {

        public List<long> Ann(long n)
        {
            var ListToReturnForAnn = new List<long>();
            var ListToReturnForJohn = new List<long>();

            var valueForAnn = 1;
            var valueForJohn = 0;
            ListToReturnForJohn.Add(valueForJohn);

            for (int i = 0; i < n; i++)
            {
                ListToReturnForAnn.Add(valueForAnn);

                valueForJohn = i+1 - (int)ListToReturnForAnn.ElementAt((int)ListToReturnForJohn.ElementAt(i));
                ListToReturnForJohn.Add(valueForJohn);
                valueForAnn = i+1 - (int)ListToReturnForJohn.ElementAt((int)ListToReturnForAnn.ElementAt(i));
            }

            return ListToReturnForAnn;

        }


        public List<long> John(long n)
        {
            return CalculateKatasPerDay()
        }

        public List<long> CalculateKatasPerDay(int start)
        {
            var ListToReturnForAnn = new List<long>();
            var ListToReturnForJohn = new List<long>();

            var valueForAnn = 1;
            var valueForJohn = 0;
            ListToReturnForJohn.Add(valueForJohn);

            for (int i = start; i < n; i++)
            {
                ListToReturnForAnn.Add(valueForAnn);

                valueForJohn = i - (int)ListToReturnForAnn.ElementAt((int)ListToReturnForJohn.ElementAt(i - 1));
                ListToReturnForJohn.Add(valueForJohn);
                valueForAnn = i - (int)ListToReturnForJohn.ElementAt((int)ListToReturnForAnn.ElementAt(i - 1));
            }

            return ListToReturnForJohn;
        }


        public long SumAnn(long n)
        {
            long sum = 0;
            foreach(var value in Ann(n))
            {
                sum += value;
            }
            return sum;
        }

        public long SumJohn(long n)
        {
            long sum = 0;
            foreach (var value in John(n))
            {
                sum += value;
            }
            return sum;
        }
    }
}

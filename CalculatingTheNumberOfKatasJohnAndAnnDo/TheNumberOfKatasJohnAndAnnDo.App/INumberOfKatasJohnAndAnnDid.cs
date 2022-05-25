using System.Collections.Generic;

namespace TheNumberOfKatasJohnAndAnnDo.App
{
    public interface INumberOfKatasJohnAndAnnDid
    {
        List<long> John(long n);

        List<long> Ann(long n);

        long SumJohn(long n);

        long SumAnn(long n);
    }
}

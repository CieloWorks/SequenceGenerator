using System;

namespace SequenceGeneratorLib
{
    //The Liebniz sequence is defined as follows:
    //
    //T(0) = 1
    //T(n where n > 0) =
    //  -1 / (2n + 1) when n is odd
    //   1 / (2n + 1) when n is even

    //Implement this sequence generator based on the ISequenceGenerator interface
    public class LiebnizSequenceGenerator
    {
        public double GenerateNthTerm(int n)
        {
            throw new NotImplementedException("This method should be implemented as part of the code exercise");
        }

        public double SumOfTerms(int n)
        {
            var result = 0.0;
            for (var i = 0; i <= n; ++i)
            {
                result += GenerateNthTerm(i);
            }

            return result;
        }
    }
}

namespace SequenceGeneratorLib
{
    public interface ISequenceGenerator
    {
        /// <summary>
        /// Returns the nth term in a numeric sequence
        /// </summary>
        /// <param name="n">The index of the term to be returned</param>
        /// <returns>The nth term in a numeric sequence</returns>
        double GenerateNthTerm(int n);

        /// <summary>
        /// The sum of all terms in the sequence from 0 to the input number
        /// </summary>
        /// <param name="n">The number of terms from the sequence that should be added</param>
        /// <returns>The sum of all terms in the sequence from 0 to the input number</returns>
        double SumOfTerms(int n);
    }
}

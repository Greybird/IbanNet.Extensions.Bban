﻿namespace IbanNet.CheckDigits.Calculators
{
    /// <summary>
    /// Computes the check digits using CIN algorithm.
    /// </summary>
    /// <remarks>
    /// http://www.artico.name/soft/iban/wiban.htm#cin
    /// </remarks>
    internal class CinCheckDigitsCalculator : ICheckDigitsCalculator
    {
        private static readonly int[] OddWeights = { 1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23, 27, 28, 26 };
        private static readonly int[] EvenWeights = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };

        public int Compute(char[] value)
        {
            int i = 0;
            int sum = 0;
            foreach (char c in value)
            {
                int number = char.IsNumber(c)
                    ? c - '0'
                    : char.ToUpperInvariant(c) - 'A';
                int[] takeWeightsFrom = (i & 1) == 1 ? EvenWeights : OddWeights;
                sum += takeWeightsFrom[number];
                i++;
            }

            return sum % 26;
        }
    }
}

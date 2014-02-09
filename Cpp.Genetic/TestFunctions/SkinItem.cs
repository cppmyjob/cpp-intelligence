using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cpp.Genetic.TestFunctions
{
    public class SkinItem : GeneticItem
    {
        public SkinItem(GeneticInitData initData)
            : base(initData)
        {
        }

        public double GetX(int offset)
        {

            double result =
                (int)(10 * Values[offset  + 0]) * 0.1 +
                (int)(10 * Values[offset  + 1]) * 0.01 +
                (int)(10 * Values[offset  + 2]) * 0.001 +
                (int)(10 * Values[offset  + 3]) * 0.0001 +
                (int)(10 * Values[offset  + 4]) * 0.00001 +
                (int)(10 * Values[offset  + 5]) * 0.000001 +
                (int)(10 * Values[offset  + 6]) * 0.0000001 +
                (int)(10 * Values[offset  + 7]) * 0.00000001 +
                (int)(10 * Values[offset  + 8]) * 0.000000001 +
                (int)(10 * Values[offset  + 9]) * 0.0000000001 +
                (int)(10 * Values[offset + 10]) * 0.00000000001 +
                (int)(10 * Values[offset + 11]) * 0.000000000001 +
                (int)(10 * Values[offset + 12]) * 0.0000000000001 +
                (int)(10 * Values[offset + 13]) * 0.00000000000001 +
                (int)(10 * Values[offset + 14]) * 0.000000000000001;
            return result;
        }


        protected internal override double CreateValue(double random)
        {
            return random * 0.99999999999999999;
        }
    }
}

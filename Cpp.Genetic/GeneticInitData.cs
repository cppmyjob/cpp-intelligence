using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cpp.Genetic
{
    public class GeneticInitData
    {
        private int _count;
        private int _yearOfBorn;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public int YearOfBorn
        {
            get { return _yearOfBorn; }
            set { _yearOfBorn = value; }
        }
    }
}

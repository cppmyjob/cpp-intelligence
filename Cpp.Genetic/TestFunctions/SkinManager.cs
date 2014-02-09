using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cpp.Genetic.TestFunctions
{
    public class SkinManager : GeneticManager
    {
        public SkinManager(int itemsCount, int surviveCount) :
            base(itemsCount, surviveCount, 30) 
        {

        }

        //protected override double InternalCalculateFitness(GeneticItem item, int processor)
        //{
        //    double lastFitness = CalculateFitness(item, processor);
        //    for (int i = 0; i < 10; i++)
        //    {
        //        ((MoveGeneticItem)item).SaveValues();
        //        ((MoveGeneticItem)item).MoveValues();

        //        double fitness = CalculateFitness(item, processor);
        //        if (fitness <= lastFitness)
        //        {
        //            ((MoveGeneticItem)item).RestoreValues();
        //            return lastFitness;
        //        }
        //        lastFitness = fitness;
        //    }
        //    return lastFitness;
        //}

        public override double CalculateFitness(GeneticItem item, int processor)
        {
            double x1 = ((SkinItem) item).GetX(0) * 10 - 5;
            double x2 = ((SkinItem)item).GetX(15) * 10 - 5;
            double value =
                Math.Pow(Math.Cos(2 * x1 * x1) - 0.11e1, 0.2e1) + Math.Pow(Math.Sin(0.5e0 * x1) - 0.12e1, 0.2e1) - Math.Pow(Math.Cos(2 * x2 * x2) - 0.11e1, 0.2e1) + Math.Pow(Math.Sin(0.5e0 * x2) - 0.12e1, 0.2e1);
            return value;
        }

        protected override GeneticItem CreateItem(GeneticInitData initData)
        {
            return new SkinItem(initData);
        }
    }
}

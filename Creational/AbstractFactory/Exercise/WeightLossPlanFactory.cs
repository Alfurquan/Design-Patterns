using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Exercise
{
    public class WeightLossPlanFactory : IPlanFactory
    {
        public IMealPlan CreateMealPlan()
        {
            return new WeightLossMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new WeightLossWorkout();
        }
    }
}

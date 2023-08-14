using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Exercise
{
    public class HomePage
    {
        private IWorkoutPlan workoutPlan;
        private IMealPlan mealPlan;

        public void SetGoal(IPlanFactory factory)
        {
            factory.CreateWorkoutPlan().PrintPlan();
            factory.CreateMealPlan().PrintPlan();
        }
    }
}

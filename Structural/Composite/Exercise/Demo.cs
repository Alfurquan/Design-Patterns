﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var subTeam1 = new Team();
            subTeam1.Add(new Truck());
            subTeam1.Add(new HumanResource());
            subTeam1.Add(new HumanResource());

            var subTeam2 = new Team();
            subTeam2.Add(new Truck());
            subTeam2.Add(new HumanResource());
            subTeam2.Add(new HumanResource());

            var team = new Team();
            team.Add(subTeam1);
            team.Add(subTeam2);

            team.Deploy();
        }
    }
}

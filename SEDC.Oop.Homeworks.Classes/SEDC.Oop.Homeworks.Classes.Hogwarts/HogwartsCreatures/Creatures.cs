using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Homeworks.Classes.Hogwarts.Creatures
{
    public class TheCreatures
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set; }
        public bool IsTamed { get; set; }

    public TheCreatures (string name,int powerLevel, int age, bool isTamed)
    {
        Name = name;
        Age = age;
        IsTamed = isTamed;
        PowerLevel = powerLevel;
    }


    }


}

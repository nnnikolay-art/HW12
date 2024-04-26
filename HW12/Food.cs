using System;

namespace HW12
{
    public class Food : IMyCloneable<Food>, ICloneable
    {
        public Food(string name)
        {
            Name = name;
        }
        public string Name;
        public virtual Food MyClone()
        {
            return new Food(Name);
        }

        public virtual object Clone()
        {
            return this.MyClone();
        }
    }
}

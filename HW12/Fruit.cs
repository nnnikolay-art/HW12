using System;

namespace HW12
{
    public class Fruit : Food, ICloneable
    {
        public bool Eatable;

        public Fruit(string name, bool eatable) : base(name)
        {
            Eatable = eatable;
        }

        public override object Clone()
        {
            return this.MyClone();
        }

        public override Fruit MyClone()
        {
            return new Fruit(Name, Eatable);
        }

    }
}

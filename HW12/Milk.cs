using System;

namespace HW12
{
    public class Milk : Fruit, ICloneable
    {
        public int Volume;

        public Milk(string name, bool eatable, int volume) : base(name, eatable)
        {
            Volume = volume;
        }

        public override Milk MyClone()
        {
            return new Milk(Name, Eatable, Volume);
        }
        public override object Clone()
        {
            return MyClone();
        }

        public override bool Equals(object? obj)
        {
            var clone = (Milk)obj;
            return (Volume.Equals(clone.Volume) && Eatable.Equals(clone.Eatable) && Name.Equals(clone.Name));
        }

    }
}

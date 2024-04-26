namespace HW12
{
    public class Banana : Fruit
    {
        public int Weight;

        public Banana(string name, bool Eatable, int weight) : base(name, Eatable)
        {
            Weight = weight;
        }

        public override Banana MyClone()
        {
            return new Banana(Name, Eatable, Weight);
        }

        public override bool Equals(object? obj)
        {
            var clone = (Banana)obj;
            return (Weight.Equals(clone.Weight) && Eatable.Equals(clone.Eatable) && Name.Equals(clone.Name));
        }
    }
}

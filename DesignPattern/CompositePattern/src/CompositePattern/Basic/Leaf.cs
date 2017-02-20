using System;

namespace CompositePattern.Basic
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(depth+ " : " + Name);
             }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
    }
}

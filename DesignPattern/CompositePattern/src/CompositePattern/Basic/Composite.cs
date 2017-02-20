namespace CompositePattern.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(depth + " : " + Name);
            foreach(Component child in _children)
            {
                child.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }
    }
}

namespace CompositePattern.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public abstract class Component
    {
        protected string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}

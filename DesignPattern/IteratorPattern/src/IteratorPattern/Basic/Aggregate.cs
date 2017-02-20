namespace IteratorPattern.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}

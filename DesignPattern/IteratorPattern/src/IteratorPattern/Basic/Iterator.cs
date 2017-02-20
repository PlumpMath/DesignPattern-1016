namespace IteratorPattern.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public abstract class Iterator
    {
        public abstract bool HasNext();
        public abstract object Next();
    }
}

namespace IteratorPattern.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ConcreteIterator : Iterator
    {
        private Aggregate[] _aggregates;
        private int position = 0;
        public ConcreteIterator(Aggregate[] aggregates)
        {
            _aggregates = aggregates;
        }
        public override bool HasNext()
        {
            if(position>=_aggregates.Length||_aggregates[position]==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override object Next()
        {
            return _aggregates[position++];
        }

       
    }
}

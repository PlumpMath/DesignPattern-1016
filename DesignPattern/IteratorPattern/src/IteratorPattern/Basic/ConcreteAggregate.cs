namespace IteratorPattern.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ConcreteAggregate : Aggregate
    {
        private Aggregate[] _aggregates;
        public ConcreteAggregate()
        {

        }

        public ConcreteAggregate(int size)
        {
            _aggregates = new Aggregate[size];
        }
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(_aggregates);
        }

        public object this[int index]
        {
            get
            {
                return _aggregates[index];
            }
            set
            {
                _aggregates[index] = (ConcreteAggregate)value;
            }
        }
    }
}

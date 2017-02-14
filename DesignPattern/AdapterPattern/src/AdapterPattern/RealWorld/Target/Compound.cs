namespace AdapterPattern.RealWorld.Target
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

     //this is the target class
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

       
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
}

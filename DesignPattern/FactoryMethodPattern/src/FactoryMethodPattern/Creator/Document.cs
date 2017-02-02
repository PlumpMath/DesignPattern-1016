namespace FactoryMethodPattern.Creator
{
    using Product;
    using System.Collections.Generic;
    public abstract class Document
    {
        public List<Page> Pages = new List<Page>();
        public Document()
        {
            this.CreateDocument();
        }

        public abstract void CreateDocument();
    }
}

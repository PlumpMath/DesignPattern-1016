namespace FactoryMethodPattern.ConcreateCreators
{
    using Creator;
    using ConcreateProducts;

    public class Report : Document
    {
        public override void CreateDocument()
        {
            Pages.Add(new SummaryPage());
          }
    }
}

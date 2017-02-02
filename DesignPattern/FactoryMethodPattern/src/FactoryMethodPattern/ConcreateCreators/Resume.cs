namespace FactoryMethodPattern.ConcreateCreators
{
    using System;
    using Creator;
    using ConcreateProducts;
    public class Resume : Document
    {
        public override void CreateDocument()
        {
            Pages.Add(new EducationPage());
            Pages.Add(new SkillsPage());
        }
    }
}

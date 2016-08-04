using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class BrushingOfTeethSteps
    {
        [Given]
        public void Given_there_is_GRAMS_gram_of_BRAND_toothpaste_on_the_brush(int grams, string brand)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void Given_the_month_is_open()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_the_back_teeth_are_brushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_the_from_teeth_are_brushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_teeth_look_clean()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_month_feels_fresh()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_braces_aren_t_damaged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

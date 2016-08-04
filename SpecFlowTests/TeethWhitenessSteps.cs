using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class TeethWhitenessSteps
    {
        [Given(@"I'm using ""(.*)"" brand toothpaste")]
        public void GivenIMUsingBrandToothpaste(string brand)
        {
            ScenarioContext.Current.Add("brand name", brand);
        }
        
        [When(@"I brush for (.*) minutes")]
        public void WhenIBrushForMinutes(string p0)
        {
            var brandName = ScenarioContext.Current["brand name"];
        }
        
        [Then(@"the teeth look (.*) white")]
        public void ThenTheTeethLookWhite(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

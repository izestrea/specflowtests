using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class TeethWhitenessSteps
    {
        [Given(@"I'm using ""(.*)"" brand toothpaste")]
        public void GivenIMUsingBrandToothpaste(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I brush for (.*) minutes")]
        public void WhenIBrushForMinutes(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the teeth look (.*) white")]
        public void ThenTheTeethLookWhite(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

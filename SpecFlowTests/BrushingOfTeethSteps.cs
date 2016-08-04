using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class BrushingOfTeethSteps
    {
        [Given(@"there is toothpaste on the brush")]
        public void GivenHereIsToothpasteOnTheBrush()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the month is open")]
        public void GivenTheMonthIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the back teeth are brushed")]
        public void WhenTheBackTeethAreBrushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the fron teeth are brushed")]
        public void WhenTheFronTeethAreBrushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the teeth look clean")]
        public void ThenTheTeethLookClean()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the month feels fresh")]
        public void ThenTheMonthFeelsFresh()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the braces aren't damaged")]
        public void ThenTheBracesArenTDamaged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

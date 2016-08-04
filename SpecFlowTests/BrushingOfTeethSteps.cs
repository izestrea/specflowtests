using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class BrushingOfTeethSteps
    {
        [Given]
        public void Given_I_have_the_following_tools(Table table)
        {
            var firstToolName = table.Rows[0][0];
            var firstToolQuality = table.Rows[0][1];

            var secondToolName = table.Rows[1]["ToolName"];
            var secondToolQuality = table.Rows[1]["ToolQuality"];

            var isToolColorColumnSpecified = table.ContainsColumn("Color");

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

using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject2
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double pi;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(double p0)
        {
            pi = p0;
        }
        
        [When(@"the sinus is calculated")]
        public void WhenTheSinusIsCalculated()
        {
            Math.Sin(pi);
        }
        
        [When(@"the cosinus is calculated")]
        public void WhenTheCosinusIsCalculated()
        {
            Math.Cos(pi);
        }
        
        [When(@"the tangens is calculated")]
        public void WhenTheTangensIsCalculated()
        {
            Math.Tan(pi);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = pi;
            Assert.Equal(expected, actual);
        }
    }
}

using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Examples.Allure.SpecFlow.Test
{
    [Binding]
    public class Steps
    {
        [Given("the first step passes")]
        public void Step1()
        {
        }

        [When("the second step passes")]
        public void Step2()
        {
        }

        [Then("the third step also passes")]
        public void Step3()
        {
            var value = true;
            Assert.That(value, Is.True);
        }
    }
}

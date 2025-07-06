using System;
using Reqnroll;

namespace TestAutomationCVExample.UI
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("user is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            throw new PendingStepException();
        }

        [When("user enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            throw new PendingStepException();
        }

        [Then("user should be redirected to the dashboard")]
        public void ThenUserShouldBeRedirectedToTheDashboard()
        {
            throw new PendingStepException();
        }
    }
}

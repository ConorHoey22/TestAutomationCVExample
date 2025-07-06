using System;
using Reqnroll;

namespace TestAutomationCVExample.Test.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("user is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
           Console.WriteLine("User is on the login page."); 
        }

        [When("user enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            Console.WriteLine("User is on the login page.");
        }

        [Then("user should be redirected to the dashboard")]
        public void ThenUserShouldBeRedirectedToTheDashboard()
        {
            Console.WriteLine("User is on the login page.");
        }
    }
}

# Blue Sombrero Coding Test

Hi. Here at Blue Sombrero we aren't fans of white board coding tests. They often aren't representative of the actual work you'll be doing. You'll be able to complete this test in the comfort of your own home or your favorite coffee shop. There's no time limit (we do ask you to complete the test prior to your in person interview) and feel free to use any online resource for help. We don't mind you asking a friend for help but please take only their advice and not their offer of completing the test for you.

## Setup

In order to complete this test, you'll need the following
* Visual Studio 2017 Community version 15.4.4 
* .NET Core 2.0
* Clone this repository to your local machine

## Scenario

We are an Agile/Scrum shop so here's an example story you might see:

----------------------------------------------------------------

**User Story**

As an admin user, I want to be able to select which Background Check Provider my users use. 

**Acceptance Criteria**

In the admin settings area, I want to select a background check provider from a drop down list

**Sub-Tasks**
* Modify the Admin Settings Screen
* Modify the Background Check API to handle multiple providers (**Your Task**)

-----------------------------------------------------------------

**Developer Assignment**

As you can see from the story above, your task is to modify the existing background check api to handle multiple providers. Let's take a look at the code together. There's one controller and one service class that currently handles the call to the existing background check provider API.

*VerifyController*

```
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    [Route("api/[controller]")]
    public class VerifyController : Controller
    {
        [HttpPost]
        [Route("register")]
        public IActionResult Post([FromBody]string firstName, [FromBody]string lastName, [FromBody]string dateOfBirth)
        {
            return Ok(BackgroundCheckService.RegisterApplicant(firstName, lastName, dateOfBirth));
        }

        [HttpPost]
        public IActionResult Post([FromBody]string ssn, [FromBody]string applicantId)
        {
            return Ok(BackgroundCheckService.VerifyApplication(ssn, applicantId));
        }
    }
}
```
  
  
  This API exposes two POST methods - One for Registering an Applicant with the Background Check Provider and one for verification.
  
  Let's take a look at the service file
  
  ```
  using System;

namespace CodingTest
{
    public static class BackgroundCheckService
    {
        public static string RegisterApplicant(string firstName, string lastName, string dateOfBirth)
        {
            //Code to send application information to background check API.
            return Guid.NewGuid().ToString();
        }

        public static bool VerifyApplication(string ssn, string applicantId)
        {
            //Code to send the SSN and Applicant ID to background check API
            return ssn == "555-55-5555";
        }
    }
}

  ```
  
  As you can see, it's a basic implementation. 
  
  ## Your Task
  
  The API needs to be modified to call the correct implementation of the background check provider based off some identifer that should be passed in when making a POST to either method (RegisterApplicant/VerifyApplication)
  
  * Refactor the VerifyController POST methods to accept this identifier (implementation is up to you)
  * Refactor the BackgroundCheckService class to account for multiple background check implementations while exposing the same methods (RegisterApplicant/VerifyApplication) to the controller class.
  * Write your code as if it were being deployed to production.
  * Keep in mind that this API is currently being used in production.
  

  
